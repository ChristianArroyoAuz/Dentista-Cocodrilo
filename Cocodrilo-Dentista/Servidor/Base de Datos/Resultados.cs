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
    [Table(Name = "Resultados")]
    public class Resultados
    {
        [Column(IsPrimaryKey = true)]
        public string LoginUser;

        [Column]
        public int Vidas;

        [Column]
        public int Diente;

        [Column]
        public string Gano_Perdio;

        public Resultados()
        {
        }

        public Resultados(string ini_Loginuser, int ini_Vidas,int ini_Diente, string ini_Gano_Perdio)
        {
            LoginUser = ini_Loginuser;
            Vidas = ini_Vidas;
            Diente = ini_Diente;
            Gano_Perdio = ini_Gano_Perdio;
        }

        public override string ToString()
        {
            return LoginUser + Vidas + Diente + Gano_Perdio;
        }
    }
}