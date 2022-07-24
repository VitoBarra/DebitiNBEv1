namespace debitiNBE
{
    partial class SaldaForm
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
            this.ConsoleLog = new System.Windows.Forms.RichTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.UserLogged = new MaterialSkin.Controls.MaterialLabel();
            this.ImportoField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.SaldaButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.ClearButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.UserCreditore = new MaterialSkin.Controls.MaterialLabel();
            this.Debit = new MaterialSkin.Controls.MaterialLabel();
            this.GiaRichiestoField = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
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
            // UserLogged
            // 
            this.UserLogged.AutoSize = true;
            this.UserLogged.BackColor = System.Drawing.Color.Transparent;
            this.UserLogged.Depth = 0;
            this.UserLogged.Font = new System.Drawing.Font("Roboto", 11F);
            this.UserLogged.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.UserLogged.Location = new System.Drawing.Point(97, 81);
            this.UserLogged.MouseState = MaterialSkin.MouseState.HOVER;
            this.UserLogged.Name = "UserLogged";
            this.UserLogged.Size = new System.Drawing.Size(119, 19);
            this.UserLogged.TabIndex = 17;
            this.UserLogged.Text = "UserPlaceholder";
            // 
            // ImportoField
            // 
            this.ImportoField.BackColor = System.Drawing.Color.LightGray;
            this.ImportoField.Depth = 0;
            this.ImportoField.Hint = "";
            this.ImportoField.Location = new System.Drawing.Point(25, 237);
            this.ImportoField.MaxLength = 32767;
            this.ImportoField.MouseState = MaterialSkin.MouseState.HOVER;
            this.ImportoField.Name = "ImportoField";
            this.ImportoField.PasswordChar = '\0';
            this.ImportoField.SelectedText = "";
            this.ImportoField.SelectionLength = 0;
            this.ImportoField.SelectionStart = 0;
            this.ImportoField.Size = new System.Drawing.Size(75, 23);
            this.ImportoField.TabIndex = 21;
            this.ImportoField.TabStop = false;
            this.ImportoField.Text = "0";
            this.ImportoField.UseSystemPasswordChar = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(18, 215);
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
            this.materialLabel4.Location = new System.Drawing.Point(10, 128);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(73, 19);
            this.materialLabel4.TabIndex = 23;
            this.materialLabel4.Text = "creditore:";
            // 
            // SaldaButton
            // 
            this.SaldaButton.AutoSize = true;
            this.SaldaButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SaldaButton.Depth = 0;
            this.SaldaButton.Icon = null;
            this.SaldaButton.Location = new System.Drawing.Point(204, 268);
            this.SaldaButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.SaldaButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.SaldaButton.Name = "SaldaButton";
            this.SaldaButton.Primary = false;
            this.SaldaButton.Size = new System.Drawing.Size(64, 36);
            this.SaldaButton.TabIndex = 24;
            this.SaldaButton.Text = "SALDA";
            this.SaldaButton.UseVisualStyleBackColor = true;
            this.SaldaButton.Click += new System.EventHandler(this.SaldaButton_Click);
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
            this.materialLabel5.Location = new System.Drawing.Point(107, 241);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(17, 19);
            this.materialLabel5.TabIndex = 27;
            this.materialLabel5.Text = "€";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(126, 128);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(55, 19);
            this.materialLabel2.TabIndex = 28;
            this.materialLabel2.Text = "debito:";
            // 
            // UserCreditore
            // 
            this.UserCreditore.AutoSize = true;
            this.UserCreditore.BackColor = System.Drawing.Color.Transparent;
            this.UserCreditore.Depth = 0;
            this.UserCreditore.Font = new System.Drawing.Font("Roboto", 11F);
            this.UserCreditore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.UserCreditore.Location = new System.Drawing.Point(25, 158);
            this.UserCreditore.MouseState = MaterialSkin.MouseState.HOVER;
            this.UserCreditore.Name = "UserCreditore";
            this.UserCreditore.Size = new System.Drawing.Size(119, 19);
            this.UserCreditore.TabIndex = 29;
            this.UserCreditore.Text = "UserPlaceholder";
            // 
            // Debit
            // 
            this.Debit.AutoSize = true;
            this.Debit.BackColor = System.Drawing.Color.Transparent;
            this.Debit.Depth = 0;
            this.Debit.Font = new System.Drawing.Font("Roboto", 11F);
            this.Debit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Debit.Location = new System.Drawing.Point(150, 158);
            this.Debit.MouseState = MaterialSkin.MouseState.HOVER;
            this.Debit.Name = "Debit";
            this.Debit.Size = new System.Drawing.Size(36, 19);
            this.Debit.TabIndex = 30;
            this.Debit.Text = "Nan";
            // 
            // GiaRichiestoField
            // 
            this.GiaRichiestoField.AutoSize = true;
            this.GiaRichiestoField.BackColor = System.Drawing.Color.Transparent;
            this.GiaRichiestoField.Depth = 0;
            this.GiaRichiestoField.Font = new System.Drawing.Font("Roboto", 11F);
            this.GiaRichiestoField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.GiaRichiestoField.Location = new System.Drawing.Point(211, 158);
            this.GiaRichiestoField.MouseState = MaterialSkin.MouseState.HOVER;
            this.GiaRichiestoField.Name = "GiaRichiestoField";
            this.GiaRichiestoField.Size = new System.Drawing.Size(36, 19);
            this.GiaRichiestoField.TabIndex = 32;
            this.GiaRichiestoField.Text = "Nan";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(201, 128);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(76, 19);
            this.materialLabel7.TabIndex = 31;
            this.materialLabel7.Text = "Richiesto:";
            // 
            // SaldaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(286, 413);
            this.Controls.Add(this.GiaRichiestoField);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.Debit);
            this.Controls.Add(this.UserCreditore);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.SaldaButton);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.ImportoField);
            this.Controls.Add(this.UserLogged);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.ConsoleLog);
            this.Name = "SaldaForm";
            this.Sizable = false;
            this.Text = "Salda il tuo debito";
            this.Load += new System.EventHandler(this.RequestForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox ConsoleLog;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        public MaterialSkin.Controls.MaterialLabel UserLogged;
        private MaterialSkin.Controls.MaterialSingleLineTextField ImportoField;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialFlatButton SaldaButton;
        private MaterialSkin.Controls.MaterialFlatButton ClearButton;
        public MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        public MaterialSkin.Controls.MaterialLabel UserCreditore;
        public MaterialSkin.Controls.MaterialLabel Debit;
        public MaterialSkin.Controls.MaterialLabel GiaRichiestoField;
        public MaterialSkin.Controls.MaterialLabel materialLabel7;
    }
}

