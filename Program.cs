using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAcruzlara
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Práctica 13\n");

            CargasElectricas carga = new CargasElectricas();
            carga.Calcular_Fuerza();

            System.Diagnostics.Process.Start("WFcruzlara_signature.exe");

            // Makes the program wait for a key press and it prevents the screen until a key is pressed.
            Console.ReadKey();
        }
    }
}
