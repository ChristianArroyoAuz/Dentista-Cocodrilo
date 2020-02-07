using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System.Text;
using System;

namespace Servidor
{
    public class VerificarDatos
    {
        public String recibirDiente;
        public String recibirPeso;
        public String resultado_Ganador_Perdedor;

        public void Ganador_Perdedor()
        {
            if (recibirDiente == recibirPeso)
            {
                resultado_Ganador_Perdedor = "Has Ganado";
            }
            else
            {
                resultado_Ganador_Perdedor = "Has Perdido";
            }
        }
    }
}