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
            Console.WriteLine("Práctica 12:\n\n");

            Osciloscopio osciloscopio = new Osciloscopio();
            osciloscopio.PrintInfo();

            Antena antena = new Antena();
            antena.PrintInfo();

            CircuitoElectrico circuitoElectrico = new CircuitoElectrico();
            circuitoElectrico.PrintInfo();

            Voltimetro voltimetro = new Voltimetro();
            voltimetro.PrintInfo();

            Amperimetro amperimetro = new Amperimetro();
            amperimetro.PrintInfo();

            Router router = new Router();
            router.PrintInfo();

            Microcontrolador microcontrolador = new Microcontrolador();
            microcontrolador.PrintInfo();

            Microprocesador microprocesador = new Microprocesador();
            microprocesador.PrintInfo();

            CableCoaxial cableCoaxial = new CableCoaxial();
            cableCoaxial.PrintInfo();

            Diodo diodo = new Diodo();
            diodo.PrintInfo();

            System.Diagnostics.Process.Start("WFcruzlara_signature.exe");

            // Makes the program wait for a key press and it prevents the screen until a key is pressed.
            Console.ReadKey();
        }
    }
}
