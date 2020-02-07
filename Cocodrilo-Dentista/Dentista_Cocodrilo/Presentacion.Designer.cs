namespace Dentista_Cocodrilo
{
    partial class Presentacion
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Presentacion));
            this.imagenTitulo = new System.Windows.Forms.PictureBox();
            this.imagenPresentacion = new System.Windows.Forms.PictureBox();
            this.barraProgreso = new System.Windows.Forms.ProgressBar();
            this.contador = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.imagenTitulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenPresentacion)).BeginInit();
            this.SuspendLayout();
            // 
            // imagenTitulo
            // 
            this.imagenTitulo.BackColor = System.Drawing.Color.Transparent;
            this.imagenTitulo.BackgroundImage = global::Dentista_Cocodrilo.Properties.Resources.Titulo;
            this.imagenTitulo.Location = new System.Drawing.Point(12, 408);
            this.imagenTitulo.Name = "imagenTitulo";
            this.imagenTitulo.Size = new System.Drawing.Size(400, 118);
            this.imagenTitulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagenTitulo.TabIndex = 1;
            this.imagenTitulo.TabStop = false;
            // 
            // imagenPresentacion
            // 
            this.imagenPresentacion.BackColor = System.Drawing.Color.Transparent;
            this.imagenPresentacion.BackgroundImage = global::Dentista_Cocodrilo.Properties.Resources.Cocodrilo_Presentacion;
            this.imagenPresentacion.Location = new System.Drawing.Point(12, 12);
            this.imagenPresentacion.Name = "imagenPresentacion";
            this.imagenPresentacion.Size = new System.Drawing.Size(400, 400);
            this.imagenPresentacion.TabIndex = 0;
            this.imagenPresentacion.TabStop = false;
            // 
            // barraProgreso
            // 
            this.barraProgreso.Location = new System.Drawing.Point(12, 527);
            this.barraProgreso.Name = "barraProgreso";
            this.barraProgreso.Size = new System.Drawing.Size(400, 45);
            this.barraProgreso.TabIndex = 2;
            // 
            // contador
            // 
            this.contador.Tick += new System.EventHandler(this.contador_Tick);
            // 
            // Presentacion
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(425, 582);
            this.Controls.Add(this.barraProgreso);
            this.Controls.Add(this.imagenTitulo);
            this.Controls.Add(this.imagenPresentacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Presentacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Presentacion";
            this.TransparencyKey = System.Drawing.Color.Gray;
            this.Load += new System.EventHandler(this.Presentacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imagenTitulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenPresentacion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imagenPresentacion;
        private System.Windows.Forms.PictureBox imagenTitulo;
        private System.Windows.Forms.ProgressBar barraProgreso;
        private System.Windows.Forms.Timer contador;
    }
}

