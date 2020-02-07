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
using Servidor;
using System;

namespace Dentista_Cocodrilo
{
    public partial class Cocodrilo : Form
    {
        // Variables para el nombre del cliente y para la lectura y envio del mensaje
        //Implementado para escribir y leer los caracteres de una secuencia en una codificación determinada.
        //Finalmente inicializamos una instacia para poder conectarnos a un servidor con una direccion y puerto
        private StreamWriter envioMensaje;
        private StreamReader lecturaMensaje;
        private TcpClient servidorTCP;
        public string nombreUsuario;
        public string tipoUsuario;
        public int peso;
        public int vidasJugador;
        public int vidasCPU;
        public string tipoJuego;
        public string valorDiente;
        public string valorPesoCPU;
        public string valorDienteCPU;
        // Delegado creado para actualizar los mensajes cuando llega el mensaje de otro hilo
        private delegate void actualizacionMensajes(string informacion_1);
        //Variables necesarias para crear el hilo por el cual se enviara el mensajes
        //Inicializamos la direccion IP con la cual se trabajara
        //Variable necesaria para informar a los demas clientes cuando otro cliente se ha conectado o desconectado
        private delegate void actualizacionInformacion(string informacion_2);
        private bool Conectado = false;
        private IPAddress direccionIP;
        private Thread hiloMensaje;
        //Llamando al generador de numeros aleatorios en el servidor
        Generador numeros = new Generador();
        //Lamando a la verificacion de los resultados
        VerificarDatos resultadoJuego = new VerificarDatos();
        CPU resultadoCPU = new CPU();
        //Lamando a la clase de consulta en el servidor
        Consultas juegos = new Consultas();

        public Cocodrilo()
        {
            //Iniciando el formulario
            InitializeComponent();
            Application.ApplicationExit += new EventHandler(cerrandoAplicacion);
        }

        private void Cocodrilo_Load(object sender, EventArgs e)
        {
            //Funcionalidad para habilitar las opciones del menustri´p, dependiendo si es cliente o administrador
            etiquetaNombre.Text = "Bienvenido " + nombreUsuario;
            if (tipoUsuario == "login_administrador")
            {
                administarClientes.Enabled = true;
                administarCuenta.Enabled = false;
                jugadorVsCPU.Enabled = false;
                dosJugadores.Enabled = false;
                variosJugadores.Enabled = false;
                No_Dientes();
            }
            else
            {
                administarClientes.Enabled = false;
                administarCuenta.Enabled = true;
                jugadorVsCPU.Enabled = true;
                dosJugadores.Enabled = true;
                variosJugadores.Enabled = true;
                No_Dientes();
            }
        }

        public void No_Dientes()
        {
            pictureBox_Cocodrilo.Image = Properties.Resources.Cocodrilo_Presentacion_2;
            Diente1.Visible = false;
            Diente2.Visible = false;
            Diente3.Visible = false;
            Diente4.Visible = false;
            Diente5.Visible = false;
            Diente6.Visible = false;
            Diente7.Visible = false;
            Diente8.Visible = false;
            Diente9.Visible = false;
            Diente10.Visible = false;
            Diente11.Visible = false;
            Diente12.Visible = false;
            Diente13.Visible = false;
            Diente14.Visible = false;
            Diente14.Visible = false;
            Diente15.Visible = false;
            Diente16.Visible = false;
            Diente17.Visible = false;
            Diente18.Visible = false;
            Diente19.Visible = false;
            Diente20.Visible = false;
            Diente21.Visible = false;
            Diente22.Visible = false;
            Diente23.Visible = false;
            Diente24.Visible = false;
        }

        public void Si_Dientes()
        {
            pictureBox_Cocodrilo.Image = Properties.Resources.Dientes_No;
            Diente1.Visible = true;
            Diente2.Visible = true;
            Diente3.Visible = true;
            Diente4.Visible = true;
            Diente5.Visible = true;
            Diente6.Visible = true;
            Diente7.Visible = true;
            Diente8.Visible = true;
            Diente9.Visible = true;
            Diente10.Visible = true;
            Diente11.Visible = true;
            Diente12.Visible = true;
            Diente13.Visible = true;
            Diente14.Visible = true;
            Diente14.Visible = true;
            Diente15.Visible = true;
            Diente16.Visible = true;
            Diente17.Visible = true;
            Diente18.Visible = true;
            Diente19.Visible = true;
            Diente20.Visible = true;
            Diente21.Visible = true;
            Diente22.Visible = true;
            Diente23.Visible = true;
            Diente24.Visible = true;
        }

