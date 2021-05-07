using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea2._2
{
    class CobrarEmO
    {
        public double cobrar(int numprecio, int numhora)
        {
            int Salario = numprecio * numhora;

            double SalarioBono = Salario * 0.10;

            Double SalarioNeto = SalarioBono + Salario;

            return SalarioNeto;
        }
    }
}
