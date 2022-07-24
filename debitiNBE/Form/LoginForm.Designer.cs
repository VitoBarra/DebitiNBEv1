namespace debitiNBE
{
    partial class LoginForm
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
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.UserTx = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.PasswordTx = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.AccediButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.RegistratiButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(80, 142);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(139, 13);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "non ricordi la tua password?";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(12, 109);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(79, 19);
            this.materialLabel1.TabIndex = 7;
            this.materialLabel1.Text = "Password:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(47, 83);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(44, 19);
            this.materialLabel2.TabIndex = 8;
            this.materialLabel2.Text = "User:";
            // 
            // UserTx
            // 
            this.UserTx.BackColor = System.Drawing.Color.Gainsboro;
            this.UserTx.Depth = 0;
            this.UserTx.Hint = "";
            this.UserTx.Location = new System.Drawing.Point(97, 83);
            this.UserTx.MaxLength = 32767;
            this.UserTx.MouseState = MaterialSkin.MouseState.HOVER;
            this.UserTx.Name = "UserTx";
            this.UserTx.PasswordChar = '\0';
            this.UserTx.SelectedText = "";
            this.UserTx.SelectionLength = 0;
            this.UserTx.SelectionStart = 0;
            this.UserTx.Size = new System.Drawing.Size(137, 23);
            this.UserTx.TabIndex = 9;
            this.UserTx.TabStop = false;
            this.UserTx.UseSystemPasswordChar = false;
            // 
            // PasswordTx
            // 
            this.PasswordTx.BackColor = System.Drawing.Color.Gainsboro;
            this.PasswordTx.Depth = 0;
            this.PasswordTx.Hint = "";
            this.PasswordTx.Location = new System.Drawing.Point(97, 109);
            this.PasswordTx.MaxLength = 32767;
            this.PasswordTx.MouseState = MaterialSkin.MouseState.HOVER;
            this.PasswordTx.Name = "PasswordTx";
            this.PasswordTx.PasswordChar = '\0';
            this.PasswordTx.SelectedText = "";
            this.PasswordTx.SelectionLength = 0;
            this.PasswordTx.SelectionStart = 0;
            this.PasswordTx.Size = new System.Drawing.Size(137, 23);
            this.PasswordTx.TabIndex = 10;
            this.PasswordTx.TabStop = false;
            this.PasswordTx.UseSystemPasswordChar = false;
            // 
            // AccediButton
            // 
            this.AccediButton.AutoSize = true;
            this.AccediButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AccediButton.BackColor = System.Drawing.Color.Gainsboro;
            this.AccediButton.Depth = 0;
            this.AccediButton.Icon = null;
            this.AccediButton.Location = new System.Drawing.Point(165, 161);
            this.AccediButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.AccediButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.AccediButton.Name = "AccediButton";
            this.AccediButton.Primary = false;
            this.AccediButton.Size = new System.Drawing.Size(69, 36);
            this.AccediButton.TabIndex = 11;
            this.AccediButton.Text = "Accedi";
            this.AccediButton.UseVisualStyleBackColor = false;
            this.AccediButton.Click += new System.EventHandler(this.AccediButton_Click);
            // 
            // RegistratiButton
            // 
            this.RegistratiButton.AutoSize = true;
            this.RegistratiButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RegistratiButton.Depth = 0;
            this.RegistratiButton.Icon = null;
            this.RegistratiButton.Location = new System.Drawing.Point(30, 161);
            this.RegistratiButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.RegistratiButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.RegistratiButton.Name = "RegistratiButton";
            this.RegistratiButton.Primary = false;
            this.RegistratiButton.Size = new System.Drawing.Size(97, 36);
            this.RegistratiButton.TabIndex = 12;
            this.RegistratiButton.Text = "Registrati";
            this.RegistratiButton.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(272, 202);
            this.Controls.Add(this.RegistratiButton);
            this.Controls.Add(this.AccediButton);
            this.Controls.Add(this.PasswordTx);
            this.Controls.Add(this.UserTx);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.linkLabel1);
            this.Name = "LoginForm";
            this.Sizable = false;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel linkLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField UserTx;
        private MaterialSkin.Controls.MaterialSingleLineTextField PasswordTx;
        private MaterialSkin.Controls.MaterialFlatButton AccediButton;
        private MaterialSkin.Controls.MaterialFlatButton RegistratiButton;
    }
}