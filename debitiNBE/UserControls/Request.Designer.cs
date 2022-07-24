namespace debitiNBE
{
    partial class Request
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

        #region Codice generato da Progettazione componenti

        /// <summary> 
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare 
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.UserRequest = new MaterialSkin.Controls.MaterialLabel();
            this.ImportoRichiesto = new MaterialSkin.Controls.MaterialLabel();
            this.AccettaRad = new MaterialSkin.Controls.MaterialRadioButton();
            this.DeclinaRad = new MaterialSkin.Controls.MaterialRadioButton();
            this.Type = new MaterialSkin.Controls.MaterialLabel();
            this.LeftButtonRequest = new MaterialSkin.Controls.MaterialRaisedButton();
            this.RightButtonRequest = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SendRequestButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserRequest
            // 
            this.UserRequest.AutoSize = true;
            this.UserRequest.Depth = 0;
            this.UserRequest.Font = new System.Drawing.Font("Roboto", 11F);
            this.UserRequest.ForeColor = System.Drawing.Color.White;
            this.UserRequest.Location = new System.Drawing.Point(3, 22);
            this.UserRequest.MouseState = MaterialSkin.MouseState.HOVER;
            this.UserRequest.Name = "UserRequest";
            this.UserRequest.Size = new System.Drawing.Size(134, 19);
            this.UserRequest.TabIndex = 3;
            this.UserRequest.Text = "Nessuna Richiesta";
            // 
            // ImportoRichiesto
            // 
            this.ImportoRichiesto.AutoSize = true;
            this.ImportoRichiesto.Depth = 0;
            this.ImportoRichiesto.Font = new System.Drawing.Font("Roboto", 11F);
            this.ImportoRichiesto.ForeColor = System.Drawing.Color.White;
            this.ImportoRichiesto.Location = new System.Drawing.Point(131, 22);
            this.ImportoRichiesto.MouseState = MaterialSkin.MouseState.HOVER;
            this.ImportoRichiesto.Name = "ImportoRichiesto";
            this.ImportoRichiesto.Size = new System.Drawing.Size(39, 19);
            this.ImportoRichiesto.TabIndex = 5;
            this.ImportoRichiesto.Text = "NaN";
            // 
            // AccettaRad
            // 
            this.AccettaRad.AutoSize = true;
            this.AccettaRad.Depth = 0;
            this.AccettaRad.Font = new System.Drawing.Font("Roboto", 10F);
            this.AccettaRad.ForeColor = System.Drawing.Color.White;
            this.AccettaRad.Location = new System.Drawing.Point(4, 41);
            this.AccettaRad.Margin = new System.Windows.Forms.Padding(0);
            this.AccettaRad.MouseLocation = new System.Drawing.Point(-1, -1);
            this.AccettaRad.MouseState = MaterialSkin.MouseState.HOVER;
            this.AccettaRad.Name = "AccettaRad";
            this.AccettaRad.Ripple = true;
            this.AccettaRad.Size = new System.Drawing.Size(76, 30);
            this.AccettaRad.TabIndex = 1;
            this.AccettaRad.Text = "Accetta";
            this.AccettaRad.UseVisualStyleBackColor = true;
            // 
            // DeclinaRad
            // 
            this.DeclinaRad.AutoSize = true;
            this.DeclinaRad.Checked = true;
            this.DeclinaRad.Depth = 0;
            this.DeclinaRad.Font = new System.Drawing.Font("Roboto", 10F);
            this.DeclinaRad.ForeColor = System.Drawing.Color.White;
            this.DeclinaRad.Location = new System.Drawing.Point(93, 41);
            this.DeclinaRad.Margin = new System.Windows.Forms.Padding(0);
            this.DeclinaRad.MouseLocation = new System.Drawing.Point(-1, -1);
            this.DeclinaRad.MouseState = MaterialSkin.MouseState.HOVER;
            this.DeclinaRad.Name = "DeclinaRad";
            this.DeclinaRad.Ripple = true;
            this.DeclinaRad.Size = new System.Drawing.Size(75, 30);
            this.DeclinaRad.TabIndex = 2;
            this.DeclinaRad.TabStop = true;
            this.DeclinaRad.Text = "Declina";
            this.DeclinaRad.UseVisualStyleBackColor = true;
            // 
            // Type
            // 
            this.Type.AutoSize = true;
            this.Type.Depth = 0;
            this.Type.Font = new System.Drawing.Font("Roboto", 11F);
            this.Type.ForeColor = System.Drawing.Color.White;
            this.Type.Location = new System.Drawing.Point(21, 3);
            this.Type.MouseState = MaterialSkin.MouseState.HOVER;
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(37, 19);
            this.Type.TabIndex = 6;
            this.Type.Text = "type";
            // 
            // LeftButtonRequest
            // 
            this.LeftButtonRequest.AutoSize = true;
            this.LeftButtonRequest.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LeftButtonRequest.Depth = 0;
            this.LeftButtonRequest.Icon = null;
            this.LeftButtonRequest.Location = new System.Drawing.Point(7, 13);
            this.LeftButtonRequest.MouseState = MaterialSkin.MouseState.HOVER;
            this.LeftButtonRequest.Name = "LeftButtonRequest";
            this.LeftButtonRequest.Primary = true;
            this.LeftButtonRequest.Size = new System.Drawing.Size(28, 36);
            this.LeftButtonRequest.TabIndex = 24;
            this.LeftButtonRequest.Text = "<";
            this.LeftButtonRequest.UseVisualStyleBackColor = true;
            this.LeftButtonRequest.Click += new System.EventHandler(this.LeftButtonRequest_Click);
            // 
            // RightButtonRequest
            // 
            this.RightButtonRequest.AutoSize = true;
            this.RightButtonRequest.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RightButtonRequest.Depth = 0;
            this.RightButtonRequest.Icon = null;
            this.RightButtonRequest.Location = new System.Drawing.Point(41, 13);
            this.RightButtonRequest.MouseState = MaterialSkin.MouseState.HOVER;
            this.RightButtonRequest.Name = "RightButtonRequest";
            this.RightButtonRequest.Primary = true;
            this.RightButtonRequest.Size = new System.Drawing.Size(28, 36);
            this.RightButtonRequest.TabIndex = 25;
            this.RightButtonRequest.Text = ">";
            this.RightButtonRequest.UseVisualStyleBackColor = true;
            this.RightButtonRequest.Click += new System.EventHandler(this.RightButtonRequest_Click);
            // 
            // SendRequestButton
            // 
            this.SendRequestButton.AutoSize = true;
            this.SendRequestButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SendRequestButton.Depth = 0;
            this.SendRequestButton.Icon = null;
            this.SendRequestButton.Location = new System.Drawing.Point(108, 13);
            this.SendRequestButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.SendRequestButton.Name = "SendRequestButton";
            this.SendRequestButton.Primary = true;
            this.SendRequestButton.Size = new System.Drawing.Size(56, 36);
            this.SendRequestButton.TabIndex = 26;
            this.SendRequestButton.Text = "Send";
            this.SendRequestButton.UseVisualStyleBackColor = true;
            this.SendRequestButton.Click += new System.EventHandler(this.SendRequestButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.panel1.Controls.Add(this.LeftButtonRequest);
            this.panel1.Controls.Add(this.SendRequestButton);
            this.panel1.Controls.Add(this.RightButtonRequest);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.ForeColor = System.Drawing.SystemColors.Control;
            this.panel1.Location = new System.Drawing.Point(0, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(177, 62);
            this.panel1.TabIndex = 27;
            // 
            // Request
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Type);
            this.Controls.Add(this.ImportoRichiesto);
            this.Controls.Add(this.UserRequest);
            this.Controls.Add(this.DeclinaRad);
            this.Controls.Add(this.AccettaRad);
            this.Name = "Request";
            this.Size = new System.Drawing.Size(177, 147);
            this.Load += new System.EventHandler(this.Request_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public MaterialSkin.Controls.MaterialLabel UserRequest;
        public MaterialSkin.Controls.MaterialLabel ImportoRichiesto;
        public MaterialSkin.Controls.MaterialRadioButton AccettaRad;
        public MaterialSkin.Controls.MaterialRadioButton DeclinaRad;
        public MaterialSkin.Controls.MaterialLabel Type;
        private MaterialSkin.Controls.MaterialRaisedButton LeftButtonRequest;
        private MaterialSkin.Controls.MaterialRaisedButton RightButtonRequest;
        private MaterialSkin.Controls.MaterialRaisedButton SendRequestButton;
        private System.Windows.Forms.Panel panel1;
    }
}
