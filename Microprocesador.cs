using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAcruzlara
{
    internal class Microprocesador
    {
        private readonly string description = "El microprocesador es el circuito integrado central más complejo de un sistema informático; a modo de ilustración, se le suele llamar por analogía el «cerebro» de un ordenador. ​";
        public void PrintInfo()
        {
            Console.WriteLine("8. Microprocesador:");
            Console.WriteLine(description);
            Console.WriteLine("\n");
        }
    }
}
