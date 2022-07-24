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

namespace debitiNBE
{
    public partial class Request : UserControl
    {
         protected IList<RequestData> request; //dichiaro un interfaccia list di request data
         public int index = -1;

        public Request()
        {
            InitializeComponent();
            Type.Text = "debito";
        }

        private void Request_Load(object sender, EventArgs e)
        {
            ReadRequest();
        }

        virtual public void ReadRequest()
        {
            string JsonRequesList = Global.HttpEmulator.GetRequestList(Global.UserData.ID_User.ToString());

            if (!string.IsNullOrEmpty(JsonRequesList))
            {
                request = JsonConvert.DeserializeObject<List<RequestData>>(JsonRequesList); //instanzio una lista Reqeust data
                index = 0;
            }
            else
                request = new List<RequestData>();
            RequestUpdate();
        }



        public void RequestUpdate()
        {
            if (request.Count != 0)
            {
                UserRequest.Text = request[index].User;
                ImportoRichiesto.Text = request[index].Importo.ToString();
            }
            else
            {
                UserRequest.Text = "Nessuna Richiesta";
                ImportoRichiesto.Text = "NaN";

            }

        }




        virtual protected void SendData()
        {
            if (request.Count > 0)
            {
                if (AccettaRad.Checked)
                {
                    Global.HttpEmulator.PutRequest(request[index].ID_Request.ToString());


                    if (request[index].Importo < 0)
                        Global.UserData.AcceptedCrediti.Add(request[index]);
                    else if (request[index].Importo > 0)
                        Global.UserData.AcceptedDebiti.Add(request[index]);
                    UserForm.Singleton.ActiveUpdate();

                    request.RemoveAt(index);
                }
                else
                {
                    Global.HttpEmulator.DeleteRequest(request[index].ID_Request.ToString());
                    request.RemoveAt(index);
                }
                RightButtonRequest_Click(this, new EventArgs());
            }
        }

        protected void LeftButtonRequest_Click(object sender, EventArgs e)
        {
            if (index > 0)
                index--;
            else
                index = request.Count - 1;
            RequestUpdate();
        }

        protected void RightButtonRequest_Click(object sender, EventArgs e)
        {
            if (index < request.Count - 1)
                index++;
            else
                index = 0;
            RequestUpdate();
        }

        protected void SendRequestButton_Click(object sender, EventArgs e)
        {
            SendData();
        }
    }
}
