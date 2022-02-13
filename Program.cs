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
            Console.WriteLine($"Tipo int: tamaño: {sizeof(int)},\t\tRango[{int.MinValue},\t\t{int.MaxValue}]");
            Console.WriteLine($"Tipo int16: tamaño: {sizeof(Int16)},\t\tRango[{Int16.MinValue},\t\t\t{Int16.MaxValue}]");
            Console.WriteLine($"Tipo float: tamaño: {sizeof(float)},\t\tRango[{float.MinValue},\t\t{float.MaxValue}]");
            Console.WriteLine($"Tipo double: tamaño: {sizeof(double)},\t\tRango[{double.MinValue},\t{double.MaxValue}]");

            System.Diagnostics.Process.Start("WFcruzlara_signature.exe");

            // Makes the program wait for a key press and it prevents the screen until a key is pressed.
            Console.ReadKey();
        }
    }
}
