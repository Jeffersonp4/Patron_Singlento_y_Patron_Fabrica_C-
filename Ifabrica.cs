using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea2._2
{
    interface Ifabrica
    {
        void crear(List<EmpleadoAdm> Adm, List<EmpleadoG> EmG, List<Empleado_Ope> EmpOpe);

        void ver(List<EmpleadoAdm> Adm, List<EmpleadoG> EmG, List<Empleado_Ope> EmpOpe);

        void cobrar(List<EmpleadoAdm> Adm, List<EmpleadoG> EmG, List<Empleado_Ope> EmpOpe);

        void pago(List<EmpleadoAdm> Adm, List<EmpleadoG> EmG, List<Empleado_Ope> EmpOpe);
    }
}
