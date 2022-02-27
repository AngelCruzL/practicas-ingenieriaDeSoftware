using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAcruzlara
{
    internal class CargasElectricas
    {
        private static readonly double CargaElectron = (-1.6) * Math.Pow(10, -19);
        private readonly double Epsilon = 8.85 * Math.Pow(10, -12);
        private readonly double Radio = Math.Pow(10, -2);
        private readonly double Carga_1 = Math.Pow(10, 5) * CargaElectron;
        private readonly double Carga_2 = Math.Pow(10, 4) * CargaElectron;
        private double k;
        public double Fuerza;

        private void Calcular_k()
        {
            this.k = 1 / (4 * Math.PI * this.Epsilon);
        }

        public void Calcular_Fuerza()
        {
            this.Calcular_k();
            this.Fuerza = (this.k * this.Carga_1 * this.Carga_2) / Math.Pow(this.Radio, 2);
            Console.WriteLine("La fuerza total es: {0}", Fuerza);
        }
    }
}
