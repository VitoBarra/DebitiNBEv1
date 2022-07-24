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
    public partial class LoginForm : MaterialForm
    {

        public LoginForm()
        {
            InitializeComponent();
        }

        private void AccediButton_Click(object sender, EventArgs e)
        {

            string JsonUserdata = Global.HttpEmulator.GetUserData(UserTx.Text, PasswordTx.Text);
            Global.UserData = JsonConvert.DeserializeObject<UserData>(JsonUserdata);

            if (Global.UserData != null)
            {
                Global.UserData.AcceptedCrediti = new List<RequestData>();
                Global.UserData.AcceptedDebiti = new List<RequestData>();
                Global.loggedState = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("la combinaione di utente e password non corisponde a nessun utente");
            }

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
