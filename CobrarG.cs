using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea2._2
{
    class CobrarG
    {
        public double cobrar(int numprecio, int numhora)
        {
            int Salario = numprecio * numhora;

            double SalarioBono = Salario * 0.5;

            Double SalarioNeto = SalarioBono + Salario;

            return SalarioNeto;
        }
    }
}
