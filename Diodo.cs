using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAcruzlara
{
    internal class Diodo
    {
        private readonly string description = "Un diodo es un dispositivo semiconductor que actúa esencialmente como un interruptor unidireccional para la corriente. Permite que la corriente fluya en una dirección, pero no permite a la corriente fluir en la dirección opuesta.";
        public void PrintInfo()
        {
            Console.WriteLine("10. Diodo:");
            Console.WriteLine(description);
            Console.WriteLine("\n");
        }
    }
}
