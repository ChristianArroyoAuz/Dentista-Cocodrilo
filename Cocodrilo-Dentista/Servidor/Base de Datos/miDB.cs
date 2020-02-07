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
    public class miDB : DataContext
    {
        //Ingresamos la cadena de conexion de la base de datos
        private const String cadenaConexion = @"CADENA DE CONEXIÓN";        
        //Ingresamos las tablas de los Usuarios y de los Juegos
        public Table<Usuarios> Usuarios;
        public Table<Juegos> Juegos;
        public Table<Resultados> Resultados;
        //Instaciamos la cadena de conexion a la base de datos
        public miDB() : base(cadenaConexion) { }
    }
}