namespace Dentista_Cocodrilo
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.botonSalir = new System.Windows.Forms.Button();
            this.botonProgramador = new System.Windows.Forms.Button();
            this.botonInstrucciones = new System.Windows.Forms.Button();
            this.botonJugar = new System.Windows.Forms.Button();
            this.imagenInicio = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imagenInicio)).BeginInit();
            this.SuspendLayout();
            // 
            // botonSalir
            // 
            this.botonSalir.BackgroundImage = global::Dentista_Cocodrilo.Properties.Resources.Boton_Salir;
            this.botonSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonSalir.Location = new System.Drawing.Point(418, 376);
            this.botonSalir.Name = "botonSalir";
            this.botonSalir.Size = new System.Drawing.Size(163, 36);
            this.botonSalir.TabIndex = 4;
            this.botonSalir.UseVisualStyleBackColor = true;
            this.botonSalir.Click += new System.EventHandler(this.botonSalir_Click);
            // 
            // botonProgramador
            // 
            this.botonProgramador.BackgroundImage = global::Dentista_Cocodrilo.Properties.Resources.Boton_Programador;
            this.botonProgramador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonProgramador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonProgramador.Location = new System.Drawing.Point(418, 261);
            this.botonProgramador.Name = "botonProgramador";
            this.botonProgramador.Size = new System.Drawing.Size(163, 37);
            this.botonProgramador.TabIndex = 3;
            this.botonProgramador.UseVisualStyleBackColor = true;
            this.botonProgramador.Click += new System.EventHandler(this.botonProgramador_Click);
            // 
            // botonInstrucciones
            // 
            this.botonInstrucciones.BackgroundImage = global::Dentista_Cocodrilo.Properties.Resources.Boton_Instrucciones;
            this.botonInstrucciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonInstrucciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonInstrucciones.Location = new System.Drawing.Point(418, 142);
            this.botonInstrucciones.Name = "botonInstrucciones";
            this.botonInstrucciones.Size = new System.Drawing.Size(163, 37);
            this.botonInstrucciones.TabIndex = 2;
            this.botonInstrucciones.UseVisualStyleBackColor = true;
            this.botonInstrucciones.Click += new System.EventHandler(this.botonInstrucciones_Click);
            // 
            // botonJugar
            // 
            this.botonJugar.BackgroundImage = global::Dentista_Cocodrilo.Properties.Resources.Boton_Jugar;
            this.botonJugar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonJugar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonJugar.Location = new System.Drawing.Point(418, 12);
            this.botonJugar.Name = "botonJugar";
            this.botonJugar.Size = new System.Drawing.Size(163, 37);
            this.botonJugar.TabIndex = 1;
            this.botonJugar.UseVisualStyleBackColor = true;
            this.botonJugar.Click += new System.EventHandler(this.botonJugar_Click);
            // 
            // imagenInicio
            // 
            this.imagenInicio.BackColor = System.Drawing.Color.Transparent;
            this.imagenInicio.BackgroundImage = global::Dentista_Cocodrilo.Properties.Resources.Cocodrilo_Inicio;
            this.imagenInicio.Location = new System.Drawing.Point(12, 12);
            this.imagenInicio.Name = "imagenInicio";
            this.imagenInicio.Size = new System.Drawing.Size(400, 400);
            this.imagenInicio.TabIndex = 0;
            this.imagenInicio.TabStop = false;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(600, 428);
            this.Controls.Add(this.botonSalir);
            this.Controls.Add(this.botonProgramador);
            this.Controls.Add(this.botonInstrucciones);
            this.Controls.Add(this.botonJugar);
            this.Controls.Add(this.imagenInicio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            ((System.ComponentModel.ISupportInitialize)(this.imagenInicio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imagenInicio;
        private System.Windows.Forms.Button botonJugar;
        private System.Windows.Forms.Button botonInstrucciones;
        private System.Windows.Forms.Button botonProgramador;
        private System.Windows.Forms.Button botonSalir;
    }
}