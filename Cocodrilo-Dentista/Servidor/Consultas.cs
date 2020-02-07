// ******************************************************************************************
// Arroyo Auz Christian Xavier.                                                             *
// 11/08/2016.                                                                              *
// ******************************************************************************************


using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System.Text;
using System;

namespace Servidor
{
    //Permite el acceso a objetos a través de los límites del dominio de aplicación en las aplicaciones que admiten la comunicación remota.
    public class Consultas
    {
        //Haciendo referencia a la clase miDB donde se halla la cadena de conexion a la base de datos
        public Base_de_Datos.miDB baseDatos = new Base_de_Datos.miDB();
        //Creando una lista de usuarios para poder pasarla al cliente con los datos obtenidos
        public List<Base_de_Datos.Usuarios> mostrarLista = new List<Base_de_Datos.Usuarios>();
        public List<Base_de_Datos.Resultados> mostrarrRsultados = new List<Base_de_Datos.Resultados>();
        //creando una lista de juegos para poder pasarla al cliente con los datos obtenidos
        public List<Base_de_Datos.Juegos> mostrarJuegos = new List<Base_de_Datos.Juegos>();
        //Variabls globales que me permiten recibir los parametros para las distintas busquedas
        public int idenfificadorUsuario;
        public String nomrbre;
        public String apellido;
        public String usuario;
        public String contraseña;
        public String correo;
        public int telefono;
        public String pais;
        public String dia;
        public String mes;
        public String año;
        public String sexo;

        public int VidasTotales;
        public int DienteTotal;
        public String GanoPerdio;
        

        //Metodo de busqueda para el logueo del cliente, si exisen en la tabla el cliente se logueara
        public void consultaDatos(List<Base_de_Datos.Usuarios> listaUsuarios)
        {
            //Buscando los datos en la tabla usuarios con el nombre del Login y el password
            var consultaUsuario = from Usuarios in this.baseDatos.Usuarios
                                  where Usuarios.LoginUser == usuario
                                  where Usuarios.Contraseña == contraseña
                                  select new
                                  {
                                      USUARIO = (String)Usuarios.LoginUser,
                                      CONTRASEÑA = (String)Usuarios.Contraseña
                                  };
            //Recorriendo la lista obtenida
            foreach (var usu in consultaUsuario)
            {
                //Agregando los datos a la lista global para pasrlos al cliente
                Base_de_Datos.Usuarios nuevo = new Base_de_Datos.Usuarios(usu.USUARIO, usu.CONTRASEÑA);
                listaUsuarios.Add(nuevo);
                if (listaUsuarios.Count > 0)
                {
                    //Si existen datos se pasara la lista con los datos
                    mostrarLista = listaUsuarios;
                }
                else
                {
                    //Si no existen los datos se pasara la lista vacia al cliente, lo que significa que no podra loguearse
                    mostrarLista.Clear();
                }
            }
        }

        //Metodo para agregar nuevos usuarios a la base de datos
        public void agregarDatos()
        {
            //Creamos un nuevo usuari para gregar a la base de datos con los parametros recibidos del cliente
            Base_de_Datos.Usuarios nuevo = new Base_de_Datos.Usuarios();
            nuevo.Id = idenfificadorUsuario;
            nuevo.Nombre = nomrbre;
            nuevo.Apellido = apellido;
            nuevo.LoginUser = usuario;
            nuevo.Contraseña = contraseña;
            nuevo.eMail = correo;
            nuevo.Telefono = telefono;
            nuevo.Pais = pais;
            nuevo.Fecha = dia + "/" + mes + "/" + año;
            nuevo.Sexo = sexo;
            //Ingresamo los datos a la tabla de usuarios
            baseDatos.Usuarios.InsertOnSubmit(nuevo);
            //Actualizamos la tabla con los nuevos datos ingresados
            baseDatos.SubmitChanges();
            //Creamos un nuevo usuario en la tabla de juegos
            Base_de_Datos.Juegos nuevoJuego = new Base_de_Datos.Juegos();
            nuevoJuego.Id_juego = idenfificadorUsuario;
            nuevoJuego.Id_Cliente = idenfificadorUsuario;
            nuevoJuego.LoginUser = nomrbre;
            nuevoJuego.Numero_Juegos = 0;
            nuevoJuego.Juegos_Ganados = 0;
            nuevoJuego.Juegos_Empatados = 0;
            nuevoJuego.JuegosPerdidos = 0;
            nuevoJuego.Aciertos_Totales = 0;
            nuevoJuego.Errores_Totales = 0;
            //Ingresamos los datos a la base de datos
            baseDatos.Juegos.InsertOnSubmit(nuevoJuego);
            //Actualizamos la tabla de juegos
            baseDatos.SubmitChanges();
        }

