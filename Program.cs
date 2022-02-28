using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace CAcruzlara
{
    internal class Program
    {
        static int a;

        static void Main(string[] args)
        {
            bool b;
            int x;
            float y;
            double u;
            decimal v;
            char c;
            string s;
            Complex z, w;

            a = 20;
            x = 20;
            a = (int)10.5;                  // Parsea 10.5 (double) a 10 (int)
            a = Convert.ToInt16(a);
            a = Convert.ToInt16(4.5);

            y = 30;                         // Conversión implicita
            u = 40;

            y = 36.5F;
            u = 6.6;
            u = -1.6E-19;
            v = 1687593454654564;

            c = '1';
            s = "ESIME";
            s = "123";
            x = int.Parse(s);
            x = int.Parse("123");
            u = double.Parse("123");
            u = Math.Cos(6.0);

            b = true;
            b = false;

            z = new Complex(5.0, 7.0);
            w = new Complex(z.Real, z.Imaginary);
            w = z;

            Console.WriteLine("a: {0}",a);
            Console.WriteLine("b: {0}",b);
            Console.WriteLine("x: {0}",x);
            Console.WriteLine("y: {0}",y);
            Console.WriteLine("u: {0}",u);
            Console.WriteLine("v: {0}",v);
            Console.WriteLine("c: {0}",c);
            Console.WriteLine("s: {0}",s);
            Console.WriteLine("z: {0}",z);
            Console.WriteLine("w: {0}",w);


            System.Diagnostics.Process.Start("WFcruzlara_signature.exe");

            // Makes the program wait for a key press and it prevents the screen until a key is pressed.
            Console.ReadKey();
        }
    }
}
