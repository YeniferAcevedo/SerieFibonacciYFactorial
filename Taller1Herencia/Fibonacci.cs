using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller1Herencia
{
    public class Fibonacci : Calculo
    {
        public List<long> calcularFibonacci()
        {
            List<long> fibonacci = new List<long>();

            long numero;
            numero = this.getNumeroIngresado();

            long a;
            long b = 1;
            long c = 0;

            for (long i = 0; i <= numero - 1; i++) { 
                
                if (i == 0){

                    fibonacci.Add(i);
                }
                a = b + c;
                b = c;
                c = a;

                fibonacci.Add(a);
            }
            return fibonacci;
        }
    }
}
