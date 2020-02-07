namespace Dentista_Cocodrilo
{
    partial class Programador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Programador));
            this.txtInformacion = new System.Windows.Forms.RichTextBox();
            this.etiquetaTitulo = new System.Windows.Forms.Label();
            this.botonVolver = new System.Windows.Forms.Button();
            this.imagenProgramador = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imagenProgramador)).BeginInit();
            this.SuspendLayout();
            // 
            // txtInformacion
            // 
            this.txtInformacion.Location = new System.Drawing.Point(163, 68);
            this.txtInformacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtInformacion.Name = "txtInformacion";
            this.txtInformacion.Size = new System.Drawing.Size(331, 192);
            this.txtInformacion.TabIndex = 1;
            this.txtInformacion.Text = resources.GetString("txtInformacion.Text");
            // 
            // etiquetaTitulo
            // 
            this.etiquetaTitulo.AutoSize = true;
            this.etiquetaTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiquetaTitulo.ForeColor = System.Drawing.Color.Yellow;
            this.etiquetaTitulo.Location = new System.Drawing.Point(16, 11);
            this.etiquetaTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.etiquetaTitulo.Name = "etiquetaTitulo";
            this.etiquetaTitulo.Size = new System.Drawing.Size(619, 52);
            this.etiquetaTitulo.TabIndex = 2;
            this.etiquetaTitulo.Text = "SOBRE EL PROGRAMADOR.";
            // 
            // botonVolver
            // 
            this.botonVolver.BackgroundImage = global::Dentista_Cocodrilo.Properties.Resources.Boton_Volver;
            this.botonVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonVolver.Location = new System.Drawing.Point(129, 290);
            this.botonVolver.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.botonVolver.Name = "botonVolver";
            this.botonVolver.Size = new System.Drawing.Size(251, 63);
            this.botonVolver.TabIndex = 3;
            this.botonVolver.UseVisualStyleBackColor = true;
            this.botonVolver.Click += new System.EventHandler(this.botonVolver_Click);
            // 
            // imagenProgramador
            // 
            this.imagenProgramador.BackgroundImage = global::Dentista_Cocodrilo.Properties.Resources.Yo;
            this.imagenProgramador.Location = new System.Drawing.Point(16, 68);
            this.imagenProgramador.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.imagenProgramador.Name = "imagenProgramador";
            this.imagenProgramador.Size = new System.Drawing.Size(125, 149);
            this.imagenProgramador.TabIndex = 0;
            this.imagenProgramador.TabStop = false;
            // 
            // Programador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(511, 382);
            this.Controls.Add(this.botonVolver);
            this.Controls.Add(this.etiquetaTitulo);
            this.Controls.Add(this.txtInformacion);
            this.Controls.Add(this.imagenProgramador);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Programador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Programador";
            this.Load += new System.EventHandler(this.Programador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imagenProgramador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imagenProgramador;
        private System.Windows.Forms.RichTextBox txtInformacion;
        private System.Windows.Forms.Label etiquetaTitulo;
        private System.Windows.Forms.Button botonVolver;
    }
}