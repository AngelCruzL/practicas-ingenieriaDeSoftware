using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAcruzlara
{
    internal class Router
    {
        private readonly string description = "Un router es un dispositivo de red que se encarga de llevar por la ruta adecuada el tráfico.";
        public void PrintInfo()
        {
            Console.WriteLine("6. Router:");
            Console.WriteLine(description);
            Console.WriteLine("\n");
        }
    }
}
