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
using Servidor;
using System;

namespace Dentista_Cocodrilo
{
    public partial class Login : Form
    {
        //Instanciando el metodo de consultas en el servidor
        Consultas nuevaConsulta = new Consultas();

        public Login()
        {
            //Inicializamos el formulario
            InitializeComponent();
        }

        private void botonLogin_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == "" || txtUser.Text == "")
            {
                MessageBox.Show("Debe LLenar Todos Los Espacios.", "Advertencia.");
                txtUser.Focus();
            }
            else
            {
                //Pasando al servdor los parametros de busqueda: Login y Contraseña
                nuevaConsulta.usuario = txtUser.Text;
                nuevaConsulta.contraseña = txtPassword.Text;
                //Limpiando la lista recivida para que se actualize de haber habido cambios en la base de datos
                nuevaConsulta.mostrarLista.Clear();
                //Obteniedo la lista desde el servidor
                nuevaConsulta.consultaDatos(nuevaConsulta.mostrarLista);
                //Si la lista recibida posee datos procedera a la validacion del cliente
                if (nuevaConsulta.mostrarLista.Count > 0)
                {
                    //Funcionalidad de haer errores no previstos en la ejecucion del logueo del cliente
                    try
                    {
                        //recorriendo la lista recibida para verificar la existencia del usuario
                        foreach (Servidor.Base_de_Datos.Usuarios item in nuevaConsulta.mostrarLista)
                        {
                            //Si el login y la contraseña coinciden con los datos de la tabla permitira el logueo
                            if (item.LoginUser == txtUser.Text && item.Contraseña == txtPassword.Text)
                            {
                                //Cambiamos de formulario al formulario Cocodrilo
                                Cocodrilo cambio = new Cocodrilo();
                                Hide();
                                cambio.nombreUsuario = item.LoginUser;
                                //Verificando el tipo de usuario para la administracion en el formulario Cocodrilo
                                if (item.LoginUser == "Admin")
                                {
                                    cambio.tipoUsuario = "login_administrador";
                                }
                                else
                                {
                                    cambio.tipoUsuario = "login_user";
                                }
                                cambio.ShowDialog();
                            }
                        }
                    }
                    catch
                    {
                        //Mesaje de error si existe alguna excepcion
                        MessageBox.Show("Ha ocurrido un error en la ejecucion...", "Advertencia");
                    }
                }
                else
                {
                    //Mensaje de error si no existe el cliente en la base de datos
                    MessageBox.Show("El Usuario no Existe o Datos Incorrectos", "Advertencia");
                }
            }
        }

        private void botonInformacion_Click(object sender, EventArgs e)
        {
            //Mensaje de informacion al cliente sobre la aplicacion
            MessageBox.Show("Dentista Cocodrilo." + "\n" +
                            "Juego del conocido juego de mesa Cocodrilo Dentista." + "\n" +
                            "Si te atreves a jugar solo tienes que registrarte o logearte." + "\n" +
                            "Gracias." + "\n" +
                            "Desarrollado por: Arroyo Christian," + "\n" +
                            "                               EPN - 2016.", "Información");
        }

        private void etiquetaRegistro_Click(object sender, EventArgs e)
        {
            //Cambiamos de formualario al formulario de registro de usuarios
            //Y ocultamos el formulario actual
            Registro cambio = new Registro();
            //Pasamos el dato para saber que hubo cambio de formulario desde el Login al registro
            cambio.de_login_registro = "login_registro";
            Hide();
            cambio.Show();
        }

        private void botonVolver_Click(object sender, EventArgs e)
        {
            //Cambiamos de formualario al formulario de inicio
            //Y ocultamos el formulario actual
            Inicio cambio = new Inicio();
            Hide();
            cambio.Show();
        }
    }
}