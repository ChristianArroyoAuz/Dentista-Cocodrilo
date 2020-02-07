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
    [Table(Name = "Juegos")]
    public class Juegos
    {
        [Column(IsPrimaryKey = true)]
        public int Id_juego;

        [Column]
        public int Id_Cliente;

        [Column]
        public String LoginUser;

        [Column]
        public int Numero_Juegos;

        [Column]
        public int Juegos_Ganados;

        [Column]
        public int Juegos_Empatados;

        [Column]
        public int JuegosPerdidos;

        [Column]
        public int Aciertos_Totales;

        [Column]
        public int Errores_Totales;

        public Juegos()
        {
        }

        //Constructor que recibe los parametrso de las consultas
        public Juegos(int ini_Id_juego, int ini_Id_Cliente, String ini_LoginUser, int ini_Numero_Juegos, 
                      int ini_Juegos_Ganados, int ini_Juegos_Empatados, int ini_JuegosPerdidos,
                      int ini_Aciertos_Totales, int ini_Errores_Totales)
        {
            //Igualando las variables locales a las variables recibidas
            Id_juego = ini_Id_juego;
            Id_Cliente = ini_Id_Cliente;
            LoginUser = ini_LoginUser;
            Numero_Juegos = ini_Numero_Juegos;
            Juegos_Ganados = ini_Juegos_Ganados;
            Juegos_Empatados = ini_Juegos_Empatados;
            JuegosPerdidos = ini_JuegosPerdidos;
            Aciertos_Totales = ini_Aciertos_Totales;
            Errores_Totales = ini_Errores_Totales;
        }

        //Parametros que me devuelve el constructor para presentarlos al usuario
        public override string ToString()
        {
            return Id_juego + Id_Cliente + LoginUser + Numero_Juegos + Juegos_Ganados +
                   Juegos_Empatados + JuegosPerdidos + Aciertos_Totales + Errores_Totales;
        }
    }
}