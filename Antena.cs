using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAcruzlara
{
    internal class Antena
    {
        private readonly string description = "Una antena es un dispositivo normalmente conductor metálico, diseñado con el objetivo de emitir y/o recibir ondas electromagnéticas hacia el espacio libre. Una antena transmisora transforma energía eléctrica en ondas electromagnéticas, y una receptora realiza la función inversa.";
        public void PrintInfo()
        {
            Console.WriteLine("2. Antenas:");
            Console.WriteLine(description);
            Console.WriteLine("\n");
        }
    }
}
