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
            Console.WriteLine($"Tipo int32: tamaño: {sizeof(Int32)},\t\tRango[{Int32.MinValue},\t\t{Int32.MaxValue}]");
            Console.WriteLine($"Tipo int64: tamaño: {sizeof(Int64)},\t\tRango[{Int64.MinValue},\t{Int64.MaxValue}]");
            Console.WriteLine($"Tipo UInt16: tamaño: {sizeof(UInt16)},\t\tRango[{UInt16.MinValue},\t\t\t{UInt16.MaxValue}]");
            Console.WriteLine($"Tipo UInt32: tamaño: {sizeof(UInt32)},\t\tRango[{UInt32.MinValue},\t\t\t{UInt32.MaxValue}]");
            Console.WriteLine($"Tipo UInt64: tamaño: {sizeof(UInt64)},\t\tRango[{UInt64.MinValue},\t\t\t{UInt64.MaxValue}]");
            Console.WriteLine($"Tipo float: tamaño: {sizeof(float)},\t\tRango[{float.MinValue},\t\t{float.MaxValue}]");
            Console.WriteLine($"Tipo double: tamaño: {sizeof(double)},\t\tRango[{double.MinValue},\t{double.MaxValue}]");
            Console.WriteLine($"Tipo Decimal: tamaño: {sizeof(Decimal)},\tRango[{Decimal.MinValue},\t\t\t{Decimal.MaxValue}]");
            Console.WriteLine($"Tipo SByte: tamaño: {sizeof(SByte)},\t\tRango[{SByte.MinValue},\t\t\t{SByte.MaxValue}]");
            Console.WriteLine($"Tipo Byte: tamaño: {sizeof(Byte)},\t\tRango[{Byte.MinValue},\t\t\t{Byte.MaxValue}]");

            System.Diagnostics.Process.Start("WFcruzlara_signature.exe");

            // Makes the program wait for a key press and it prevents the screen until a key is pressed.
            Console.ReadKey();
        }
    }
}
