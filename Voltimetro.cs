using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAcruzlara
{
    internal class Voltimetro
    {
        private readonly string description = "El voltímetro es un instrumento diseñado para hacer estimaciones en voltios. Se tratan de instrumentos que se colocan en paralelo, razón por la cual la resistencia eléctrica del mismo tiene que ser muy alta.";
        public void PrintInfo()
        {
            Console.WriteLine("4. Voltímetro:");
            Console.WriteLine(description);
            Console.WriteLine("\n");
        }
    }
}
