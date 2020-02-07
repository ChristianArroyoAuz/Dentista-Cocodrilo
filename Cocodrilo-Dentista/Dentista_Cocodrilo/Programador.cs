// ******************************************************************************************
// Arroyo Auz Christian Xavier.                                                             *
// 11/08/2016.                                                                              *
// ******************************************************************************************


using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System;

namespace Dentista_Cocodrilo
{
    public partial class Programador : Form
    {
        public Programador()
        {
            //Inicializando el formulario de la presentación
            InitializeComponent();
        }

        private void Programador_Load(object sender, EventArgs e)
        {
            //Deshabilitamos el richtextbox para que no se ueda ingresar datos
            //La información presente en el richtextbox se la cargo de manera visual en la sección
            // de texto.
            txtInformacion.Enabled = false;
        }

        private void botonVolver_Click(object sender, EventArgs e)
        {
            //Realizamos el cambio de formulario, para poder volver al formulario principal de opciones
            //Ocultamos el formulario actual
            Inicio cambio = new Inicio();
            Hide();
            cambio.Show();
        }
    }
}