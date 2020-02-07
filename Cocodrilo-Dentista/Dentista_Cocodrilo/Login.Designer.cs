namespace Dentista_Cocodrilo
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.etiquetaRegistro = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.etiquetaPassword = new System.Windows.Forms.Label();
            this.etiquetaUser = new System.Windows.Forms.Label();
            this.botonVolver = new System.Windows.Forms.Button();
            this.botonInformacion = new System.Windows.Forms.Button();
            this.pictureBox_Cocodrilo = new System.Windows.Forms.PictureBox();
            this.botonLogin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Cocodrilo)).BeginInit();
            this.SuspendLayout();
            // 
            // etiquetaRegistro
            // 
            this.etiquetaRegistro.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.etiquetaRegistro.AutoSize = true;
            this.etiquetaRegistro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.etiquetaRegistro.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiquetaRegistro.ForeColor = System.Drawing.Color.Red;
            this.etiquetaRegistro.Location = new System.Drawing.Point(216, 487);
            this.etiquetaRegistro.Name = "etiquetaRegistro";
            this.etiquetaRegistro.Size = new System.Drawing.Size(383, 19);
            this.etiquetaRegistro.TabIndex = 3;
            this.etiquetaRegistro.Text = "¿No dispones de una cuenta? Regístrate ahora.";
            this.etiquetaRegistro.Click += new System.EventHandler(this.etiquetaRegistro_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtPassword.Font = new System.Drawing.Font("Cooper Black", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(317, 380);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(282, 41);
            this.txtPassword.TabIndex = 1;
            // 
            // txtUser
            // 
            this.txtUser.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtUser.Font = new System.Drawing.Font("Cooper Black", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(317, 324);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(282, 41);
            this.txtUser.TabIndex = 0;
            // 
            // etiquetaPassword
            // 
            this.etiquetaPassword.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.etiquetaPassword.AutoSize = true;
            this.etiquetaPassword.Font = new System.Drawing.Font("Cooper Black", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiquetaPassword.Location = new System.Drawing.Point(106, 387);
            this.etiquetaPassword.Name = "etiquetaPassword";
            this.etiquetaPassword.Size = new System.Drawing.Size(205, 34);
            this.etiquetaPassword.TabIndex = 7;
            this.etiquetaPassword.Text = "PASSWORD:";
            // 
            // etiquetaUser
            // 
            this.etiquetaUser.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.etiquetaUser.AutoSize = true;
            this.etiquetaUser.Font = new System.Drawing.Font("Cooper Black", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiquetaUser.Location = new System.Drawing.Point(201, 331);
            this.etiquetaUser.Name = "etiquetaUser";
            this.etiquetaUser.Size = new System.Drawing.Size(110, 34);
            this.etiquetaUser.TabIndex = 6;
            this.etiquetaUser.Text = "USER:";
            // 
            // botonVolver
            // 
            this.botonVolver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.botonVolver.BackColor = System.Drawing.Color.DarkOrange;
            this.botonVolver.BackgroundImage = global::Dentista_Cocodrilo.Properties.Resources.Salir;
            this.botonVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botonVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonVolver.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.botonVolver.FlatAppearance.BorderSize = 0;
            this.botonVolver.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.botonVolver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.botonVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonVolver.Location = new System.Drawing.Point(659, 487);
            this.botonVolver.Name = "botonVolver";
            this.botonVolver.Size = new System.Drawing.Size(53, 51);
            this.botonVolver.TabIndex = 5;
            this.botonVolver.UseVisualStyleBackColor = false;
            this.botonVolver.Click += new System.EventHandler(this.botonVolver_Click);
            // 
            // botonInformacion
            // 
            this.botonInformacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.botonInformacion.BackColor = System.Drawing.Color.DarkOrange;
            this.botonInformacion.BackgroundImage = global::Dentista_Cocodrilo.Properties.Resources.Informacion;
            this.botonInformacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botonInformacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonInformacion.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.botonInformacion.FlatAppearance.BorderSize = 0;
            this.botonInformacion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.botonInformacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.botonInformacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonInformacion.Location = new System.Drawing.Point(12, 487);
            this.botonInformacion.Name = "botonInformacion";
            this.botonInformacion.Size = new System.Drawing.Size(53, 51);
            this.botonInformacion.TabIndex = 4;
            this.botonInformacion.UseVisualStyleBackColor = false;
            this.botonInformacion.Click += new System.EventHandler(this.botonInformacion_Click);
            // 
            // pictureBox_Cocodrilo
            // 
            this.pictureBox_Cocodrilo.Image = global::Dentista_Cocodrilo.Properties.Resources.Cocodrilo_1;
            this.pictureBox_Cocodrilo.Location = new System.Drawing.Point(12, 24);
            this.pictureBox_Cocodrilo.Name = "pictureBox_Cocodrilo";
            this.pictureBox_Cocodrilo.Size = new System.Drawing.Size(700, 291);
            this.pictureBox_Cocodrilo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Cocodrilo.TabIndex = 0;
            this.pictureBox_Cocodrilo.TabStop = false;
            // 
            // botonLogin
            // 
            this.botonLogin.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.botonLogin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.botonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonLogin.Font = new System.Drawing.Font("Cooper Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonLogin.Location = new System.Drawing.Point(370, 427);
            this.botonLogin.Name = "botonLogin";
            this.botonLogin.Size = new System.Drawing.Size(172, 39);
            this.botonLogin.TabIndex = 2;
            this.botonLogin.Text = "INICIAR SESIÓN";
            this.botonLogin.UseVisualStyleBackColor = false;
            this.botonLogin.Click += new System.EventHandler(this.botonLogin_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(724, 550);
            this.Controls.Add(this.botonLogin);
            this.Controls.Add(this.botonVolver);
            this.Controls.Add(this.botonInformacion);
            this.Controls.Add(this.etiquetaRegistro);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.etiquetaPassword);
            this.Controls.Add(this.etiquetaUser);
            this.Controls.Add(this.pictureBox_Cocodrilo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.TransparencyKey = System.Drawing.Color.Gray;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Cocodrilo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_Cocodrilo;
        private System.Windows.Forms.Button botonInformacion;
        private System.Windows.Forms.Label etiquetaRegistro;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label etiquetaPassword;
        private System.Windows.Forms.Label etiquetaUser;
        private System.Windows.Forms.Button botonVolver;
        private System.Windows.Forms.Button botonLogin;
    }
}