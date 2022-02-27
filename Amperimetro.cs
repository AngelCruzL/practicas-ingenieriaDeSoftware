using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAcruzlara
{
    internal class Amperimetro
    {
        private readonly string description = "Un amperímetro es un instrumento para detectar pequeñas cantidades de corriente. Con una resistencia en paralelo, llamada \"resistencia shunt\". El amperímetro se utiliza para medir la intensidad de las corrientes eléctricas.";
        public void PrintInfo()
        {
            Console.WriteLine("5. Amperímetro:");
            Console.WriteLine(description);
            Console.WriteLine("\n");
        }
    }
}
