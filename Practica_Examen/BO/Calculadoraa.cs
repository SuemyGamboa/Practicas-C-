using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Examen.BO
{
    internal class Calculadoraa
    {
        //atributos
        private double Monto1;
        private double Monto2;
        private double Monto3;
        private double Monto4;
        private double Monto5;
        private double Monto6;
        private double total;
        private double descuento;


        //constructor
        public Calculadoraa (double m1, double m2, double m3, double m4, double m5, double m6)
        {
           this.Monto1 = m1;
            this.Monto2 = m2;
            this.Monto3 = m3;
            this.Monto4 = m4;
            this.Monto5 = m5;
            this.Monto6 = m6;

        }


        //metodo
        public double Calculo_total()
        {
            total = Monto1 + Monto2 + Monto3 + Monto4 + Monto5 + Monto6;
            return total;

        }
        public double Calculo_Descuento()
        {
            descuento = (total * .2);
            return descuento;
        }

    }
}
