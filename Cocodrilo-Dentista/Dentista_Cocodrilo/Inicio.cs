// ******************************************************************************************
// Arroyo Auz Christian Xavier.                                                             *
// 11/08/2016.                                                                              *
// ******************************************************************************************


using System.Collections.Generic;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System;

namespace Dentista_Cocodrilo
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            //Inicializa el formulario y sus componentes
            InitializeComponent();
        }

        private void botonJugar_Click(object sender, EventArgs e)
        {
            //Cambiamos de formualario al formulario de Login
            //Y ocultamos el formulario actual
            Login cambio = new Login();
            Hide();
            cambio.Show();
        }

        private void botonInstrucciones_Click(object sender, EventArgs e)
        {
            //Cambiamos de formualario al formulario de instrucciones
            //Y ocultamos el formulario actual
            Instrucciones cambio = new Instrucciones();
            Hide();
            cambio.Show();
        }

        private void botonProgramador_Click(object sender, EventArgs e)
        {
            //Cambiamos de formualario al formulario de presentación del programador
            //Y ocultamos el formulario actual
            Programador cambio = new Programador();
            Hide();
            cambio.Show();
        }

        private void botonSalir_Click(object sender, EventArgs e)
        {
            //Cerramos el formulario y toda la aplicación
            try
            {
                //Cuadro de dialogo que p si quiere cerrar la aplicación
                //Si la respuesta es afirmativa cierra la aplicación
                //Si la respuesta en negativa retornara a la pantalla principal del formulario
                DialogResult salir = MessageBox.Show("Seguro desea Salir?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (salir == DialogResult.OK)
                {
                    Application.Exit();
                }
                else
                {
                    return;
                }
            }
            catch (Exception)
            {
                //Cerrando la aplicación de exixtir algun error
                System.Environment.Exit(0);
            }
        }
    }
}