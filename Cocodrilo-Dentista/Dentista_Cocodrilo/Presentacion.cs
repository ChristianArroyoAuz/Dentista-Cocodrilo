// ******************************************************************************************
// Arroyo Auz Christian Xavier.                                                             *
// 11/08/2016.                                                                              *
// ******************************************************************************************


using System.Collections.Generic;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data;
using System;

namespace Dentista_Cocodrilo
{
    public partial class Presentacion : Form
    {
        public Presentacion()
        {
            //Inicializando la aplicación
            InitializeComponent();
        }

        private void Presentacion_Load(object sender, EventArgs e)
        {
            //Habilitando el timer del formulario y agregando el intervalo con el cual va a contar
            //Posteriormente se inicia el contador del formulario
            contador.Enabled = true;
            contador.Interval = 1000;
            contador.Start();
        }

        private void contador_Tick(object sender, EventArgs e)
        {
            //Intervalo de progreso de la barra de progreso
            barraProgreso.Increment(25);
            //Cambio de la imagen del formulario cuando la barra de progreso llega a 50%
            if (barraProgreso.Value == 50)
            {
                //Poniendo la imagen de fondo en el picturbox despues de que la barra de progreso llega al 50%
                imagenPresentacion.BackgroundImage = Dentista_Cocodrilo.Properties.Resources.Cocodrilo_Presentacion_1;
            }

            if (barraProgreso.Value == 100)
            {
                //Deteniendo el contador al llegar al 100%
                contador.Stop();
                //Inicializamos el proximo formulario y cerramos el formulario actual
                Inicio cambio = new Inicio();
                Hide();
                cambio.ShowDialog();
            }
        }
    }
}