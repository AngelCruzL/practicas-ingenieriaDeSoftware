using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAcruzlara
{
    internal class CableCoaxial
    {
        private readonly string description = "El cable coaxial es un cable utilizado para transportar señales eléctricas de alta frecuencia que posee dos conductores concéntricos, uno central, llamado núcleo, encargado de llevar la información, y uno exterior, de aspecto tubular, llamado malla, blindaje o trenza, que sirve como referencia de tierra y retorno de las corrientes.";
        public void PrintInfo()
        {
            Console.WriteLine("9. Cable coaxial:");
            Console.WriteLine(description);
            Console.WriteLine("\n");
        }
    }
}
