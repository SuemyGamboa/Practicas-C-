using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Examen
{
    internal class total
    {
        private double Monto1;
        private double Monto2;
        private double Monto3;
        private double Monto4;
        private double Monto5;
        private double Monto6;
        private double total;
        private double descuento;

        public total (double c1, double c2, double c3, double c4, double c5, double c6)
        {   
            M1 = c1;
            M2 = c2;
            M3 = c3;
            M4 = c4;
            M5 = c5;
            M6 = c6;

        }
        public double Cal_PrecioTotal()
        {
            Result = (M1 + M2 + M3 + M4 + M5 + M6);
            return Result;

        }
        public double Cal_Descuento()
        {
            Result2 = (Result * .2);
            return Result2;
        }
    }
}