        //metodo para actualiza un usuario en la base de datos
        public void modificarDatos()
        {
            baseDatos.ExecuteCommand("Update Usuarios set LoginUser =" + "'" + usuario + "'" + "where Id =" + Convert.ToString(idenfificadorUsuario) + ";");
            baseDatos.ExecuteCommand("Update Usuarios set Nombre =" + "'" + nomrbre+ "'" + "where Id =" + Convert.ToString(idenfificadorUsuario) + ";");
            baseDatos.ExecuteCommand("Update Usuarios set Apellido =" + "'" + apellido + "'" + "where Id =" + Convert.ToString(idenfificadorUsuario) + ";");
            baseDatos.ExecuteCommand("Update Usuarios set Contraseña =" + "'" + contraseña + "'" + "where Id =" + Convert.ToString(idenfificadorUsuario) + ";");
            baseDatos.ExecuteCommand("Update Usuarios set eMail =" + "'" + correo + "'" + "where Id =" + Convert.ToString(idenfificadorUsuario) + ";");
            baseDatos.ExecuteCommand("Update Usuarios set Telefono =" + "'" + Convert.ToInt32(telefono) + "'" + "where Id =" + Convert.ToString(idenfificadorUsuario) + ";");
            baseDatos.ExecuteCommand("Update Usuarios set Pais =" + "'" + pais + "'" + "where Id =" + Convert.ToString(idenfificadorUsuario) + ";");
            baseDatos.ExecuteCommand("Update Usuarios set Fecha =" + "'" + dia + "/" + mes + "/" + año + "'" + "where Id =" + Convert.ToString(idenfificadorUsuario) + ";");
            baseDatos.ExecuteCommand("Update Usuarios set Sexo =" + "'" + sexo + "'" + "where Id =" + Convert.ToString(idenfificadorUsuario) + ";");
            baseDatos.SubmitChanges();
        }

        //Metodo que me permite eliminar a un usuario especifico
        public void elminarDatos(List<Base_de_Datos.Usuarios> listaUsuarios)
        {
            //Borrando a un usuario con el id especificado
            baseDatos.ExecuteCommand("Delete from Usuarios where Id = " + Convert.ToString(idenfificadorUsuario) + ";");
            baseDatos.ExecuteCommand("Delete from Juegos where Id_Juego = " + Convert.ToString(idenfificadorUsuario) + ";");
            baseDatos.SubmitChanges();
        }

        //Metodo que me permite mostrar los Datos de los juegos de los Usuarios
        public void mostrarJuegosUsuarios(List<Base_de_Datos.Juegos> listaJuegos)
        {
            //Realizamos la consulta a la base de datos para obtener los datos sobre los juegos realizados
            var consultaDatos = from Juegos in this.baseDatos.Juegos
                                where Juegos.LoginUser == usuario
                                orderby Juegos.Id_juego ascending
                                select new
                                {
                                    ID_JUEGO= Juegos.Id_juego,
                                    ID_CLIENTE = Juegos.Id_Cliente,
                                    LOGINUSER = Juegos.LoginUser,
                                    NUMERO_JUEGOS = Juegos.Numero_Juegos,
                                    JUEGOS_GANADOS = Juegos.Juegos_Ganados,
                                    JUEGOS_EMPATADOS = Juegos.Juegos_Empatados,
                                    JUEGOS_PERDIDOS = Juegos.JuegosPerdidos,
                                    ACIERTOS_TOTALES = Juegos.Aciertos_Totales,
                                    ERRORES_TOTALES = Juegos.Errores_Totales
                                };
            //Recorriendo la lista obtenida
            foreach (var usu in consultaDatos)
            {
                //Agregando los datos a la lista global para pasrlos al cliente
                Base_de_Datos.Juegos nuevoJuego = new Base_de_Datos.Juegos(usu.ID_JUEGO, usu.ID_CLIENTE, usu.LOGINUSER, usu.NUMERO_JUEGOS,
                                                                           usu.JUEGOS_GANADOS, usu.JUEGOS_EMPATADOS, usu.JUEGOS_PERDIDOS,
                                                                           usu.ACIERTOS_TOTALES, usu.ERRORES_TOTALES);
                listaJuegos.Add(nuevoJuego);
                if (listaJuegos.Count > 0)
                {
                    //Si existen datos se pasara la lista con los datos
                    mostrarJuegos = listaJuegos;
                }
                else
                {
                    //Si no existen los datos se pasara la lista vacia al cliente, lo que significa que no podra loguearse
                    mostrarJuegos.Clear();
                }
            }
        }

