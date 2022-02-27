using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAcruzlara
{
    internal class CircuitoElectrico
    {
        private readonly string description = "Un circuito eléctrico es el conjunto de elementos eléctricos conectados entre sí que permiten generar, transportar y utilizar la energía eléctrica con la finalidad de transformarla en otro tipo de energía como, por ejemplo, energía calorífica (estufa), energía lumínica (bombilla) o energía mecánica (motor).";
        public void PrintInfo()
        {
            Console.WriteLine("3. Circuito Eléctrico:");
            Console.WriteLine(description);
            Console.WriteLine("\n");
        }
    }
}
