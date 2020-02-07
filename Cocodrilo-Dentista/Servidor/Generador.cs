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
    public class Generador
    {
        //Lista de los 24 numero generados, un elemento por cada diente
        public List<String> numerosAgregar = new List<String>();

        public void GeneradorNumeros()
        {
            //Generador randomico de 24 elementos para los dientes
            int cantidad = 24;
            int[] numeros = new int[cantidad];
            Random r = new Random();
            for (int i = 1; i < cantidad; i++)
            {
                //Se genera un numero aleatorio ente el 1 y el 6 para cada diente
                numeros[i] = r.Next(1, 6);
                numerosAgregar.Add((numeros[i - 1] + 1).ToString());
            }
        }
    }
}