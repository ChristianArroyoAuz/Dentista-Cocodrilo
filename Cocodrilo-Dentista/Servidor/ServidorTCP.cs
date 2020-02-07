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
    // Creación de un delagado para ayudarnos en el paso de menajes
    public delegate void ServidorTCP_PasoDatos(object sender, ServidorTCP e);

    public class ServidorTCP
    {
        private string eventoMensaje;

        //Me permite Obtener los valores del enevto creado
        public string EventoMensaje
        {
            get
            {
                return eventoMensaje;
            }
            set
            {
                eventoMensaje = value;
            }
        }

        //Crecion de un constructor para pode recibir y enviar los mensajes recibidos de los clientes
        public ServidorTCP(string enviarMensaje)
        {
            eventoMensaje = enviarMensaje;
        }
    }

    class servidorChat
    {
        //Inicializa una tabla de conexiones de usuarios, en este caso se permitira hasta un maximo
        //de 1 usuarios adicional y sus reespectivas conexiones
        //Sera utilizado cuando el cliente desee jugar contra la CPU
        public static Hashtable usuarios = new Hashtable(1);
        public static Hashtable conexiones = new Hashtable(1);
        //Proceso de almacenamiento de las direcciones IP
        public IPAddress direccionesIP;
        public TcpClient clienteTCP;
        private static ServidorTCP clienteDice;
        //Hilo para mantener la conexion entre el cliente y el servidor
        private Thread hiloEscuchaConexion;
        //Inicializacion del cliente TCP
        private TcpListener cliente;
        //Con esto evitamos que en el alzo While creado, se pierda conexion
        //Me permite mantener la conexion aunque no se esten enviando mensajes
        bool mantenerActivo = false;

        //Evento de notificacion cuando un usuario se conecta, desconecta o envia un mensajes
        public static event ServidorTCP_PasoDatos cambioEstado;

        //Seteando la direccion IP
        public servidorChat(IPAddress direcciones)
        {
            direccionesIP = direcciones;
        }

        //Agregando el usuario a las tablas Hash
        public static void agregarCliente(TcpClient usuarioTCP, string nombreUsuario)
        {
            //Agregando el usuario (direccion IP y Nombre) y asociandolo a las tablas hash
            servidorChat.usuarios.Add(nombreUsuario, usuarioTCP);
            servidorChat.conexiones.Add(usuarioTCP, nombreUsuario);
            //Informando a los otros cliente de que un nuevo cliente se ha conectado
            mensajeServidor(conexiones[usuarioTCP] + " Se ha unido al Chat.");
        }

        //Proceso inverso a la adhesion Se procede a retirar a los usuarios de las tablas para que no reciban ningun tipo de mensaje
        public static void removerUsuarios(TcpClient usuarioTCP)
        {
            //Si hay almenos un usuario en tablas
            if (conexiones[usuarioTCP] != null)
            {
                //Primero se informa a los otros usuarios de que el cliente se a desconectado del chat
                mensajeServidor(conexiones[usuarioTCP] + " ha abandonado el Chat.");
                //Finalmente, se remueve al cliente de las talas de conexion y usuarios
                servidorChat.usuarios.Remove(servidorChat.conexiones[usuarioTCP]);
                servidorChat.conexiones.Remove(usuarioTCP);
            }
        }

        //Llamamos este evento cuando queremos cambiar el estado al servidorTCP
        public static void cambiarEstado(ServidorTCP cambiar)
        {
            ServidorTCP_PasoDatos estadoActual = cambioEstado;
            if (estadoActual != null)
            {
                // Invoke the delegate
                estadoActual(null, cambiar);
            }
        }

        //Envio de los mensajes del Servidor a los clientes
        public static void mensajeServidor(string aviso)
        {
            StreamWriter mensaje_del_Servidor;
            clienteDice = new ServidorTCP(aviso);
            cambiarEstado(clienteDice);
            //Se crea un arreglo de clientes para poder mandar el menajes a todos los cliente dentro del arreglo
            TcpClient[] clientesTCP = new TcpClient[servidorChat.usuarios.Count];
            //Ingresando los clientes en el arreglo
            servidorChat.usuarios.Values.CopyTo(clientesTCP, 0);
            //Recorriendo la lista de clientes
            for (int i = 0; i < clientesTCP.Length; i++)
            {
                try
                {
                    //No se permite el envio de mensajes en blanco
                    if (aviso.Trim() == "" || clientesTCP[i] == null)
                    {
                        continue;
                    }
                    //Envio del mensaje a los cliente en el lazo
                    mensaje_del_Servidor = new StreamWriter(clientesTCP[i].GetStream());
                    mensaje_del_Servidor.WriteLine(aviso);
                    mensaje_del_Servidor.Flush();
                    mensaje_del_Servidor = null;
                }
                //Se el cliente no puede enviar mensajes es borrado de las tablas
                catch
                {
                    removerUsuarios(clientesTCP[i]);
                }
            }
        }

        //Envio de un mensaje desde un usuario a todos los usurios conectados
        public static void envio_deMesajes(string remitente, string mensaje)
        {
            StreamWriter mensajeEnviado;
            //Mensaje mostrado en la propia pantalla
            clienteDice = new ServidorTCP(remitente + " dice: " + mensaje);
            cambiarEstado(clienteDice);
            //Creando un arreglo de clientes TCP del tamaño de los clientes conectados
            TcpClient[] clientesTCP = new TcpClient[servidorChat.usuarios.Count];
            //Copiando los clientes a la lista del arreglo
            servidorChat.usuarios.Values.CopyTo(clientesTCP, 0);
            //Recorriendo el arreglo de clienetes
            for (int i = 0; i < clientesTCP.Length; i++)
            {
                //Intentando enviar los mensajes a cada uno de los clientes
                try
                {
                    //No se permite el envio de mensajes en blanco
                    if (mensaje.Trim() == "" || clientesTCP[i] == null)
                    {
                        continue;
                    }
                    mensajeEnviado = new StreamWriter(clientesTCP[i].GetStream());
                    mensajeEnviado.WriteLine(remitente + " dice: " + mensaje);
                    mensajeEnviado.Flush();
                    mensajeEnviado = null;
                }
                catch
                {
                    //Se remueve el usuario de las tablas
                    removerUsuarios(clientesTCP[i]);
                }
            }
        }

        public void escuchandoClientes()
        {
            //Obteniendo la primera direccion IP del primer cliente en conectarse
            IPAddress direccionIP_Cliente = direccionesIP;
            //Creando el objeto TCPListener con la direccion Ip y el Puerto
            cliente = new TcpListener(direccionIP_Cliente, 11000);
            //Empezando la escucha por nuevos clientes
            cliente.Start();
            mantenerActivo = true;
            //Inicio de un nuevo hilo para mantenerse escuchando
            hiloEscuchaConexion = new Thread(mantenerseEscuchando);
            hiloEscuchaConexion.Start();
        }

        private void mantenerseEscuchando()
        {
            //Mientras el servidor este corriendo este tiene que mantenerse escucando por nuevos clientes
            //que deseen conectarse
            while (mantenerActivo == true)
            {
                //Aceptacion de nuevos clientes
                clienteTCP = cliente.AcceptTcpClient();
                Coneccion newConnection = new Coneccion(clienteTCP);
            }
        }
    }

    //Clase que me permite la conexion
    public class Coneccion
    {
        TcpClient clienteTCP;
        //Hilo que nos permitira el envio de emensajes
        private Thread hiloEnvio;
        private StreamReader cadenaRecivida;
        private StreamWriter cadenaEnvio;
        private string usuarioActual;
        private string respuesta;

        //Constructor TCP Client
        public Coneccion(TcpClient conectarClienteTCP)
        {
            clienteTCP = conectarClienteTCP;
            //Union del cliente al hilo creado, que esta en espera de recibir mensajes
            hiloEnvio = new Thread(aceptarCliente);
            //Inicio del hilo
            hiloEnvio.Start();
        }

        public void cerrarConexion()
        {
            //Cierra todas las conexiones
            clienteTCP.Close();
            cadenaRecivida.Close();
            cadenaEnvio.Close();
        }

        public void aceptarCliente()
        {
            cadenaRecivida = new System.IO.StreamReader(clienteTCP.GetStream());
            cadenaEnvio = new System.IO.StreamWriter(clienteTCP.GetStream());
            //Lectura de la informacion del cliente a unirse
            usuarioActual = cadenaRecivida.ReadLine();
            if (usuarioActual != "")
            {
                //Agregandolo a la HashTable de clientes
                if (servidorChat.usuarios.Contains(usuarioActual) == true)
                {
                    // 0 significa no conectado
                    cadenaEnvio.WriteLine("0|Este usuario ya existe");
                    cadenaEnvio.Flush();
                    cerrarConexion();
                    return;
                }
                else
                {
                    if (usuarioActual == "Administrador")
                    {
                        // 0 significa no conectado
                        cadenaEnvio.WriteLine("0|Nombre de usuario reservado");
                        cadenaEnvio.Flush();
                        cerrarConexion();
                        return;
                    }
                    else
                    {
                        // 1 significa conectado
                        cadenaEnvio.WriteLine("1");
                        cadenaEnvio.Flush();
                        //Usuario conectado y por lo tanto es posible agregarlo a la tabla
                        servidorChat.agregarCliente(clienteTCP, usuarioActual);
                    }
                }
            }
            else
            {
                cerrarConexion();
                return;
            }

            try
            {
                //Esperando por mensajes del usuario que no sean cadenas vacias
                while ((respuesta = cadenaRecivida.ReadLine()) != "")
                {
                    if (respuesta == null)
                    {
                        servidorChat.removerUsuarios(clienteTCP);
                    }
                    else
                    {
                        //Envio de los mensajes a todos los usuarios
                        servidorChat.envio_deMesajes(usuarioActual, respuesta);
                    }
                }
            }
            catch
            {
                //El usuario es removido de las tablas de usuarios
                servidorChat.removerUsuarios(clienteTCP);
            }
        }
    }
}