namespace Servidor
{
    partial class Servidor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Servidor));
            this.listaClientes = new System.Windows.Forms.ListBox();
            this.etiquetaTipoEstado = new System.Windows.Forms.Label();
            this.etiquetaEstado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listaClientes
            // 
            this.listaClientes.FormattingEnabled = true;
            this.listaClientes.Location = new System.Drawing.Point(12, 34);
            this.listaClientes.Name = "listaClientes";
            this.listaClientes.ScrollAlwaysVisible = true;
            this.listaClientes.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listaClientes.Size = new System.Drawing.Size(326, 121);
            this.listaClientes.TabIndex = 10;
            // 
            // etiquetaTipoEstado
            // 
            this.etiquetaTipoEstado.AutoSize = true;
            this.etiquetaTipoEstado.Font = new System.Drawing.Font("Dutch801 Rm BT", 15.75F);
            this.etiquetaTipoEstado.Location = new System.Drawing.Point(98, 6);
            this.etiquetaTipoEstado.Name = "etiquetaTipoEstado";
            this.etiquetaTipoEstado.Size = new System.Drawing.Size(239, 25);
            this.etiquetaTipoEstado.TabIndex = 9;
            this.etiquetaTipoEstado.Text = "Conectado/Desconectado";
            // 
            // etiquetaEstado
            // 
            this.etiquetaEstado.AutoSize = true;
            this.etiquetaEstado.Font = new System.Drawing.Font("Dutch801 Rm BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiquetaEstado.Location = new System.Drawing.Point(12, 6);
            this.etiquetaEstado.Name = "etiquetaEstado";
            this.etiquetaEstado.Size = new System.Drawing.Size(80, 25);
            this.etiquetaEstado.TabIndex = 8;
            this.etiquetaEstado.Text = "Estado:";
            // 
            // Servidor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(350, 168);
            this.Controls.Add(this.listaClientes);
            this.Controls.Add(this.etiquetaTipoEstado);
            this.Controls.Add(this.etiquetaEstado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Servidor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Servidor";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Servidor_FormClosing);
            this.Load += new System.EventHandler(this.Servidor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listaClientes;
        private System.Windows.Forms.Label etiquetaTipoEstado;
        private System.Windows.Forms.Label etiquetaEstado;
    }
}

