using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller1Herencia
{
    public class Factorial : Calculo
    {

        public long calcularFactorial()
        {
            long factorial = 1;
            long numero = this.getNumeroIngresado();

            for (long i = 1; i <= numero; i++)
            {
                factorial = factorial * i;
            }
            return factorial;
        }
    }
}