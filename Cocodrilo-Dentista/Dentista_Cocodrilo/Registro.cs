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
    public partial class Registro : Form
    {
        //Instanciando el metodo de consultas en el servidor
        Servidor.Consultas nuevaConsulta = new Servidor.Consultas();
        //Variables locales que me permiten el envio y la recepcon de datos desde el servidor
        public string de_administrador_modificar;
        public string de_administrador_registro;
        public string de_user_modificar_nombre;
        public string de_login_registro;
        public string de_user_modificar;

        public Registro()
        {
            //Inicializa el formulario
            InitializeComponent();
        }

        private void Registro_Load(object sender, EventArgs e)
        {
            //Cargando cierto parametros al iniciar el formulario
            cargarIdentificador();
            Cargar_Datos();
            User_Admin();
            limpiar();
        }

        public void verificarUser()
        {
            //Limpiando la lista recivida para que se actualize de haber habido cambios en la base de datos
            nuevaConsulta.mostrarLista.Clear();
            //Pasando al servdor los parametros de busqueda: Login y Contraseña
            nuevaConsulta.usuario = txtUser.Text;
            //Obteniedo la lista desde el servidor
            nuevaConsulta.verificarUser(nuevaConsulta.mostrarLista);
            //Si la lista recibida posee datos procedera a la validacion del cliente
            if (nuevaConsulta.mostrarLista.Count > 0)
            {
                //reorriendo la lista recibida para verificar si no hay coincidencias
                foreach (var usu in nuevaConsulta.mostrarLista)
                {
                    //Si hay coincidencias con la lista recibida se tendra que ingresar otro usuario
                    if (txtUser.Text == usu.LoginUser)
                    {
                        //Mensaje de error de haber coincidencias
                        MessageBox.Show("El nombre de usuario:" + " " + usu.LoginUser + " " + "ya existe.", "ALERTA");
                        //foco al textbox para que valide el usuario
                        txtUser.Focus();
                    }
                }
            }
            else
            {
                //Damos el foco al siguiente textox para continuar con el registro
                txtContraseña.Focus();
            }
        }

        private void cargarIdentificador()
        {
            //Recibimos los datos de la consulta, para realizar un id autonumerado
            //para cuando se desee actualizar, eliminar o ingresar un nuevo datos se tomara este id
            //para la consulta
            nuevaConsulta.cargarIdentificador(0);
            txtID.Text = nuevaConsulta.idenfificadorUsuario.ToString();
        }

        private void limpiar()
        {
            //Metodo usado para limpiar los campo despues de un registro, actualizacion o eliminacion de los clientes
            txtNombre.Text = "Ingrese sus Nombres";
            txtApellido.Text = "Ingrese sus Apellidos";
            txtUser.Clear();
            txtContraseña.Clear();
            txtConfirmarContraseña.Clear();
            txtCorreo.Clear();
            txtTelefono.Clear();
            txtPais.Clear();
            comboBoxDia.Text = "Dia";
            comboBoxMes.Text = "Mes";
            comboBoxAño.Text = "Año";
            comboBoxSexo.Text = "Escoja su Sexo";
        }

        private void User_Admin()
        {
            //Metodo que me permite revisar los pasos que han dado los usuarios de la aplicacion
            //Me permite revisar de que formulario proviene, mediante variables globales recibidas
            //De este modo es más sencillo devolverlos al formulario adecuado
            if (de_login_registro == "login_registro")
            {
                etiquetaTitulo.Text = "CREAR NUEVA CUENTA.";
                groupBox_Condiciones.Visible = true;
                dataGridView_Datos.Visible = false;
                botonEliminar.Visible = false;
                botonRegistrase.Text = "Registrarse";
            }
            if (de_administrador_registro == "administrador_registro")
            {
                etiquetaTitulo.Text = "CREAR NUEVA CUENTA.";
                groupBox_Condiciones.Visible = false;
                dataGridView_Datos.Visible = false;
                botonEliminar.Visible = false;
                botonRegistrase.Text = "Registar";
            }
            if (de_administrador_modificar == "administrador_modificar")
            {
                etiquetaTitulo.Text = "MODIFICAR CUENTA EXISTENTE.";
                groupBox_Condiciones.Visible = false;
                dataGridView_Datos.Visible = true;
                botonEliminar.Visible = true;
                botonRegistrase.Text = "Actualizar";
            }
            if (de_user_modificar == "user_modificar")
            {
                etiquetaTitulo.Text = "MODIFICAR TU CUENTA.";
                groupBox_Condiciones.Visible = false;
                dataGridView_Datos.Visible = true;
                botonEliminar.Visible = false;
                botonRegistrase.Text = "Actualizar";
            }
        }

        private void Cargar_Datos()
        {
            if (de_administrador_modificar == "administrador_modificar")
            {
                //Limpiando la lista recivida para que se actualize de haber habido cambios en la base de datos
                nuevaConsulta.mostrarLista.Clear();
                //Recibiendo un lista con todos los datos de la tabla y presentarlos en el datagrudview
                nuevaConsulta.mostrarTodosLosDatos(nuevaConsulta.mostrarLista);
                if (nuevaConsulta.mostrarLista.Count > 0)
                {
                    foreach (var item in nuevaConsulta.mostrarLista)
                    {
                        dataGridView_Datos.DataSource = nuevaConsulta.mostrarLista.Select(x => x).Select(y => new
                        {
                            ID = y.Id,
                            NOMBRE = y.Nombre,
                            APELLIDO = y.Apellido,
                            USER = y.LoginUser,
                            CONTRASEÑA = y.Contraseña,
                            EMAIL = y.eMail,
                            TELEFONO = y.Telefono,
                            PAIS = y.Pais,
                            FECHA_NACIMIENTO = y.Fecha,
                            SEXO = y.Sexo
                        }).ToList();
                    }
                    dataGridView_Datos.SelectionMode = DataGridViewSelectionMode.CellSelect;
                }
            }
            if (de_user_modificar == "user_modificar")
            {
                //Limpiando la lista recivida para que se actualize de haber habido cambios en la base de datos
                nuevaConsulta.mostrarLista.Clear();
                nuevaConsulta.usuario = de_user_modificar_nombre;
                //Recibiendo un lista con todos los datos de la tabla y presentarlos en el datagrudview
                nuevaConsulta.mostrarDatosUsuario(nuevaConsulta.mostrarLista);
                if (nuevaConsulta.mostrarLista.Count > 0)
                {
                    foreach (var item in nuevaConsulta.mostrarLista)
                    {
                        dataGridView_Datos.DataSource = nuevaConsulta.mostrarLista.Select(x => x).Select(y => new
                        {
                            ID = y.Id,
                            NOMBRE = y.Nombre,
                            APELLIDO = y.Apellido,
                            USER = y.LoginUser,
                            CONTRASEÑA = y.Contraseña,
                            EMAIL = y.eMail,
                            TELEFONO = y.Telefono,
                            PAIS = y.Pais,
                            FECHA_NACIMIENTO = y.Fecha,
                            SEXO = y.Sexo
                        }).ToList();
                    }
                    dataGridView_Datos.SelectionMode = DataGridViewSelectionMode.CellSelect;
                }
            }
        }

        private void Guardar_Datos()
        {
            //Enviando los datos para guardar los datos de un nuevo usuario
            nuevaConsulta.idenfificadorUsuario = Convert.ToInt32(txtID.Text);
            nuevaConsulta.nomrbre = txtNombre.Text;
            nuevaConsulta.apellido = txtApellido.Text;
            nuevaConsulta.usuario = txtUser.Text;
            nuevaConsulta.contraseña = txtContraseña.Text;
            nuevaConsulta.correo = txtCorreo.Text;
            nuevaConsulta.telefono = Convert.ToInt32(txtTelefono.Text);
            nuevaConsulta.pais = txtPais.Text;
            nuevaConsulta.sexo = comboBoxSexo.SelectedItem.ToString();
            nuevaConsulta.dia = comboBoxDia.SelectedItem.ToString();
            nuevaConsulta.mes = comboBoxMes.SelectedItem.ToString();
            nuevaConsulta.año = comboBoxAño.SelectedItem.ToString();
            nuevaConsulta.agregarDatos();
        }

        private void botonRegistrase_Click(object sender, EventArgs e)
        {
            //Registr por parte del administrador
            if (de_administrador_registro == "administrador_registro")
            {
                if (txtNombre.Text == "" || txtApellido.Text == "" || txtUser.Text == "" || txtContraseña.Text == "" ||
                txtConfirmarContraseña.Text == "" || txtCorreo.Text == "" || txtTelefono.Text == "" || comboBoxDia.Text == "Dia" ||
                comboBoxMes.Text == "Mes" || comboBoxAño.Text == "Año" || comboBoxSexo.Text == "Escoja su Sexo")
                {
                    MessageBox.Show("Debe Llenar todos los Campos.", "Advertencia");
                }
                else
                {
                    Guardar_Datos();
                    MessageBox.Show("Usuario Registrado con Exito.", "AVISO");
                    Cocodrilo cambio = new Cocodrilo();
                    MessageBox.Show("Usuario " + txtUser.Text + " ingresado con exito.");
                    cambio.nombreUsuario = "Admin";
                    cambio.tipoUsuario = "login_administrador";
                    Hide();
                    cambio.Show();
                }
            }
            //Modificar por parte del administrador
            if (de_administrador_modificar == "administrador_modificar")
            {
                //Enviando los datos para guardar los datos de un nuevo usuario
                nuevaConsulta.idenfificadorUsuario = Convert.ToInt32(txtID.Text);
                nuevaConsulta.nomrbre = txtNombre.Text;
                nuevaConsulta.apellido = txtApellido.Text;
                nuevaConsulta.usuario = txtUser.Text;
                nuevaConsulta.contraseña = txtContraseña.Text;
                nuevaConsulta.correo = txtCorreo.Text;
                nuevaConsulta.telefono = Convert.ToInt32(txtTelefono.Text);
                nuevaConsulta.pais = txtPais.Text;
                nuevaConsulta.sexo = comboBoxSexo.SelectedItem.ToString();
                nuevaConsulta.dia = comboBoxDia.SelectedItem.ToString();
                nuevaConsulta.mes = comboBoxMes.SelectedItem.ToString();
                nuevaConsulta.año = comboBoxAño.SelectedItem.ToString();
                nuevaConsulta.modificarDatos();
                Cocodrilo cambio = new Cocodrilo();
                MessageBox.Show("Usuario " + txtUser.Text + " actualizado con exito.");
                cambio.nombreUsuario = "Admin";
                cambio.tipoUsuario = "login_administrador";
                Hide();
                cambio.Show();   
            }
            //registro del usario
            if (de_login_registro == "login_registro")
            {
                if (txtNombre.Text == "" || txtApellido.Text == "" || txtUser.Text == "" || txtContraseña.Text == "" ||
                txtConfirmarContraseña.Text == "" || txtCorreo.Text == "" || txtTelefono.Text == "" || comboBoxDia.Text == "Dia" ||
                comboBoxMes.Text == "Mes" || comboBoxAño.Text == "Año" || comboBoxSexo.Text == "Escoja su Sexo")
                {
                    MessageBox.Show("Debe Leenar todos los Campos.", "Advertencia");
                }
                if (checkBoxCondiciones.Checked == false)
                {
                    MessageBox.Show("Debe aceptar las Condiciones de uso.", "Advertencia");
                }
                else
                {
                    Guardar_Datos();
                    Cocodrilo cambio = new Cocodrilo();
                    MessageBox.Show("Usuario " + txtUser.Text + " ingresado con exito.");
                    cambio.nombreUsuario = txtUser.Text;
                    cambio.tipoUsuario = "registro_a_user";
                    Hide();
                    cambio.Show();
                }
            }
            if (de_user_modificar == "user_modificar")
            {
                //Enviando los datos para guardar los datos de un nuevo usuario
                nuevaConsulta.idenfificadorUsuario = Convert.ToInt32(txtID.Text);
                nuevaConsulta.nomrbre = txtNombre.Text;
                nuevaConsulta.apellido = txtApellido.Text;
                nuevaConsulta.usuario = txtUser.Text;
                nuevaConsulta.contraseña = txtContraseña.Text;
                nuevaConsulta.correo = txtCorreo.Text;
                nuevaConsulta.telefono = Convert.ToInt32(txtTelefono.Text);
                nuevaConsulta.pais = txtPais.Text;
                nuevaConsulta.sexo = comboBoxSexo.SelectedItem.ToString();
                nuevaConsulta.dia = comboBoxDia.SelectedItem.ToString();
                nuevaConsulta.mes = comboBoxMes.SelectedItem.ToString();
                nuevaConsulta.año = comboBoxAño.SelectedItem.ToString();
                nuevaConsulta.modificarDatos();
                Cocodrilo cambio = new Cocodrilo();
                MessageBox.Show("Usuario " + txtUser.Text + " actualizado con exito.");
                cambio.nombreUsuario = txtUser.Text;
                cambio.tipoUsuario = "registro_a_user";
                Hide();
                cambio.Show();
            }
        }

        private void botonEliminar_Click(object sender, EventArgs e)
        {
            //enviamos el id que queremos eliminar de la ase de datos
            nuevaConsulta.idenfificadorUsuario = Convert.ToInt32(txtID.Text);
            nuevaConsulta.elminarDatos(nuevaConsulta.mostrarLista);
            Cargar_Datos();
        }

        private void botonVolver_Click(object sender, EventArgs e)
        {
            //Metodo que me permite revisar los pasos que han dado los usuarios de la aplicacion
            //Me permite revisar de que formulario proviene, mediante variables globales recibidas
            //De este modo es más sencillo devolverlos al formulario adecuado
            if (de_login_registro == "login_registro")
            {
                //Cambiamos de formualario al formulario de Login de usuarios
                //Y ocultamos el formulario actual
                Login cambio = new Login();
                Hide();
                cambio.Show();
            }
            if (de_administrador_registro == "administrador_registro")
            {
                //Cambiamos de formualario al formulario de Cocodrilo 
                //Y ocultamos el formulario actual
                Cocodrilo cambio = new Cocodrilo();
                //Pasamos el dato para saber que hubo cambio de formulario desde el Login al registro
                cambio.tipoUsuario = "login_administrador";
                cambio.nombreUsuario = de_user_modificar_nombre;
                Hide();
                cambio.Show();
            }
            if (de_administrador_modificar == "administrador_modificar")
            {
                //Cambiamos de formualario al formulario de Cocodrilo 
                //Y ocultamos el formulario actual
                Cocodrilo cambio = new Cocodrilo();
                //Pasamos el dato para saber que hubo cambio de formulario desde el Login al registro
                cambio.tipoUsuario = "login_administrador";
                cambio.nombreUsuario = de_user_modificar_nombre;
                Hide();
                cambio.Show();
            }
            if (de_user_modificar == "user_modificar")
            {
                //Cambiamos de formualario al formulario de Cocodrilo 
                //Y ocultamos el formulario actual
                Cocodrilo cambio = new Cocodrilo();
                //Pasamos el dato para saber que hubo cambio de formulario desde el Login al registro
                cambio.tipoUsuario = "login_user";
                cambio.nombreUsuario = de_user_modificar_nombre;
                Hide();
                cambio.Show();
            }
        }

        private void txtNombre_Click(object sender, EventArgs e)
        {
            //Limpiando los textbox
            txtNombre.Clear();
            txtNombre.Focus();
        }

        private void txtApellido_Click(object sender, EventArgs e)
        {
            //Limpando los textbox
            txtApellido.Clear();
            txtApellido.Focus();
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            //Verificacion de que el nombre del login no este repetido cuando se registra un nuevo usuario
            if (de_administrador_registro == "administrador_registro" || de_login_registro == "login_registro")
            {
                verificarUser();
            }
        }

        private void txtConfirmarContraseña_Leave(object sender, EventArgs e)
        {
            //metodo que verifica que las contraseñas ingresadas sean iguales.
            if (txtContraseña.Text == txtConfirmarContraseña.Text)
            {
                txtCorreo.Focus();
            }
            else
            {
                //Si las contraseñas no son iguales regresara al textbox de la contraseña
                MessageBox.Show("Las Contraseñas no Coinciden", "Advertencia");
                txtConfirmarContraseña.Focus();
            }
        }

        private void dataGridView_Datos_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            //Funcionalidad que me permite pasar los datos de datagridview hacia los respectivos campos de ingreso de datos
            if (de_administrador_modificar == "administrador_modificar" || de_user_modificar == "user_modificar")
            {
                txtUser.Text = dataGridView_Datos.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtNombre.Text = dataGridView_Datos.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtApellido.Text = dataGridView_Datos.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtContraseña.Text = dataGridView_Datos.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtConfirmarContraseña.Text = dataGridView_Datos.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtCorreo.Text = dataGridView_Datos.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtTelefono.Text = dataGridView_Datos.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtPais.Text = dataGridView_Datos.Rows[e.RowIndex].Cells[7].Value.ToString();
                //Creacion de variables locales para la presentacion de los datos cuando se selecciona en el datagridview
                string cadena;
                //Eliminando los espacion en blanco de la cadena obtenida del listbox seleccionado
                cadena = dataGridView_Datos.Rows[e.RowIndex].Cells[8].Value.ToString().Replace("/", "");
                comboBoxDia.Text = cadena.Remove(2, 6);
                comboBoxMes.Text = cadena.Remove(0, 2).Remove(2,4);
                comboBoxAño.Text = cadena.Remove(0, 4);
                comboBoxSexo.Text = dataGridView_Datos.Rows[e.RowIndex].Cells[9].Value.ToString();
                txtID.Text = dataGridView_Datos.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
            else
            {
                limpiar();
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Funcionalidad que me permite solo el ingreso solo de numeros
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Funcionalidad que me permite solo el ingreso solo de letras
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                txtNombre.Focus();
                return;
            }
        }

        private void txtPais_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Funcionalidad que me permite solo el ingreso solo de letras
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                txtPais.Focus();
                return;
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Funcionalidad que me permite solo el ingreso solo de letras
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                txtApellido.Focus();
                return;
            }
        }
    }
}