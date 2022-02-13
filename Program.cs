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
            int x;

            Greet();

            Class1 obj1 = new Class1();
            obj1.Greet();

            Class2 obj2 = new Class2();
            obj2.Greet();

            x = 9;

            Console.WriteLine("\nEjemplos de interpolación de strings en C#");

            Console.Write("\t$\"x={x}\"\t=\t");
            Console.Write($"x={x}\n");

            Console.Write("\t\"x=\"+x\t\t=\t");
            Console.Write("x=" + x +"\n");

            Console.Write("\t\"x={0}, x\"\t=\t");
            Console.WriteLine("x={0}", x);

            System.Diagnostics.Process.Start("WFcruzlara_signature.exe");

            // Makes the program wait for a key press and it prevents the screen until a key is pressed.
            Console.ReadKey();
        }

        public static void Greet()
        {
            Console.WriteLine("ESIME");
        }
    }
}
