using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAcruzlara
{
    internal class Microcontrolador
    {
        private readonly string description = "Un microcontrolador es un circuito integrado programable, capaz de ejecutar las rdenes grabadas en su memoria. Est compuesto de varios bloques funcionales que cumplen una tarea especfica.";
        public void PrintInfo()
        {
            Console.WriteLine("7. Microcontrolador:");
            Console.WriteLine(description);
            Console.WriteLine("\n");
        }
    }
}