        public void cerrandoAplicacion(object sender, EventArgs e)
        {
            //Evento desarrollado para cerrar correctamenete la aplicacion
            try
            {
                //La aplicacion se cerra siempre y cuando este en un estado de conectado.
                if (Conectado == true)
                {
                    //Cierra las conexiones, los stream de lectura y escritura, el puerto, etc 
                    //Pasa a estado de desconectado
                    DialogResult resultado = MessageBox.Show("Se cerrara la ventana del juego del Cliente.", "Advertencia.", MessageBoxButtons.OKCancel);
                    if (resultado == DialogResult.OK)
                    {
                        Conectado = false;
                        envioMensaje.Close();
                        lecturaMensaje.Close();
                        servidorTCP.Close();
                        Close();
                    }
                    else
                    {
                        return;
                    }
                }

                else
                {
                    Close();
                }
            }
            catch (Exception)
            {
                //No mostrar mensajes
            }
        }

        private void cerrandoConexion(string cerrar)
        {
            //Cerrando la conexion del cliente
            try
            {
                DialogResult resultado = MessageBox.Show("Se desconectara del Juego", "Saliendo.", MessageBoxButtons.OKCancel);
                if (resultado == DialogResult.OK)
                {
                    //Cerrando todo las conexiones, puerto y streams y pasando a estado de no conectado
                    Conectado = false;
                    envioMensaje.Close();
                    lecturaMensaje.Close();
                    servidorTCP.Close();
                    groupBoxMesajes.Enabled = false;
                    listaMensajes.Items.Clear();
                }
                else
                {
                    return;
                }
            }
            catch (Exception)
            {
                //No hacer nada
            }
        }

        private void iniciandoConexion()
        {
            try
            {
                //Agregando la direccion IP del servidor en forma de ojeto tipo IPAddress 
                //Con los valores puestos por el programador
                //Igresando la direccion de localhos para contactar con el servidor
                direccionIP = IPAddress.Parse("127.0.0.1");
                //Iniciando una nueva conexion con el servidor por el puerto pre-establecido y
                //Pasando a la variable el nombre que se encuentra en el textbox
                //Finalmente pasa a estado conectado
                servidorTCP = new TcpClient();
                servidorTCP.Connect(direccionIP, 11000);
                Conectado = true;
                //Seleccionando el tipo de nombre con el cual presentarse a los demas cleinte
                envioMensaje = new StreamWriter(servidorTCP.GetStream());
                envioMensaje.WriteLine(nombreUsuario);
                envioMensaje.Flush();
                //Iiniciando el hilo para la comunicacion y poder recibir los mensajes.
                hiloMensaje = new Thread(new ThreadStart(reciviendoMensajes));
                hiloMensaje.Start();
                //Deshabilitando elementos
                groupBoxMesajes.Enabled = true;
                txtMensajeEnviar.Focus();
            }
            catch (Exception)
            {
                MessageBox.Show("Se produjo un error durante el intento de conexión ya que la parte conectada no respondió" + "\n" +
                                 "adecuadamente tras un periodo de tiempo, o bien se produjo un error en la conexión" + "\n" +
                                 "establecida ya que el host conectado no ha podido responder", "Advertecia", MessageBoxButtons.OK);
            }
        }

        private void reciviendoMensajes()
        {
            //Reciviendo las respuestas desde el servidor
            lecturaMensaje = new StreamReader(servidorTCP.GetStream());
            //Asignacon por medio de caracteres a conectado o desconectado
            //Si el primer caracter recibido es un 1 se establecera como conexion exitosa
            string respuestaServidor = lecturaMensaje.ReadLine();
            if (respuestaServidor[0] == '1')
            {
                //Informando a los clientes de los usuarios que pudieron conectarse exitosamente
                this.Invoke(new actualizacionMensajes(this.actualizarListaMensajes),
                            new object[] { "Se ha conectado Exitosamente..." });
            }
            //Si el primer caracter que llega del servidor es distinto de 1 se establecera como no conectado
            else
            {
                string noConectado = "No se ha podido establecer la conexion...";
                noConectado += respuestaServidor.Substring(2, respuestaServidor.Length - 2);
                this.Invoke(new actualizacionInformacion(this.cerrandoConexion),
                            new object[] { noConectado });
                return;
            }
            // Mientras este conectado el cliente se presentaran los mensajes en pantalla
            while (Conectado == true)
            {
                //Mostrando los mensajes en el ListBox
                try
                {
                    this.Invoke(new actualizacionMensajes(this.actualizarListaMensajes),
                                new object[] { lecturaMensaje.ReadLine() });
                }
                catch (Exception)
                {
                    //Mesaje de error
                    //MessageBox.Show("No se pudo mostrar el mensaje, debido a un error...", "Adertencia", MessageBoxButtons.OK);
                }
            }
        }
        
        private void actualizarListaMensajes(string mensajeRecivido)
        {
            //Metodo llamados desde otro hilo diferentes para poder actualizar el listbox
            listaMensajes.Items.Add(mensajeRecivido);
            etiquetaNombre.Text = mensajeRecivido;
        }
        
