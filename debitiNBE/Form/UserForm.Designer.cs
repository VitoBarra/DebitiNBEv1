namespace debitiNBE
{
    partial class UserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.LeggedUserTx = new MaterialSkin.Controls.MaterialLabel();
            this.ChangeUserButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.User_ID = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.DebitiAttivi = new System.Windows.Forms.FlowLayoutPanel();
            this.CenterPanel = new System.Windows.Forms.Panel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.RightPanel = new System.Windows.Forms.Panel();
            this.RequestField = new debitiNBE.Request();
            this.RequestSaldoField = new debitiNBE.RequestSaldo();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.MakeRequestButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.AggiornaButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.CreditiAttivi = new System.Windows.Forms.FlowLayoutPanel();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.CenterPanel.SuspendLayout();
            this.RightPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(12, 76);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(97, 19);
            this.materialLabel1.TabIndex = 3;
            this.materialLabel1.Text = "Logged User:";
            // 
            // LeggedUserTx
            // 
            this.LeggedUserTx.AutoSize = true;
            this.LeggedUserTx.Depth = 0;
            this.LeggedUserTx.Font = new System.Drawing.Font("Roboto", 11F);
            this.LeggedUserTx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LeggedUserTx.Location = new System.Drawing.Point(115, 76);
            this.LeggedUserTx.MouseState = MaterialSkin.MouseState.HOVER;
            this.LeggedUserTx.Name = "LeggedUserTx";
            this.LeggedUserTx.Size = new System.Drawing.Size(122, 19);
            this.LeggedUserTx.TabIndex = 4;
            this.LeggedUserTx.Text = "UserPlaceHolder";
            // 
            // ChangeUserButton
            // 
            this.ChangeUserButton.AutoSize = true;
            this.ChangeUserButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ChangeUserButton.Depth = 0;
            this.ChangeUserButton.Icon = null;
            this.ChangeUserButton.Location = new System.Drawing.Point(397, 70);
            this.ChangeUserButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ChangeUserButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.ChangeUserButton.Name = "ChangeUserButton";
            this.ChangeUserButton.Primary = false;
            this.ChangeUserButton.Size = new System.Drawing.Size(127, 36);
            this.ChangeUserButton.TabIndex = 13;
            this.ChangeUserButton.Text = "cambia utente";
            this.ChangeUserButton.UseVisualStyleBackColor = true;
            this.ChangeUserButton.Click += new System.EventHandler(this.ChangeUserButton_Click);
            // 
            // User_ID
            // 
            this.User_ID.AutoSize = true;
            this.User_ID.Depth = 0;
            this.User_ID.Font = new System.Drawing.Font("Roboto", 11F);
            this.User_ID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.User_ID.Location = new System.Drawing.Point(84, 123);
            this.User_ID.MouseState = MaterialSkin.MouseState.HOVER;
            this.User_ID.Name = "User_ID";
            this.User_ID.Size = new System.Drawing.Size(27, 19);
            this.User_ID.TabIndex = 15;
            this.User_ID.Text = "ID ";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(12, 123);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(66, 19);
            this.materialLabel6.TabIndex = 14;
            this.materialLabel6.Text = "User ID: ";
            // 
            // DebitiAttivi
            // 
            this.DebitiAttivi.AutoScroll = true;
            this.DebitiAttivi.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.DebitiAttivi.Location = new System.Drawing.Point(0, 28);
            this.DebitiAttivi.Name = "DebitiAttivi";
            this.DebitiAttivi.Size = new System.Drawing.Size(270, 235);
            this.DebitiAttivi.TabIndex = 17;
            // 
            // CenterPanel
            // 
            this.CenterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.CenterPanel.Controls.Add(this.materialLabel4);
            this.CenterPanel.Controls.Add(this.DebitiAttivi);
            this.CenterPanel.Location = new System.Drawing.Point(270, 165);
            this.CenterPanel.Name = "CenterPanel";
            this.CenterPanel.Size = new System.Drawing.Size(270, 279);
            this.CenterPanel.TabIndex = 19;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.materialLabel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(6, 4);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(89, 21);
            this.materialLabel4.TabIndex = 8;
            this.materialLabel4.Text = "debiti attivi:";
            // 
            // RightPanel
            // 
            this.RightPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.RightPanel.Controls.Add(this.RequestField);
            this.RightPanel.Controls.Add(this.RequestSaldoField);
            this.RightPanel.Controls.Add(this.materialLabel3);
            this.RightPanel.Controls.Add(this.MakeRequestButton);
            this.RightPanel.Location = new System.Drawing.Point(540, 64);
            this.RightPanel.Name = "RightPanel";
            this.RightPanel.Size = new System.Drawing.Size(200, 380);
            this.RightPanel.TabIndex = 20;
            // 
            // RequestField
            // 
            this.RequestField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.RequestField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RequestField.Location = new System.Drawing.Point(13, 42);
            this.RequestField.Name = "RequestField";
            this.RequestField.Size = new System.Drawing.Size(175, 138);
            this.RequestField.TabIndex = 30;
            // 
            // RequestSaldoField
            // 
            this.RequestSaldoField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.RequestSaldoField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RequestSaldoField.Location = new System.Drawing.Point(13, 186);
            this.RequestSaldoField.Name = "RequestSaldoField";
            this.RequestSaldoField.Size = new System.Drawing.Size(175, 143);
            this.RequestSaldoField.TabIndex = 31;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.materialLabel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(6, 12);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(77, 21);
            this.materialLabel3.TabIndex = 18;
            this.materialLabel3.Text = "Richieste:";
            // 
            // MakeRequestButton
            // 
            this.MakeRequestButton.AutoSize = true;
            this.MakeRequestButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MakeRequestButton.Depth = 0;
            this.MakeRequestButton.Icon = null;
            this.MakeRequestButton.Location = new System.Drawing.Point(44, 335);
            this.MakeRequestButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.MakeRequestButton.Name = "MakeRequestButton";
            this.MakeRequestButton.Primary = true;
            this.MakeRequestButton.Size = new System.Drawing.Size(150, 36);
            this.MakeRequestButton.TabIndex = 24;
            this.MakeRequestButton.Text = "Effetua richiesta";
            this.MakeRequestButton.UseVisualStyleBackColor = true;
            this.MakeRequestButton.Click += new System.EventHandler(this.MakeRequestButton_Click);
            // 
            // AggiornaButton
            // 
            this.AggiornaButton.AutoSize = true;
            this.AggiornaButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AggiornaButton.Depth = 0;
            this.AggiornaButton.Icon = null;
            this.AggiornaButton.Location = new System.Drawing.Point(434, 115);
            this.AggiornaButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.AggiornaButton.Name = "AggiornaButton";
            this.AggiornaButton.Primary = true;
            this.AggiornaButton.Size = new System.Drawing.Size(90, 36);
            this.AggiornaButton.TabIndex = 25;
            this.AggiornaButton.Text = "Aggiorna";
            this.AggiornaButton.UseVisualStyleBackColor = true;
            this.AggiornaButton.Click += new System.EventHandler(this.AggiornaButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.panel1.Controls.Add(this.materialLabel2);
            this.panel1.Controls.Add(this.CreditiAttivi);
            this.panel1.Location = new System.Drawing.Point(0, 165);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 279);
            this.panel1.TabIndex = 20;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.materialLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(6, 4);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(96, 21);
            this.materialLabel2.TabIndex = 8;
            this.materialLabel2.Text = "Crediti attivi:";
            // 
            // CreditiAttivi
            // 
            this.CreditiAttivi.AutoScroll = true;
            this.CreditiAttivi.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.CreditiAttivi.Location = new System.Drawing.Point(0, 28);
            this.CreditiAttivi.Name = "CreditiAttivi";
            this.CreditiAttivi.Size = new System.Drawing.Size(270, 235);
            this.CreditiAttivi.TabIndex = 17;
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Icon = null;
            this.materialFlatButton1.Location = new System.Drawing.Point(269, 115);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(151, 36);
            this.materialFlatButton1.TabIndex = 21;
            this.materialFlatButton1.Text = "Cronologia debiti";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            // 
            // UserForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(740, 444);
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.RightPanel);
            this.Controls.Add(this.CenterPanel);
            this.Controls.Add(this.User_ID);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.ChangeUserButton);
            this.Controls.Add(this.AggiornaButton);
            this.Controls.Add(this.LeggedUserTx);
            this.Controls.Add(this.materialLabel1);
            this.Name = "UserForm";
            this.Sizable = false;
            this.Text = "UserForm";
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.CenterPanel.ResumeLayout(false);
            this.CenterPanel.PerformLayout();
            this.RightPanel.ResumeLayout(false);
            this.RightPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        public MaterialSkin.Controls.MaterialLabel LeggedUserTx;
        private MaterialSkin.Controls.MaterialFlatButton ChangeUserButton;
        public MaterialSkin.Controls.MaterialLabel User_ID;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        public System.Windows.Forms.FlowLayoutPanel DebitiAttivi;
        private System.Windows.Forms.Panel CenterPanel;
        private System.Windows.Forms.Panel RightPanel;
        private MaterialSkin.Controls.MaterialRaisedButton MakeRequestButton;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        public System.Windows.Forms.FlowLayoutPanel CreditiAttivi;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private MaterialSkin.Controls.MaterialRaisedButton AggiornaButton;
        private RequestSaldo RequestSaldoField;
        private Request RequestField;
    }
}