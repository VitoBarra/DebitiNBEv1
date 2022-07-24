namespace debitiNBE
{
    partial class RequestForm
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.debitoriComboBox = new System.Windows.Forms.ComboBox();
            this.ConsoleLog = new System.Windows.Forms.RichTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.UserPlaceholder = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.CreditoRad = new MaterialSkin.Controls.MaterialRadioButton();
            this.DebitoRad = new MaterialSkin.Controls.MaterialRadioButton();
            this.ImportoTx = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.RequestButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.ClearButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // debitoriComboBox
            // 
            this.debitoriComboBox.FormattingEnabled = true;
            this.debitoriComboBox.Location = new System.Drawing.Point(121, 240);
            this.debitoriComboBox.Name = "debitoriComboBox";
            this.debitoriComboBox.Size = new System.Drawing.Size(120, 21);
            this.debitoriComboBox.TabIndex = 2;
            // 
            // ConsoleLog
            // 
            this.ConsoleLog.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ConsoleLog.Location = new System.Drawing.Point(0, 317);
            this.ConsoleLog.Name = "ConsoleLog";
            this.ConsoleLog.Size = new System.Drawing.Size(286, 96);
            this.ConsoleLog.TabIndex = 13;
            this.ConsoleLog.Text = "";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(9, 81);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(82, 19);
            this.materialLabel1.TabIndex = 16;
            this.materialLabel1.Text = "Logged as:";
            // 
            // UserPlaceholder
            // 
            this.UserPlaceholder.AutoSize = true;
            this.UserPlaceholder.BackColor = System.Drawing.Color.Transparent;
            this.UserPlaceholder.Depth = 0;
            this.UserPlaceholder.Font = new System.Drawing.Font("Roboto", 11F);
            this.UserPlaceholder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.UserPlaceholder.Location = new System.Drawing.Point(97, 81);
            this.UserPlaceholder.MouseState = MaterialSkin.MouseState.HOVER;
            this.UserPlaceholder.Name = "UserPlaceholder";
            this.UserPlaceholder.Size = new System.Drawing.Size(119, 19);
            this.UserPlaceholder.TabIndex = 17;
            this.UserPlaceholder.Text = "UserPlaceholder";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(12, 120);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(109, 19);
            this.materialLabel2.TabIndex = 18;
            this.materialLabel2.Text = "tipo di richista:";
            // 
            // CreditoRad
            // 
            this.CreditoRad.AutoSize = true;
            this.CreditoRad.BackColor = System.Drawing.Color.Transparent;
            this.CreditoRad.Checked = true;
            this.CreditoRad.Depth = 0;
            this.CreditoRad.Font = new System.Drawing.Font("Roboto", 10F);
            this.CreditoRad.Location = new System.Drawing.Point(16, 143);
            this.CreditoRad.Margin = new System.Windows.Forms.Padding(0);
            this.CreditoRad.MouseLocation = new System.Drawing.Point(-1, -1);
            this.CreditoRad.MouseState = MaterialSkin.MouseState.HOVER;
            this.CreditoRad.Name = "CreditoRad";
            this.CreditoRad.Ripple = true;
            this.CreditoRad.Size = new System.Drawing.Size(87, 30);
            this.CreditoRad.TabIndex = 19;
            this.CreditoRad.TabStop = true;
            this.CreditoRad.Text = "di credito";
            this.CreditoRad.UseVisualStyleBackColor = false;
            this.CreditoRad.CheckedChanged += new System.EventHandler(this.CreditoRad_CheckedChanged);
            // 
            // DebitoRad
            // 
            this.DebitoRad.AutoSize = true;
            this.DebitoRad.BackColor = System.Drawing.Color.Transparent;
            this.DebitoRad.Depth = 0;
            this.DebitoRad.Font = new System.Drawing.Font("Roboto", 10F);
            this.DebitoRad.Location = new System.Drawing.Point(16, 173);
            this.DebitoRad.Margin = new System.Windows.Forms.Padding(0);
            this.DebitoRad.MouseLocation = new System.Drawing.Point(-1, -1);
            this.DebitoRad.MouseState = MaterialSkin.MouseState.HOVER;
            this.DebitoRad.Name = "DebitoRad";
            this.DebitoRad.Ripple = true;
            this.DebitoRad.Size = new System.Drawing.Size(82, 30);
            this.DebitoRad.TabIndex = 20;
            this.DebitoRad.Text = "di debito";
            this.DebitoRad.UseVisualStyleBackColor = false;
            // 
            // ImportoTx
            // 
            this.ImportoTx.BackColor = System.Drawing.Color.LightGray;
            this.ImportoTx.Depth = 0;
            this.ImportoTx.Hint = "";
            this.ImportoTx.Location = new System.Drawing.Point(16, 238);
            this.ImportoTx.MaxLength = 32767;
            this.ImportoTx.MouseState = MaterialSkin.MouseState.HOVER;
            this.ImportoTx.Name = "ImportoTx";
            this.ImportoTx.PasswordChar = '\0';
            this.ImportoTx.SelectedText = "";
            this.ImportoTx.SelectionLength = 0;
            this.ImportoTx.SelectionStart = 0;
            this.ImportoTx.Size = new System.Drawing.Size(75, 23);
            this.ImportoTx.TabIndex = 21;
            this.ImportoTx.TabStop = false;
            this.ImportoTx.Text = "0";
            this.ImportoTx.UseSystemPasswordChar = false;
            this.ImportoTx.TextChanged += new System.EventHandler(this.ImportoTx_TextChanged);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(9, 216);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(66, 19);
            this.materialLabel3.TabIndex = 22;
            this.materialLabel3.Text = "Importo:";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(117, 216);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(70, 19);
            this.materialLabel4.TabIndex = 23;
            this.materialLabel4.Text = "Debitore:";
            // 
            // RequestButton
            // 
            this.RequestButton.AutoSize = true;
            this.RequestButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RequestButton.Depth = 0;
            this.RequestButton.Icon = null;
            this.RequestButton.Location = new System.Drawing.Point(204, 268);
            this.RequestButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.RequestButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.RequestButton.Name = "RequestButton";
            this.RequestButton.Primary = false;
            this.RequestButton.Size = new System.Drawing.Size(77, 36);
            this.RequestButton.TabIndex = 24;
            this.RequestButton.Text = "richiedi";
            this.RequestButton.UseVisualStyleBackColor = true;
            this.RequestButton.Click += new System.EventHandler(this.RequestButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.AutoSize = true;
            this.ClearButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClearButton.Depth = 0;
            this.ClearButton.Icon = null;
            this.ClearButton.Location = new System.Drawing.Point(12, 268);
            this.ClearButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ClearButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Primary = false;
            this.ClearButton.Size = new System.Drawing.Size(127, 36);
            this.ClearButton.TabIndex = 26;
            this.ClearButton.Text = "Clear Console";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(98, 242);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(17, 19);
            this.materialLabel5.TabIndex = 27;
            this.materialLabel5.Text = "€";
            // 
            // RequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(286, 413);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.RequestButton);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.ImportoTx);
            this.Controls.Add(this.DebitoRad);
            this.Controls.Add(this.CreditoRad);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.UserPlaceholder);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.ConsoleLog);
            this.Controls.Add(this.debitoriComboBox);
            this.Name = "RequestForm";
            this.Sizable = false;
            this.Text = "Fai una richiesta";
            this.Load += new System.EventHandler(this.RequestForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox debitoriComboBox;
        private System.Windows.Forms.RichTextBox ConsoleLog;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        public MaterialSkin.Controls.MaterialLabel UserPlaceholder;
        private MaterialSkin.Controls.MaterialRadioButton CreditoRad;
        private MaterialSkin.Controls.MaterialRadioButton DebitoRad;
        private MaterialSkin.Controls.MaterialSingleLineTextField ImportoTx;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialFlatButton RequestButton;
        private MaterialSkin.Controls.MaterialFlatButton ClearButton;
        public MaterialSkin.Controls.MaterialLabel materialLabel5;
    }
}

