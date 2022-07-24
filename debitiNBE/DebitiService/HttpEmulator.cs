using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SharedLibrary.GeneralUse.MySqlTool;



namespace debitiNBEService
{

    static class Global
    {
        static public readonly string CONNECTION_STR = "server=localhost;database=debiti;uid=root;pwd=toor";
    }

    class HttpEmulator
    {
        public string GetUserList()
        {
            List<UserData> usl = new List<UserData>();
            MySqlReader sqlReader = new MySqlReader(Global.CONNECTION_STR);
            sqlReader.ReadFrom("ID_user,user", "debiti.user");
            while (sqlReader.DataReader.Read())
            {
                UserData us = new UserData()
                {
                    ID_User = (int)sqlReader.DataReader[0],
                    UserName = sqlReader.DataReader[1].ToString()
                };
                usl.Add(us);
            }


            if (usl.Count > 0)
                return JsonConvert.SerializeObject(usl, Formatting.Indented);
            else
                return null;

        }
        public string GetUserData(string UserName, string CodePassword)
        {
            UserData us = new UserData();


            MySqlReader accedi = new MySqlReader(Global.CONNECTION_STR);
            accedi.ReadFrom("ID_user,user, Password ", "debiti.user", "User = '" + UserName + "' and password = '" + CodePassword + "'");

            if (accedi.DataReader.Read())
            {
                us = new UserData()
                {
                    ID_User = (int)accedi.DataReader[0],
                    UserName = accedi.DataReader[1].ToString()
                };
            }


            return JsonConvert.SerializeObject(us, Formatting.Indented);
        }

        private string GetUserNamedebit(int ID)
        {
            MySqlReader sqlReaderUser = new MySqlReader(Global.CONNECTION_STR);
            sqlReaderUser.ReadFrom("user", "debiti.user", "ID_user =" + ID);

            if (sqlReaderUser.DataReader.Read())
                return sqlReaderUser.DataReader[0].ToString();
            else
                return null;
        }

        public string GetRequestList(string ID_user)
        {
            List<RequestData> request = new List<RequestData>();

            MySqlReader Request = new MySqlReader(Global.CONNECTION_STR);
            Request.ReadFrom("*", "debiti.request", "KS_ID_user_ricevente=" + ID_user + " and accepted = 0");


            while (Request.DataReader.Read())
            {



                RequestData rd = new RequestData() //instanzio un oggetto requestdata
                {
                    ID_Request = (int)Request.DataReader[0],
                    ID_Mandante = (int)Request.DataReader[1],
                    User = GetUserNamedebit((int)Request.DataReader[1]),
                    Importo = (double.Parse(Request.DataReader[3].ToString()))
                };

                request.Add(rd);//aggiungo l oggetto alla lista
            }


            if (request.Count > 0)
                return JsonConvert.SerializeObject(request, Formatting.Indented);
            else
                return null;
        }

        public string GetReqestSaldoList(string ID_user)
        {

            List<RequestData> request = new List<RequestData>();


            MySqlReader PayRequest = new MySqlReader(Global.CONNECTION_STR);
            PayRequest.ReadFrom("*", "debiti.payrequest");

            while (PayRequest.DataReader.Read())
            {

                MySqlReader Request = new MySqlReader(Global.CONNECTION_STR);
                Request.ReadFrom("credito,KS_ID_user_ricevente", "debiti.request", "ID_Request =" + PayRequest.DataReader[1] + " AND KS_ID_user_mandante = " + ID_user);
                while (Request.DataReader.Read())
                {

                    RequestData srd = new RequestData()
                    {
                        ID_SaldoRequest = (int)PayRequest.DataReader[0],
                        ID_Mandante = int.Parse(ID_user),
                        User = GetUserNamedebit((int)Request.DataReader[1]),
                        ID_Request = (int)PayRequest.DataReader[1],
                        Importo = double.Parse(PayRequest.DataReader[2].ToString()),

                    };

                    request.Add(srd);
                }


            }
            if (request.Count > 0)
                return JsonConvert.SerializeObject(request, Formatting.Indented);
            else
                return null;
        }

        public string GetAccepted(string ID_User)
        {
            List<RequestData> AcceptedRequest = new List<RequestData>();


            MySqlReader Request = new MySqlReader(Global.CONNECTION_STR);
            Request.ReadFrom("*", "debiti.request", "KS_ID_user_ricevente=" + ID_User + " and accepted = 1");


            while (Request.DataReader.Read())
            {
                RequestData rd = new RequestData() //instanzio un oggetto requestdata
                {
                    ID_Mandante = (int)Request.DataReader[1],
                    User = GetUserNamedebit((int)Request.DataReader[1]),
                    ID_Request = (int)Request.DataReader[0],
                    Importo = float.Parse(Request.DataReader[3].ToString())
                };

                AcceptedRequest.Add(rd);

            }

            if (AcceptedRequest.Count > 0)
                return JsonConvert.SerializeObject(AcceptedRequest, Formatting.Indented);
            else
                return null;

        }

