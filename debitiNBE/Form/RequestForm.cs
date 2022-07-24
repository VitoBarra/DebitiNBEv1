using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

using System.Threading.Tasks;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using MaterialSkin.Controls;
using Newtonsoft.Json;

namespace debitiNBE
{
    public partial class RequestForm : MaterialForm
    {

   
        public RequestForm()
        {
            InitializeComponent();
        }



        private void RequestForm_Load(object sender, EventArgs e)
        {
            string jsonUserList = Global.HttpEmulator.GetUserList();

            if (!string.IsNullOrEmpty(jsonUserList))
            {
                List<UserData> usl = JsonConvert.DeserializeObject<List<UserData>>(jsonUserList);
                foreach (UserData us in usl)
                    if (us.ID_User != Global.UserData.ID_User)
                        debitoriComboBox.Items.Add(us.UserName);

                debitoriComboBox.SelectedIndex = 0;
            }

            CreditoRad_CheckedChanged(this, new EventArgs());
        }




        public void AddConsoleLineTask(string ConsoleLine)
        {
            Task ConsoleThread = new Task(() =>
            {
                this.Invoke(new MethodInvoker(() => ConsoleLog.AppendText(ConsoleLine)));
                this.Invoke(new MethodInvoker(() => ConsoleLog.ScrollToCaret()));
            });

            ConsoleThread.Start();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
           ConsoleLog.Clear();
        }

        private void RequestButton_Click(object sender, EventArgs e)
        {
            bool DoneCheck = Global.HttpEmulator.PostRequest(debitoriComboBox.Text, Global.UserData.ID_User.ToString(), CreditoRad.Checked.ToString(), ImportoTx.Text);

            if(DoneCheck)
                AddConsoleLineTask("\nrichieta effettuata");
            else
                AddConsoleLineTask("\nutente non trovato");

        }

        private void CreditoRad_CheckedChanged(object sender, EventArgs e)
        {
            UpdateConsole();
        }


        private void UpdateConsole()
        {
            ConsoleLog.Clear();
            AddConsoleLineTask(" si sta per richiedere: " + ((CreditoRad.Checked) ?
                debitoriComboBox.Text + " dovra " + ImportoTx.Text + "€ a " + Global.UserData.UserName + "\n" :
                Global.UserData.UserName + " dovra " + ImportoTx.Text + "€ a " + debitoriComboBox.Text + "\n"));
        }

        private void ImportoTx_TextChanged(object sender, EventArgs e)
        {
            UpdateConsole();
        }
    }
}
