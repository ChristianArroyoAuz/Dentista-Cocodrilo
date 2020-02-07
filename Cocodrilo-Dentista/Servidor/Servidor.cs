// ******************************************************************************************
// Arroyo Auz Christian Xavier.                                                             *
// 11/08/2016.                                                                              *
// ******************************************************************************************


using System.Collections.Generic;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Collections;
using System.Threading;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using System;

namespace Servidor
{
    public partial class Servidor : Form
    {
        //Delegado usado para actualizar el estado de los clientes
        private delegate void actualizarEstadoClientes(string mensjaes);
        //Creacion del servidor
        servidorChat servidorPrincipal;
        IPAddress direccionIP;

        public Servidor()
        {
            //Inicializando el formulario
            InitializeComponent();
        }

        private void Servidor_Load(object sender, EventArgs e)
        {
            //Seteando algunos valores en los controles visuales
            etiquetaTipoEstado.Text = "Conectado.";
            etiquetaTipoEstado.ForeColor = Color.ForestGreen;
            //Agregando la direccion IP con la cual se va a trabajar
            direccionIP = IPAddress.Parse("127.0.0.1");
            //Creando una nueva instancia tipoChatServer
            servidorPrincipal = new servidorChat(direccionIP);
            //Enganchandonos a la clase servidorChat
            servidorChat.cambioEstado += new ServidorTCP_PasoDatos(cabiosServidorPrincipal);
            //Inicio del proceso de escucha y espera por nuevas conexiones
            servidorPrincipal.escuchandoClientes();
            //Mostrando las nuevas conexiones iniciadas en el servidor
            listaClientes.ForeColor = Color.Red;
            listaClientes.Items.Clear();
            listaClientes.Items.Add("Esperando por Clientes...");
        }

        public void cabiosServidorPrincipal(object sender, ServidorTCP e)
        {
            try
            {
                //Realiza una actualizacion en las tablas para saber cuando el servidor se ha desconectado
                this.Invoke(new actualizarEstadoClientes(this.actualizarEstado),
                        new object[] { e.EventoMensaje });
            }
            catch (Exception)
            {
                MessageBox.Show("El servidor se ha desconectado... No puede Enviar mensajes.", "Aviso", MessageBoxButtons.OK);
            }
        }

        private void actualizarEstado(string nuevoMensaje)
        {
            //Actuallizacion de la tabla de mensajes
            listaClientes.Items.Add(nuevoMensaje);
        }

        private void Servidor_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                //Proceso de desconectar el servidor
                etiquetaTipoEstado.Text = "Desconectado";
                etiquetaTipoEstado.ForeColor = Color.Red;
                listaClientes.Items.Clear();
                listaClientes.Items.Add("Servidor se esta Cerrando...");
                Environment.Exit(0);
            }
            catch (Exception)
            {
                //Nada
            }
        }
    }
}