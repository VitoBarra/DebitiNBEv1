using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace debitiNBE
{
    public partial class UserForm : MaterialForm
    {
        static public UserForm Singleton;

        public UserForm()
        {
            InitializeComponent();
            Singleton = this;





            LoginForm LoginForm = new LoginForm() { StartPosition = FormStartPosition.CenterParent };
            this.Hide();
            LoginForm.ShowDialog();
            if (Global.UserData != null)
            {
                LeggedUserTx.Text = Global.UserData.UserName;
                User_ID.Text = Global.UserData.ID_User.ToString();
            }
            this.Show();

        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            GeneralUpdate();
        }

        private void ChangeUserButton_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm { StartPosition = FormStartPosition.CenterParent };
            login.ShowDialog();
            LeggedUserTx.Text = Global.UserData.UserName;
            User_ID.Text = Global.UserData.ID_User.ToString();
            GeneralUpdate();
        }


        private void AggiornaButton_Click(object sender, EventArgs e)
        {
            GeneralUpdate();
        }


        #region Update
        public void GeneralUpdate()
        {
            ReadAcepted();
            RequestField.ReadRequest();
            RequestSaldoField.ReadRequest();
            ActiveUpdate();
        }
        public void ReadAcepted()
        {
            Global.UserData.AcceptedCrediti.Clear();
            Global.UserData.AcceptedDebiti.Clear();

            string jsonAceptedList = Global.HttpEmulator.GetAccepted(Global.UserData.ID_User.ToString());

            if (!string.IsNullOrEmpty(jsonAceptedList))
            {
                List<RequestData> Accepted = JsonConvert.DeserializeObject<List<RequestData>>(jsonAceptedList);

                foreach (RequestData acc in Accepted)
                {
                    if (acc.Importo < 0)
                        Global.UserData.AcceptedCrediti.Add(acc);
                    else if (acc.Importo > 0)
                        Global.UserData.AcceptedDebiti.Add(acc);
                }
            }
        }



        public void ActiveUpdate()
        {
            DebitiAttivi.Controls.Clear();
            CreditiAttivi.Controls.Clear();


            if (Global.UserData.AcceptedCrediti != null)
                foreach (RequestData rd in Global.UserData.AcceptedCrediti)
                {
                    TransizioneAccettata ta = new TransizioneAccettata(rd.ID_Request, true) { BackColor = Color.White };
                    ta.User.Text = rd.User;
                    ta.Importo.Text = (-rd.Importo).ToString();

                    CreditiAttivi.Controls.Add(ta);
                }

            if (Global.UserData.AcceptedDebiti != null)
                foreach (RequestData rd in Global.UserData.AcceptedDebiti)
                {
                    TransizioneAccettata ta = new TransizioneAccettata(rd.ID_Request, false) { BackColor = Color.White };
                    ta.User.Text = rd.User;
                    ta.Importo.Text = rd.Importo.ToString();

                    DebitiAttivi.Controls.Add(ta);

                }
        }
        #endregion

        private void MakeRequestButton_Click(object sender, EventArgs e)
        {
            if (Global.loggedState)
            {
                RequestForm requestForm = new RequestForm { StartPosition = FormStartPosition.CenterParent, };
                requestForm.UserPlaceholder.Text = Global.UserData.UserName;
                requestForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("accedi prima al tuo account");
            }
        }

    }
}
