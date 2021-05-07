using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea2._2
{
    class CobrarAdm
    {
        public double cobrar(int numprecio, int numhora)
        {

            int Salario = numprecio * numhora;

            double SalarioBono = Salario * 0.25;

            Double SalarioNeto = SalarioBono + Salario;

            return SalarioNeto;
        }
    }
}