        public string GetSaldiRequest(string ID_request)
        {
            double SaldatoParzialeR = 0;
            MySqlReader sqlReader = new MySqlReader(Global.CONNECTION_STR);
            sqlReader.ReadFrom("credito", "debiti.payrequest", "ID_Request = " + ID_request);
            while (sqlReader.DataReader.Read())
                SaldatoParzialeR += double.Parse(sqlReader.DataReader[0].ToString());
            sqlReader.DataReader.Close();

            return SaldatoParzialeR.ToString();
        }



        public bool PostRequest(string Ricevente_userName, string ID_mandante, string isChecked, string Importo)
        {
            int ID_rivcevente = -1;
            MySqlReader sqlReader = new MySqlReader(Global.CONNECTION_STR);
            MySqlWriter sqlWriter = new MySqlWriter(Global.CONNECTION_STR);
            sqlReader.ReadFrom("ID_user", "debiti.user", "user = '" + Ricevente_userName + "'");
            if (sqlReader.DataReader.Read())
                ID_rivcevente = (int)sqlReader.DataReader[0];

            if (ID_rivcevente >= 0)
            {
                sqlWriter.ExecuteWriteCommand("INSERT INTO debiti.request  (KS_ID_user_mandante, KS_ID_user_ricevente, credito ) VALUE(" + ID_mandante + "," + ID_rivcevente + "," + ((bool.Parse(isChecked) ? Importo : "-"+Importo) + ")"));
                return true;
            }
            else
                return false;
        }
        public void PostSaldo(string ID_request, string Saldo)
        {

            double SaldatoParzialeR = double.Parse(GetSaldiRequest(ID_request));
            double debito = 0;
            MySqlReader sqlReader = new MySqlReader(Global.CONNECTION_STR);
            MySqlWriter sqlWriter = new MySqlWriter(Global.CONNECTION_STR);



            sqlReader.ReadFrom("credito", "debiti.request", "ID_Request = " + ID_request);
            if (sqlReader.DataReader.Read())
                debito = double.Parse(sqlReader.DataReader[0].ToString());
            sqlReader.DataReader.Close();



            if ((SaldatoParzialeR + double.Parse(Saldo)) <= debito)
                sqlWriter.ExecuteWriteCommand("INSERT INTO debiti.payrequest (ID_request, credito) VALUES(" + ID_request + "," + Saldo + ")");



        }




        public void PutRequest(string ID_PayRequest)
        {
            MySqlWriter sqlWriter = new MySqlWriter(Global.CONNECTION_STR);
            sqlWriter.ExecuteWriteCommand("UPDATE debiti.request SET accepted = 1 WHERE ID_Request = " + ID_PayRequest);
        }

        public void PutSaldoRequest(string ID_PayRequest)
        {
            MySqlReader sqlreadepay = new MySqlReader(Global.CONNECTION_STR);
            MySqlReader sqlreadeRequest = new MySqlReader(Global.CONNECTION_STR);

            sqlreadepay.ReadFrom("ID_request,credito", "debiti.payrequest", "ID_PayRequest =" + ID_PayRequest);
            if (sqlreadepay.DataReader.Read())
            {
                sqlreadeRequest.ReadFrom("credito", "debiti.request", "ID_Request = " + sqlreadepay.DataReader[0].ToString());

                if (sqlreadeRequest.DataReader.Read())
                {
                    MySqlWriter sqlWriter = new MySqlWriter(Global.CONNECTION_STR);
                    sqlWriter.ExecuteWriteCommand("UPDATE debiti.request SET credito =" + (double.Parse(sqlreadeRequest.DataReader[0].ToString()) - double.Parse(sqlreadepay.DataReader[1].ToString())) + " WHERE ID_Request = " + (int)sqlreadepay.DataReader[0]);


                    DeleteSaldoRequest(ID_PayRequest);
                    if ((double.Parse(sqlreadeRequest.DataReader[0].ToString()) - double.Parse(sqlreadepay.DataReader[1].ToString())) <= 0)
                        DeleteRequest(sqlreadepay.DataReader[0].ToString());
                }
            }
        }
        public void DeleteRequest(string ID_Request)
        {
            MySqlWriter sqlWriter = new MySqlWriter(Global.CONNECTION_STR);
            sqlWriter.ExecuteWriteCommand("DELETE FROM debiti.request WHERE ID_Request = " + ID_Request);
        }

        public void DeleteSaldoRequest(string ID_PayRequest)
        {
            MySqlWriter sqlWriter = new MySqlWriter(Global.CONNECTION_STR);
            sqlWriter.ExecuteWriteCommand("DELETE FROM debiti.payrequest WHERE ID_PayRequest = " + ID_PayRequest);
        }

    }
}
