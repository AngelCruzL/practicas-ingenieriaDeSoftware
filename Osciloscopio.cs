using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAcruzlara
{
    internal class Osciloscopio
    {
        private readonly string description = "Un osciloscopio es un instrumento de medición para la electrónica. Representa una gráfica de amplitud en el eje vertical y tiempo en el eje horizontal. Es muy usado por estudiantes, diseñadores, ingenieros en el campo de la electrónica.";
        public void PrintInfo()
        {
            Console.WriteLine("1. Osciloscopio:");
            Console.WriteLine(description);
            Console.WriteLine("\n");
        }
    }
}
