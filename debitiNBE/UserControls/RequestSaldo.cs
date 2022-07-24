using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace debitiNBE
{
    public partial class RequestSaldo : Request
    {
        public RequestSaldo()
        {
            Type.Text = "saldo";
        }



        override public void ReadRequest()
        {
            string JsonRequesList = Global.HttpEmulator.GetReqestSaldoList(Global.UserData.ID_User.ToString());

            if (!string.IsNullOrEmpty(JsonRequesList))
            {
                request = JsonConvert.DeserializeObject<List<RequestData>>(JsonRequesList); //instanzio una lista Reqeust dataù
                index = 0;
            }
            else
                request = new List<RequestData>();
            RequestUpdate();
        }



        override protected void SendData()
        {


            if (request.Count > 0)
            {
                if (AccettaRad.Checked)
                {
                    Global.HttpEmulator.PutSaldoRequest(request[index].ID_SaldoRequest.ToString());
                    
                    request.RemoveAt(index);
                }
                else
                {
                    Global.HttpEmulator.DeleteSaldoRequest(request[index].ID_SaldoRequest.ToString());
                    request.RemoveAt(index);
                }


                UserForm.Singleton.ActiveUpdate();

                RightButtonRequest_Click(this, new EventArgs());
            }
        }



        
    }
}