        private void enviarMensajeDestino()
        {
            // Proceso de envio de mensajes al servidor
            if (txtMensajeEnviar.Lines.Length >= 1)
            {
                try
                {
                    envioMensaje.WriteLine(txtMensajeEnviar.Text);
                    envioMensaje.Flush();
                    txtMensajeEnviar.Lines = null;
                }
                catch (Exception)
                {
                    MessageBox.Show("No se pudo enviar el mensaje debido a que se perdio conexion con el servidor.", "Aviso.", MessageBoxButtons.OK);
                }
            }
        }

        private void boton_Volver_Login_Click(object sender, EventArgs e)
        {
            //Cerrando la aplicacion
            cerrandoConexion("Cerrando");
            //Evento desarrollado para cerrar correctamenete la aplicacion
            try
            {
                //La aplicacion se cerra siempre y cuando este en un estado de conectado.
                if (Conectado == true)
                {
                    //Cierra las conexiones, los stream de lectura y escritura, el puerto, etc 
                    //Pasa a estado de desconectado
                    DialogResult resultado = MessageBox.Show("Se cerrara la ventana del Cliente.", "Advertencia.", MessageBoxButtons.OKCancel);
                    if (resultado == DialogResult.OK)
                    {
                        Conectado = false;
                        envioMensaje.Close();
                        lecturaMensaje.Close();
                        servidorTCP.Close();
                        Login cambio = new Login();
                        Hide();
                        cambio.Show();
                    }
                    else
                    {
                        return;
                    }
                }

                else
                {
                    Login cambio = new Login();
                    Hide();
                    cambio.Show();
                }
            }
            catch (Exception)
            {
                //No mostrar mensajes
            }
        }

        private void botonSalir_Click(object sender, EventArgs e)
        {
            //Cerrando la aplicacion
            cerrandoConexion("Cerrando");
            cerrandoAplicacion(sender, e);
        }