        //Metodo que me permite presentar los datos de la tabla segun el login del Usuario
        public void mostrarDatosUsuario(List<Base_de_Datos.Usuarios> listaUsuarios)
        {
            var consultaDatos = from Usuarios in this.baseDatos.Usuarios
                                where Usuarios.LoginUser == usuario
                                orderby Usuarios.Id ascending
                                select new
                                {
                                    ID = Usuarios.Id,
                                    LOGIN = Usuarios.LoginUser,
                                    NOMBRE = Usuarios.Nombre,
                                    APELLIDO = Usuarios.Apellido,
                                    CONTRASEÑA = Usuarios.Contraseña,
                                    EMAIL = Usuarios.eMail,
                                    TELEFONO = Usuarios.Telefono,
                                    PAIS = Usuarios.Pais,
                                    FECHA = Usuarios.Fecha,
                                    SEXO = Usuarios.Sexo
                                };
            //Recorriendo la lista obtenida
            foreach (var usu in consultaDatos)
            {
                //Agregando los datos a la lista global para pasrlos al cliente
                Base_de_Datos.Usuarios nuevo = new Base_de_Datos.Usuarios(usu.ID, usu.LOGIN, usu.NOMBRE,
                                                                          usu.APELLIDO, usu.CONTRASEÑA, usu.EMAIL,
                                                                          usu.TELEFONO, usu.PAIS, usu.FECHA, usu.SEXO);
                listaUsuarios.Add(nuevo);
                if (listaUsuarios.Count > 0)
                {
                    //Si existen datos se pasara la lista con los datos
                    mostrarLista = listaUsuarios;
                }
                else
                {
                    //Si no existen los datos se pasara la lista vacia al cliente, lo que significa que no podra loguearse
                    mostrarLista.Clear();
                }
            }
        }

        //Metodo que me permite mostrar todos los datos de la tabla, cuyo id sea mayor a 1, solo accesible para el administardor
        public void mostrarTodosLosDatos(List<Base_de_Datos.Usuarios> listaUsuarios)
        {
            var consultaDatos = from Usuarios in this.baseDatos.Usuarios
                                where Usuarios.Id > 0
                                orderby Usuarios.Id ascending
                                select new
                                {
                                    ID = Usuarios.Id,
                                    LOGIN = Usuarios.LoginUser,
                                    NOMBRE = Usuarios.Nombre,
                                    APELLIDO = Usuarios.Apellido,
                                    CONTRASEÑA = Usuarios.Contraseña,
                                    EMAIL = Usuarios.eMail,
                                    TELEFONO = Usuarios.Telefono,
                                    PAIS = Usuarios.Pais,
                                    FECHA = Usuarios.Fecha,
                                    SEXO = Usuarios.Sexo
                                };
            //Recorriendo la lista obtenida
            foreach (var usu in consultaDatos)
            {
                //Agregando los datos a la lista global para pasrlos al cliente
                Base_de_Datos.Usuarios nuevo = new Base_de_Datos.Usuarios(usu.ID, usu.LOGIN, usu.NOMBRE,
                                                                          usu.APELLIDO, usu.CONTRASEÑA, usu.EMAIL,
                                                                          usu.TELEFONO, usu.PAIS, usu.FECHA, usu.SEXO);
                listaUsuarios.Add(nuevo);
                if (listaUsuarios.Count > 0)
                {
                    //Si existen datos se pasara la lista con los datos
                    mostrarLista = listaUsuarios;
                }
                else
                {
                    //Si no existen los datos se pasara la lista vacia al cliente, lo que significa que no podra loguearse
                    mostrarLista.Clear();
                }
            }
        }

