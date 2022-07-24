using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace debitiNBE
{
    public partial class TransizioneAccettata : UserControl
    {
         public int ID_request = -1;

        public TransizioneAccettata(int _ID_request,bool isCredit = false)
        {
            InitializeComponent();

            ID_request = _ID_request;

            if (isCredit)
                SaldaButton.Hide();

        }
        private void Debito_Load(object sender, EventArgs e)
        {

        }

        private void SaldaButton_Click(object sender, EventArgs e)
        {
            SaldaForm sf = new SaldaForm(this) { StartPosition = FormStartPosition.CenterParent};
            sf.ShowDialog();
            UserForm.Singleton.GeneralUpdate();
        }

        
    }
}
