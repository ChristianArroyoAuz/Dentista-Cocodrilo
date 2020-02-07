// ******************************************************************************************
// Arroyo Auz Christian Xavier.                                                             *
// 11/08/2016.                                                                              *
// ******************************************************************************************


using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System;

namespace Servidor.Base_de_Datos
{
    //Para enviar los datos sin necesidad de de convertirlo
    [Serializable]
    //Para agregar y conseguir el nombre de la tabla que se usara en las consultas
    [Table(Name = "Usuarios")]
    public class Usuarios
    {
        //Agregando los atributos de las las columnas de las tablas, LoginUser se  le asignara como clave primaria para
        //evitar repeticiones de usarios al momento del Login
        [Column]
        public int Id;

        [Column(IsPrimaryKey = true)]
        public String LoginUser;

        [Column]
        public String Nombre;

        [Column]
        public String Apellido;

        [Column]
        public String Contraseña;

        [Column]
        public String eMail;

        [Column]
        public int Telefono;

        [Column]
        public String Pais;

        [Column]
        public String Fecha;

        [Column]
        public String Sexo;

        //Constructor vacio que no recibe parametros
        public Usuarios()
        {
        }

        //Constructor recibe solo los parametros de Login
        public Usuarios(String ini_loginuser)
        {
            //Igualando las variables locales a las variables recibidas
            LoginUser = ini_loginuser;
        }

        //Constructor recibe solo los parametros de Login y Contraseña
        public Usuarios(String ini_loginuser, String ini_contraseña)
        {
            //Igualando las variables locales a las variables recibidas
            LoginUser = ini_loginuser;
            Contraseña = ini_contraseña;
        }
        
        //Constructor que recibe los parametrso de las consultas
        public Usuarios(int ini_id, String ini_loginuser, String ini_nombre, String ini_apellido, String ini_contraseña,
                        String ini_email, int ini_telefono, String ini_pais, String ini_fecha, String ini_sexo)
        {
            //Igualando las variables locales a las variables recibidas
            Id = ini_id;
            LoginUser = ini_loginuser;
            Nombre = ini_nombre;
            Apellido = ini_apellido;
            Contraseña = ini_contraseña;
            eMail = ini_email;
            Telefono = ini_telefono;
            Pais = ini_pais;
            Fecha = ini_fecha;
            Sexo = ini_sexo;
        }

        //Parametros que me devuelve el constructor para presentarlos al usuario
        public override string ToString()
        {
            return Id + Nombre + Apellido + Contraseña + eMail + Telefono + Pais + Fecha + Sexo;
        }
    }
}