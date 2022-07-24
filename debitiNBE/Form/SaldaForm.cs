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

namespace debitiNBE
{
    public partial class SaldaForm : MaterialForm
    {
        readonly TransizioneAccettata debito;

        public SaldaForm(TransizioneAccettata _debito)
        {
            InitializeComponent();
            debito = _debito;
        }



        private void RequestForm_Load(object sender, EventArgs e)
        {
            UserLogged.Text = Global.UserData.UserName;
            UserCreditore.Text = debito.User.Text;
            Debit.Text = debito.Importo.Text;
            GiaRichiestoField.Text = Global.HttpEmulator.GetSaldiRequest(debito.ID_request.ToString());
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






        private void SaldaButton_Click(object sender, EventArgs e)
        {
            Global.HttpEmulator.PostSaldo(debito.ID_request.ToString(), ImportoField.Text);



            if (double.Parse(ImportoField.Text) + double.Parse(GiaRichiestoField.Text) < double.Parse(Debit.Text))
                AddConsoleLineTask(Global.UserData.UserName + " ha mandato una richiesta di saldo parziale a " + UserCreditore.Text + " per " + ImportoField.Text + "€\n");
            else if (double.Parse(ImportoField.Text) + double.Parse(GiaRichiestoField.Text) == double.Parse(Debit.Text))
                AddConsoleLineTask(Global.UserData.UserName + " ha mandato una richiesta di saldo completo a " + UserCreditore.Text + " per " + ImportoField.Text + "€\n");
            else
                AddConsoleLineTask("il tuo importo supera il debito\n");
            GiaRichiestoField.Text = Global.HttpEmulator.GetSaldiRequest(debito.ID_request.ToString());
        }
    }
}
