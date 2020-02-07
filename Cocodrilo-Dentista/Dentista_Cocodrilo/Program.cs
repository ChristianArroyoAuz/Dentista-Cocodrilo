// ******************************************************************************************
// Arroyo Auz Christian Xavier.                                                             *
// 11/08/2016.                                                                              *
// ******************************************************************************************


using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;
using System;

namespace Dentista_Cocodrilo
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            //Primer formulario que se ejecuta cuando se lanza la aplicacion
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Login());
            Application.Run(new Presentacion());
        }
    }
}