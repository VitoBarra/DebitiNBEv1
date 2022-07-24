namespace debitiNBE
{
    partial class TransizioneAccettata
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
            this.SaldaButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.User = new MaterialSkin.Controls.MaterialLabel();
            this.Importo = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // SaldaButton
            // 
            this.SaldaButton.AutoSize = true;
            this.SaldaButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SaldaButton.Depth = 0;
            this.SaldaButton.Icon = null;
            this.SaldaButton.Location = new System.Drawing.Point(172, 0);
            this.SaldaButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.SaldaButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.SaldaButton.Name = "SaldaButton";
            this.SaldaButton.Primary = false;
            this.SaldaButton.Size = new System.Drawing.Size(64, 36);
            this.SaldaButton.TabIndex = 0;
            this.SaldaButton.Text = "Salda";
            this.SaldaButton.UseVisualStyleBackColor = true;
            this.SaldaButton.Click += new System.EventHandler(this.SaldaButton_Click);
            // 
            // User
            // 
            this.User.AutoSize = true;
            this.User.Depth = 0;
            this.User.Font = new System.Drawing.Font("Roboto", 11F);
            this.User.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.User.Location = new System.Drawing.Point(3, 8);
            this.User.MouseState = MaterialSkin.MouseState.HOVER;
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(51, 19);
            this.User.TabIndex = 1;
            this.User.Text = "debito";
            // 
            // Importo
            // 
            this.Importo.AutoSize = true;
            this.Importo.Depth = 0;
            this.Importo.Font = new System.Drawing.Font("Roboto", 11F);
            this.Importo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Importo.Location = new System.Drawing.Point(126, 8);
            this.Importo.MouseState = MaterialSkin.MouseState.HOVER;
            this.Importo.Name = "Importo";
            this.Importo.Size = new System.Drawing.Size(39, 19);
            this.Importo.TabIndex = 2;
            this.Importo.Text = "NaN";
            // 
            // TransizioneAccettata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Importo);
            this.Controls.Add(this.User);
            this.Controls.Add(this.SaldaButton);
            this.Name = "TransizioneAccettata";
            this.Size = new System.Drawing.Size(240, 36);
            this.Load += new System.EventHandler(this.Debito_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public MaterialSkin.Controls.MaterialFlatButton SaldaButton;
        public MaterialSkin.Controls.MaterialLabel User;
        public MaterialSkin.Controls.MaterialLabel Importo;
    }
}