        private void botonEnviar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMensajeEnviar.Text))
            {
                MessageBox.Show("No se pueden enviar mensajes en blanco", "Advertencia", MessageBoxButtons.OK);
            }
            else
            {
                enviarMensajeDestino();
                txtMensajeEnviar.Text = "";
                txtMensajeEnviar.Focus();
            }
        }

        private void Dientes_Click(object sender, EventArgs e)
        {
            PictureBox pic = sender as PictureBox;
            etiquetaDienteSeleccionado.Text = pic.Tag.ToString();
            //Se agrega un numero aleatorio a cada diente seleccionado
            numeros.GeneradorNumeros();
            foreach (String item in numeros.numerosAgregar)
            {
                //etiquetaNombreJugador1.Text = item;
                resultadoJuego.recibirDiente = item;
                valorDiente = item;
            }
        }

        private void administarCuenta_Click(object sender, EventArgs e)
        {
            //Cambiamos de formualario al formulario de registro de usuarios
            //Y ocultamos el formulario actual
            Registro cambio = new Registro();
            //Pasamos el dato para saber que hubo cambio de formulario desde el Cocodrilo al registro
            cambio.de_user_modificar = "user_modificar";
            cambio.de_user_modificar_nombre = nombreUsuario;
            Hide();
            cambio.Show();
        }

        private void jugadorVsCPU_Click(object sender, EventArgs e)
        {
            //Se inicializalas vidas del jugador en 5
            vidasJugador = 5;
            vidasCPU = 5;
            //Se pasa el para metro del tipo de juego
            tipoJuego = "Jugador_vs_CPU";
            if (Conectado == false)
            {
                Si_Dientes();
                //Informado a la aplicacion que evento aplicar cuando se cierra la aplicacion
                //Iniciando la conexion con el servidor
                iniciandoConexion();
                txtNick.Text = nombreUsuario;
                etiquetaNombreJugador1.Text = "CPU";
                //Deshabilitanmos los modos de juego
                jugadorVsCPU.Enabled = false;
                dosJugadores.Enabled = false;
                variosJugadores.Enabled = false;
                //Deshabilitando a los jugadores
                etiquetaJugador1.Visible = true;
                etiquetaJugador2.Visible = false;
                etiquetaJugador3.Visible = false;
                etiquetaJugador4.Visible = false;
                etiquetaVidasJugador1.Visible = true;
                etiquetaVidasJugador2.Visible = false;
                etiquetaVidasJugador3.Visible = false;
                etiquetaVidasJugador4.Visible = false;
                etiquetaNombreJugador1.Visible = true;
                etiquetaNombreJugador2.Visible = false;
                etiquetaNombreJugador3.Visible = false;
                etiquetaNombreJugador4.Visible = false;
                Vida_1_Jugador_1.Visible = true;
                Vida_2_Jugador_1.Visible = true;
                Vida_3_Jugador_1.Visible = true;
                Vida_4_Jugador_1.Visible = true;
                Vida_5_Jugador_1.Visible = true;
                Vida_1_Jugador_2.Visible = false;
                Vida_2_Jugador_2.Visible = false;
                Vida_3_Jugador_2.Visible = false;
                Vida_4_Jugador_2.Visible = false;
                Vida_5_Jugador_2.Visible = false;
                Vida_1_Jugador_3.Visible = false;
                Vida_2_Jugador_3.Visible = false;
                Vida_3_Jugador_3.Visible = false;
                Vida_4_Jugador_3.Visible = false;
                Vida_5_Jugador_3.Visible = false;
                Vida_1_Jugador_4.Visible = false;
                Vida_2_Jugador_4.Visible = false;
                Vida_3_Jugador_4.Visible = false;
                Vida_4_Jugador_4.Visible = false;
                Vida_5_Jugador_4.Visible = false;
            }
            else
            {
                cerrandoConexion("Desconectado por peticion del cliente.");
            }
        }

        private void dosJugadores_Click(object sender, EventArgs e)
        {   
            //Se pasa el para metro del tipo de juego
            //Se inicializalas vidas del jugador en 5
            vidasJugador = 5;
            tipoJuego = "DosJugadores";
            if (Conectado == false)
            {
                Si_Dientes();
                //Informado a la aplicacion que evento aplicar cuando se cierra la aplicacion
                //Iniciando la conexion con el servidor
                iniciandoConexion();
                txtNick.Text = nombreUsuario;
                etiquetaNombreJugador1.Text = "Esperando Jugador...";
                //Deshabilitanmos los modos de juego
                jugadorVsCPU.Enabled = false;
                dosJugadores.Enabled = false;
                variosJugadores.Enabled = false;
                //Deshabilitando a los jugadores
                etiquetaJugador1.Visible = true;
                etiquetaJugador2.Visible = false;
                etiquetaJugador3.Visible = false;
                etiquetaJugador4.Visible = false;
                etiquetaVidasJugador1.Visible = true;
                etiquetaVidasJugador2.Visible = false;
                etiquetaVidasJugador3.Visible = false;
                etiquetaVidasJugador4.Visible = false;
                etiquetaNombreJugador1.Visible = true;
                etiquetaNombreJugador2.Visible = false;
                etiquetaNombreJugador3.Visible = false;
                etiquetaNombreJugador4.Visible = false;
                Vida_1_Jugador_1.Visible = true;
                Vida_2_Jugador_1.Visible = true;
                Vida_3_Jugador_1.Visible = true;
                Vida_4_Jugador_1.Visible = true;
                Vida_5_Jugador_1.Visible = true;
                Vida_1_Jugador_2.Visible = false;
                Vida_2_Jugador_2.Visible = false;
                Vida_3_Jugador_2.Visible = false;
                Vida_4_Jugador_2.Visible = false;
                Vida_5_Jugador_2.Visible = false;
                Vida_1_Jugador_3.Visible = false;
                Vida_2_Jugador_3.Visible = false;
                Vida_3_Jugador_3.Visible = false;
                Vida_4_Jugador_3.Visible = false;
                Vida_5_Jugador_3.Visible = false;
                Vida_1_Jugador_4.Visible = false;
                Vida_2_Jugador_4.Visible = false;
                Vida_3_Jugador_4.Visible = false;
                Vida_4_Jugador_4.Visible = false;
                Vida_5_Jugador_4.Visible = false;
            }
            else
            {
                cerrandoConexion("Desconectado por peticion del cliente.");
            }
        }

        private void variosJugadores_Click(object sender, EventArgs e)
        {
            //Se pasa el para metro del tipo de juego
            tipoJuego = "VariosJugadores";
            if (Conectado == false)
            {
                //Informado a la aplicacion que evento aplicar cuando se cierra la aplicacion
                //Iniciando la conexion con el servidor
                iniciandoConexion();
                //Deshabilitanmos los modos de juego
                jugadorVsCPU.Enabled = false;
                dosJugadores.Enabled = false;
                variosJugadores.Enabled = false;



            }
            else
            {
                cerrandoConexion("Desconectado por peticion del cliente.");
            }
        }

        private void boton_Enviar_Datos_Juego_Click(object sender, EventArgs e)
        {
            //Si el tipo de juego es contra la computadora de ejecuta las siguintes lineas...
            if (tipoJuego == "Jugador_vs_CPU")
            {
                //Se envia los datos al servidor para su validacion
                resultadoJuego.recibirPeso = etiquetaValor.Text;
                //se ejecuta el metodo de validacion en el servidor
                resultadoJuego.Ganador_Perdedor();
                //Obtenemos los resultados
                if (resultadoJuego.resultado_Ganador_Perdedor == "Has Ganado")
                {
                    MessageBox.Show("Has Ganado");
                    //Se procede a eliminar el diente seleccionado si el jugador gano
                    if (etiquetaDienteSeleccionado.Text == "1")
                    {
                        Diente1.Enabled = false;
                        Diente1.Visible = false;
                    }
                    if (etiquetaDienteSeleccionado.Text == "2")
                    {
                        Diente2.Enabled = false;
                        Diente2.Visible = false;
                    }
                    if (etiquetaDienteSeleccionado.Text == "3")
                    {
                        Diente3.Enabled = false;
                        Diente3.Visible = false;
                    }
                    if (etiquetaDienteSeleccionado.Text == "4")
                    {
                        Diente4.Enabled = false;
                        Diente4.Visible = false;
                    }
                    if (etiquetaDienteSeleccionado.Text == "5")
                    {
                        Diente5.Enabled = false;
                        Diente5.Visible = false;
                    }
                    if (etiquetaDienteSeleccionado.Text == "6")
                    {
                        Diente6.Enabled = false;
                        Diente6.Visible = false;
                    }
                    if (etiquetaDienteSeleccionado.Text == "7")
                    {
                        Diente7.Enabled = false;
                        Diente7.Visible = false;
                    }
                    if (etiquetaDienteSeleccionado.Text == "8")
                    {
                        Diente8.Enabled = false;
                        Diente8.Visible = false;
                    }
                    if (etiquetaDienteSeleccionado.Text == "9")
                    {
                        Diente9.Enabled = false;
                        Diente9.Visible = false;
                    }
                    if (etiquetaDienteSeleccionado.Text == "10")
                    {
                        Diente10.Enabled = false;
                        Diente10.Visible = false;
                    }
                    if (etiquetaDienteSeleccionado.Text == "11")
                    {
                        Diente11.Enabled = false;
                        Diente11.Visible = false;
                    }
                    if (etiquetaDienteSeleccionado.Text == "12")
                    {
                        Diente12.Enabled = false;
                        Diente12.Visible = false;
                    }
                    if (etiquetaDienteSeleccionado.Text == "13")
                    {
                        Diente13.Enabled = false;
                        Diente13.Visible = false;
                    }
                    if (etiquetaDienteSeleccionado.Text == "14")
                    {
                        Diente14.Enabled = false;
                        Diente14.Visible = false;
                    }
                    if (etiquetaDienteSeleccionado.Text == "15")
                    {
                        Diente15.Enabled = false;
                        Diente15.Visible = false;
                    }
                    if (etiquetaDienteSeleccionado.Text == "16")
                    {
                        Diente16.Enabled = false;
                        Diente16.Visible = false;
                    }
                    if (etiquetaDienteSeleccionado.Text == "17")
                    {
                        Diente17.Enabled = false;
                        Diente17.Visible = false;
                    }
                    if (etiquetaDienteSeleccionado.Text == "18")
                    {
                        Diente18.Enabled = false;
                        Diente18.Visible = false;
                    }
                    if (etiquetaDienteSeleccionado.Text == "19")
                    {
                        Diente19.Enabled = false;
                        Diente19.Visible = false;
                    }
                    if (etiquetaDienteSeleccionado.Text == "20")
                    {
                        Diente20.Enabled = false;
                        Diente20.Visible = false;
                    }
                    if (etiquetaDienteSeleccionado.Text == "21")
                    {
                        Diente21.Enabled = false;
                        Diente21.Visible = false;
                    }
                    if (etiquetaDienteSeleccionado.Text == "22")
                    {
                        Diente22.Enabled = false;
                        Diente22.Visible = false;
                    }
                    if (etiquetaDienteSeleccionado.Text == "23")
                    {
                        Diente23.Enabled = false;
                        Diente23.Visible = false;
                    }
                    if (etiquetaDienteSeleccionado.Text == "24")
                    {
                        Diente24.Enabled = false;
                        Diente24.Visible = false;
                    }
                }
                if (resultadoJuego.resultado_Ganador_Perdedor == "Has Perdido")
                {
                    MessageBox.Show("Has Perdido una Vida");
                    vidasJugador = vidasJugador - 1;
                    if (vidasJugador == 4)
                    {
                        Vida5.Image = Properties.Resources.Corazon_Menos;
                    }
                    if (vidasJugador == 3)
                    {
                        Vida4.Image = Properties.Resources.Corazon_Menos;
                    }
                    if (vidasJugador == 2)
                    {
                        Vida3.Image = Properties.Resources.Corazon_Menos;
                    }
                    if (vidasJugador == 1)
                    {
                        Vida2.Image = Properties.Resources.Corazon_Menos;
                    }
                    if (vidasJugador == 0)
                    {
                        Vida1.Image = Properties.Resources.Corazon_Menos;
                        MessageBox.Show("Se te acabaron las Vidas has perdido todo... XXXX es el ganador");
                    }
                }

                //Se ejecuta  las elecciones del servidor
                resultadoCPU.GeneradorNumerosCPU();
                foreach (String item in resultadoCPU.numerosAgregarCPU)
                {
                    valorPesoCPU = item;
                }
                resultadoCPU.GeneradorNumerosCPU_Dientes();
                foreach (String item in resultadoCPU.numerosAgregarCPU_Dientes)
                {
                    valorDienteCPU = item;   
                }
                //Obtenemos los resultados
                if (valorPesoCPU == valorDiente)
                {
                    MessageBox.Show("CPU Ha Ganado");
                    //Se procede a eliminar el diente seleccionado si el jugador gano
                    if (valorDienteCPU == "1")
                    {
                        Diente1.Enabled = false;
                        Diente1.Visible = false;
                    }
                    if (valorDienteCPU == "2")
                    {
                        Diente2.Enabled = false;
                        Diente2.Visible = false;
                    }
                    if (valorDienteCPU == "3")
                    {
                        Diente3.Enabled = false;
                        Diente3.Visible = false;
                    }
                    if (valorDienteCPU == "4")
                    {
                        Diente4.Enabled = false;
                        Diente4.Visible = false;
                    }
                    if (valorDienteCPU == "5")
                    {
                        Diente5.Enabled = false;
                        Diente5.Visible = false;
                    }
                    if (valorDienteCPU == "6")
                    {
                        Diente6.Enabled = false;
                        Diente6.Visible = false;
                    }
                    if (valorDienteCPU == "7")
                    {
                        Diente7.Enabled = false;
                        Diente7.Visible = false;
                    }
                    if (valorDienteCPU == "8")
                    {
                        Diente8.Enabled = false;
                        Diente8.Visible = false;
                    }
                    if (valorDienteCPU == "9")
                    {
                        Diente9.Enabled = false;
                        Diente9.Visible = false;
                    }
                    if (valorDienteCPU == "10")
                    {
                        Diente10.Enabled = false;
                        Diente10.Visible = false;
                    }
                    if (valorDienteCPU == "11")
                    {
                        Diente11.Enabled = false;
                        Diente11.Visible = false;
                    }
                    if (valorDienteCPU == "12")
                    {
                        Diente12.Enabled = false;
                        Diente12.Visible = false;
                    }
                    if (valorDienteCPU == "13")
                    {
                        Diente13.Enabled = false;
                        Diente13.Visible = false;
                    }
                    if (valorDienteCPU == "14")
                    {
                        Diente14.Enabled = false;
                        Diente14.Visible = false;
                    }
                    if (valorDienteCPU == "15")
                    {
                        Diente15.Enabled = false;
                        Diente15.Visible = false;
                    }
                    if (valorDienteCPU == "16")
                    {
                        Diente16.Enabled = false;
                        Diente16.Visible = false;
                    }
                    if (valorDienteCPU == "17")
                    {
                        Diente17.Enabled = false;
                        Diente17.Visible = false;
                    }
                    if (valorDienteCPU == "18")
                    {
                        Diente18.Enabled = false;
                        Diente18.Visible = false;
                    }
                    if (valorDienteCPU == "19")
                    {
                        Diente19.Enabled = false;
                        Diente19.Visible = false;
                    }
                    if (valorDienteCPU == "20")
                    {
                        Diente20.Enabled = false;
                        Diente20.Visible = false;
                    }
                    if (valorDienteCPU == "21")
                    {
                        Diente21.Enabled = false;
                        Diente21.Visible = false;
                    }
                    if (valorDienteCPU == "22")
                    {
                        Diente22.Enabled = false;
                        Diente22.Visible = false;
                    }
                    if (valorDienteCPU == "23")
                    {
                        Diente23.Enabled = false;
                        Diente23.Visible = false;
                    }
                    if (valorDienteCPU == "24")
                    {
                        Diente24.Enabled = false;
                        Diente24.Visible = false;
                    }
                }
                else
                {
                    MessageBox.Show("CPU ha perdido una vida");
                    vidasCPU = vidasCPU - 1;
                    if (vidasCPU == 4)
                    {
                        Vida_5_Jugador_1.Image = Properties.Resources.Corazon_Menos;
                    }
                    if (vidasCPU == 3)
                    {
                        Vida_4_Jugador_1.Image = Properties.Resources.Corazon_Menos;
                    }
                    if (vidasCPU == 2)
                    {
                        Vida_3_Jugador_1.Image = Properties.Resources.Corazon_Menos;
                    }
                    if (vidasCPU == 1)
                    {
                        Vida_2_Jugador_1.Image = Properties.Resources.Corazon_Menos;
                    }
                    if (vidasCPU == 0)
                    {
                        Vida_1_Jugador_1.Image = Properties.Resources.Corazon_Menos;
                        MessageBox.Show("Se le acabaron las Vidas al CPU... " +  nombreUsuario + " es el ganador");
                    }
                }
            }
            if (tipoJuego == "DosJugadores")
            {
                juegos.nomrbre = nombreUsuario;
                juegos.VidasTotales = vidasJugador;
                juegos.DienteTotal = Convert.ToInt32(etiquetaDienteSeleccionado.Text);
                juegos.GanoPerdio = "Si";
                juegos.actualizarResultados();
                juegos.consultaResultados(juegos.mostrarrRsultados);
                foreach (var item in juegos.mostrarrRsultados)
                {
                    etiquetaNombreJugador1.Text = item.LoginUser;
                }
                //Se envia los datos al servidor para su validacion
                resultadoJuego.recibirPeso = etiquetaValor.Text;
                //se ejecuta el metodo de validacion en el servidor
                resultadoJuego.Ganador_Perdedor();
                //Obtenemos los resultados
                if (resultadoJuego.resultado_Ganador_Perdedor == "Has Ganado")
                {
                    MessageBox.Show("Has Ganado");
                    //Se procede a eliminar el diente seleccionado si el jugador gano
                    if (etiquetaDienteSeleccionado.Text == "1")
                    {
                        Diente1.Enabled = false;
                        Diente1.Visible = false;
                    }
                    if (etiquetaDienteSeleccionado.Text == "2")
                    {
                        Diente2.Enabled = false;
                        Diente2.Visible = false;
                    }
                    if (etiquetaDienteSeleccionado.Text == "3")
                    {
                        Diente3.Enabled = false;
                        Diente3.Visible = false;
                    }
                    if (etiquetaDienteSeleccionado.Text == "4")
                    {
                        Diente4.Enabled = false;
                        Diente4.Visible = false;
                    }
                    if (etiquetaDienteSeleccionado.Text == "5")
                    {
                        Diente5.Enabled = false;
                        Diente5.Visible = false;
                    }
                    if (etiquetaDienteSeleccionado.Text == "6")
                    {
                        Diente6.Enabled = false;
                        Diente6.Visible = false;
                    }
                    if (etiquetaDienteSeleccionado.Text == "7")
                    {
                        Diente7.Enabled = false;
                        Diente7.Visible = false;
                    }
                    if (etiquetaDienteSeleccionado.Text == "8")
                    {
                        Diente8.Enabled = false;
                        Diente8.Visible = false;
                    }
                    if (etiquetaDienteSeleccionado.Text == "9")
                    {
                        Diente9.Enabled = false;
                        Diente9.Visible = false;
                    }
                    if (etiquetaDienteSeleccionado.Text == "10")
                    {
                        Diente10.Enabled = false;
                        Diente10.Visible = false;
                    }
                    if (etiquetaDienteSeleccionado.Text == "11")
                    {
                        Diente11.Enabled = false;
                        Diente11.Visible = false;
                    }
                    if (etiquetaDienteSeleccionado.Text == "12")
                    {
                        Diente12.Enabled = false;
                        Diente12.Visible = false;
                    }
                    if (etiquetaDienteSeleccionado.Text == "13")
                    {
                        Diente13.Enabled = false;
                        Diente13.Visible = false;
                    }
                    if (etiquetaDienteSeleccionado.Text == "14")
                    {
                        Diente14.Enabled = false;
                        Diente14.Visible = false;
                    }
                    if (etiquetaDienteSeleccionado.Text == "15")
                    {
                        Diente15.Enabled = false;
                        Diente15.Visible = false;
                    }
                    if (etiquetaDienteSeleccionado.Text == "16")
                    {
                        Diente16.Enabled = false;
                        Diente16.Visible = false;
                    }
                    if (etiquetaDienteSeleccionado.Text == "17")
                    {
                        Diente17.Enabled = false;
                        Diente17.Visible = false;
                    }
                    if (etiquetaDienteSeleccionado.Text == "18")
                    {
                        Diente18.Enabled = false;
                        Diente18.Visible = false;
                    }
                    if (etiquetaDienteSeleccionado.Text == "19")
                    {
                        Diente19.Enabled = false;
                        Diente19.Visible = false;
                    }
                    if (etiquetaDienteSeleccionado.Text == "20")
                    {
                        Diente20.Enabled = false;
                        Diente20.Visible = false;
                    }
                    if (etiquetaDienteSeleccionado.Text == "21")
                    {
                        Diente21.Enabled = false;
                        Diente21.Visible = false;
                    }
                    if (etiquetaDienteSeleccionado.Text == "22")
                    {
                        Diente22.Enabled = false;
                        Diente22.Visible = false;
                    }
                    if (etiquetaDienteSeleccionado.Text == "23")
                    {
                        Diente23.Enabled = false;
                        Diente23.Visible = false;
                    }
                    if (etiquetaDienteSeleccionado.Text == "24")
                    {
                        Diente24.Enabled = false;
                        Diente24.Visible = false;
                    }
                }
                if (resultadoJuego.resultado_Ganador_Perdedor == "Has Perdido")
                {
                    MessageBox.Show("Has Perdido una Vida");
                    vidasJugador = vidasJugador - 1;
                    juegos.nomrbre = nombreUsuario;
                    juegos.VidasTotales = vidasJugador;
                    juegos.DienteTotal = Convert.ToInt32(etiquetaDienteSeleccionado.Text);
                    juegos.GanoPerdio = "No";
                    juegos.actualizarResultados();
                    juegos.consultaResultados(juegos.mostrarrRsultados);
                    foreach (var item in juegos.mostrarrRsultados)
                    {
                        etiquetaNombreJugador1.Text = item.LoginUser;
                        //Descuebto de las vidas del propio jugador
                        if (item.Vidas == 4)
                        {
                            Vida5.Image = Properties.Resources.Corazon_Menos;
                        }
                        if (item.Vidas == 3)
                        {
                            Vida4.Image = Properties.Resources.Corazon_Menos;
                        }
                        if (item.Vidas == 2)
                        {
                            Vida3.Image = Properties.Resources.Corazon_Menos;
                        }
                        if (item.Vidas == 1)
                        {
                            Vida2.Image = Properties.Resources.Corazon_Menos;
                        }
                        if (item.Vidas == 0)
                        {
                            Vida1.Image = Properties.Resources.Corazon_Menos;
                            MessageBox.Show("Se te acabaron las Vidas has perdido todo..." + nombreUsuario + " es el ganador");
                        }
                    }
                    //Descuebto de las vidas del propio jugador
                    if (vidasJugador == 4)
                    {
                        Vida5.Image = Properties.Resources.Corazon_Menos;
                    }
                    if (vidasJugador == 3)
                    {
                        Vida4.Image = Properties.Resources.Corazon_Menos;
                    }
                    if (vidasJugador == 2)
                    {
                        Vida3.Image = Properties.Resources.Corazon_Menos;
                    }
                    if (vidasJugador == 1)
                    {
                        Vida2.Image = Properties.Resources.Corazon_Menos;
                    }
                    if (vidasJugador == 0)
                    {
                        Vida1.Image = Properties.Resources.Corazon_Menos;
                        MessageBox.Show("Se te acabaron las Vidas has perdido todo..." + etiquetaNombreJugador1.Text + " es el ganador");
                    }
                }
            }
        }

        private void registarCuentaNueva_Click(object sender, EventArgs e)
        {
            //Cambiamos de formualario al formulario de registro de usuarios
            //Y ocultamos el formulario actual
            Registro cambio = new Registro();
            //Pasamos el dato para saber que hubo cambio de formulario desde el Cocodrilo al registro
            cambio.de_administrador_registro = "administrador_registro";
            Hide();
            cambio.Show();
        }

        private void modificarCuentaExistente_Click(object sender, EventArgs e)
        {
            //Cambiamos de formualario al formulario de registro de usuarios
            //Y ocultamos el formulario actual
            Registro cambio = new Registro();
            //Pasamos el dato para saber que hubo cambio de formulario desde el Cocodrilo al registro
            cambio.de_administrador_modificar = "administrador_modificar";
            cambio.de_user_modificar_nombre = nombreUsuario;
            Hide();
            cambio.Show();
        }

        private void ScrollBarPeso_Scroll(object sender, ScrollEventArgs e)
        {
            //Obteniendo el valor del peso mediante el movimiento del scrollbar e igualandolo a la etiqueta del formulario
            etiquetaValor.Text = ScrollBarPeso.Value.ToString();
            peso = ScrollBarPeso.Value;
        }

        private void botonConsultarJuegos_Click(object sender, EventArgs e)
        {
            juegos.usuario = nombreUsuario;
            juegos.mostrarJuegosUsuarios(juegos.mostrarJuegos);
            if (juegos.mostrarJuegos.Count > 0)
            {
                foreach (var item in juegos.mostrarJuegos)
                {
                    dataGridView_Juegos.DataSource = juegos.mostrarJuegos.Select(x => x).Select(y => new
                        {
                            ID_JUEGO = y.Id_juego,
                            ID_CLIENTE = y.Id_Cliente,
                            LOGINUSER = y.LoginUser,
                            NUMERO_JUEGOS = y.Numero_Juegos,
                            JUEGOS_GANADOS = y.Juegos_Ganados,
                            JUEGOS_EMPATADOS = y.Juegos_Empatados,
                            JUEGOS_PERDIDOS = y.JuegosPerdidos,
                            ACIERTOS_TOTALES = y.Aciertos_Totales,
                            ERRORES_TOTALES = y.Errores_Totales
                        }).ToList();
                }
                dataGridView_Juegos.SelectionMode = DataGridViewSelectionMode.CellSelect;
            }  
        }
    }
}