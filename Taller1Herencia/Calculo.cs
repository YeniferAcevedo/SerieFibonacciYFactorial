using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller1Herencia
{
    public class Calculo
    {
        private long numeroIngresado;


        public void setNumeroIngresado(long valor)
        {
            this.numeroIngresado = valor;
        }

        public long getNumeroIngresado()
        {
            return this.numeroIngresado;
        }

    }
}