        //Metodo de busqueda del Login, me permite saber si existe clientes con el mismo Login
        public void verificarUser(List<Base_de_Datos.Usuarios> listaUsuarios)
        {
            //Buscando los datos en la tabla usuarios con el nombre del Login
            var consultaUsuario = from Usuarios in this.baseDatos.Usuarios
                                  where Usuarios.LoginUser == usuario
                                  select new
                                  {
                                      USUARIO = (String)Usuarios.LoginUser
                                  };
            foreach (var usu in consultaUsuario)
            {
                //Agregando los datos a la lista global para pasrlos al cliente
                Base_de_Datos.Usuarios nuevo = new Base_de_Datos.Usuarios(usu.USUARIO);
                listaUsuarios.Add(nuevo);
                if (listaUsuarios.Count > 0)
                {
                    //Si existen datos se pasara la lista con los datos
                    mostrarLista = listaUsuarios;
                }
                else
                {
                    //Si no existen los datos se pasara la lista vacia al cliente, lo que significa que no podra loguearse
                    mostrarLista.Clear();
                }
            }
        }

        //metodo de busqueda del id más alto en la base de datos
        public void cargarIdentificador(int id)
        {
            //consulta a la base de datos usando LINQ para obtener el ID mas alto y presentar
            // en el formulario para el ingreso de de datos
            var consulta = (from piezas in this.baseDatos.Usuarios
                            where piezas.Id > 0
                            orderby piezas.Id descending
                            select (int)piezas.Id).Take(1);
            //recorremos la lista para tomar el valor mayor mas 1 y enviarlo al cliente
            foreach (var identificador in consulta)
            {
                id = identificador;
                idenfificadorUsuario = id + 1;
            }
        }

        //Consultamos el nonre de usuario del otoro jugador en la base de datos 
        public void consultaResultados(List<Base_de_Datos.Resultados> jugador)
        {
            var consultaDatos = from Usuarios in this.baseDatos.Resultados
                                where Usuarios.LoginUser != nomrbre
                                select new
                                {
                                    LOGIN_USER = Usuarios.LoginUser,
                                    VIDAS = Usuarios.Vidas,
                                    DIENTE = Usuarios.Diente,
                                    GANO_PERDIO = Usuarios.Gano_Perdio
                                };
            //Recorriendo la lista obtenida
            foreach (var usu in consultaDatos)
            {
                //Agregando los datos a la lista global para pasrlos al cliente
                Base_de_Datos.Resultados nuevo = new Base_de_Datos.Resultados(usu.LOGIN_USER, usu.VIDAS, usu.DIENTE, usu.GANO_PERDIO);
                jugador.Add(nuevo);
                if (jugador.Count > 0)
                {
                    mostrarrRsultados = jugador;
                }
                else
                {
                    mostrarrRsultados.Clear();
                }
            }
        }

        public void actualizarResultados()
        {
            baseDatos.ExecuteCommand("Update Resultados set LoginUser =" + "'" + usuario + "'" + "where LoginUser =" + "'" + usuario + "'"  + ";");
            baseDatos.ExecuteCommand("Update Resultados set Vidas =" + "'" + VidasTotales + "'" + "where LoginUser =" + "'" + usuario + "'" + ";");
            baseDatos.ExecuteCommand("Update Resultados set Diente =" + "'" + DienteTotal + "'" + "where LoginUser =" + "'" + usuario + "'" + ";");
            baseDatos.ExecuteCommand("Update Resultados set Gano_Perdio =" + "'" + GanoPerdio + "'" + "where LoginUser =" + "'" + usuario + "'" + ";");
            baseDatos.SubmitChanges();
        }
    }
}