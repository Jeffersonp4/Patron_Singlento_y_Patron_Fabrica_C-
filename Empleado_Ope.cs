using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea2._2
{
    class Empleado_Ope:Empleados,Ifabrica
    {
    
        public void crear(List<EmpleadoAdm> listaadm, List<EmpleadoG> ListaEmpG, List<Empleado_Ope> listaEmpO)
        {
            
            Empleado_Ope EmpO = new Empleado_Ope();
            int num = 1000;
            Random aleatorio = new Random();
            num = aleatorio.Next(1000, 9000);

            Console.WriteLine("Digite su cedula: ");
            EmpO.cedula = Console.ReadLine();
            Console.WriteLine("Digite Su nombre: ");
            EmpO.nombre = Console.ReadLine();
            Console.WriteLine("Digite su apellido: ");
            EmpO.apellido = Console.ReadLine();
            Console.WriteLine("Digite su correo electronico: ");
            EmpO.email = Console.ReadLine();
            Console.WriteLine("Digite su numero telofonico: ");
            EmpO.tel = long.Parse(Console.ReadLine());
            Console.WriteLine("Digite el departamento: ");
            EmpO.depa = Console.ReadLine();
            Console.WriteLine("Digite su cargo: ");
            EmpO.cargo = Console.ReadLine();
            Console.WriteLine("Digite Cuanto gana por hora: ");
            EmpO.Precio_hora = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite Cuanta horas usted trabaja: ");
            EmpO.horas_trabajo = int.Parse(Console.ReadLine());

            EmpO.codigo = EmpO.depa.Substring(0, 3) + num;

            listaEmpO.Add(EmpO);

            Console.WriteLine("Empleado Agregado con exito!");
            Console.WriteLine("Presione Enter para volver al menu");
            Console.ReadKey();



        }

        public void ver(List<EmpleadoAdm> Adm, List<EmpleadoG> EmG, List<Empleado_Ope> EmpOpe)
        {

            Console.Clear();
            Console.WriteLine("Empleado Operativo");
            Console.WriteLine();
            


            foreach (var dato in EmpOpe)
            {
                Console.WriteLine("######################################");
                Console.WriteLine($"Codigo: {dato.codigo} ");
                Console.WriteLine("######################################");
                Console.WriteLine($"Cedula: {dato.cedula}");
                Console.WriteLine("######################################");
                Console.WriteLine($"Nombre: {dato.nombre}");
                Console.WriteLine("######################################");
                Console.WriteLine($"Apellido: {dato.apellido}");
                Console.WriteLine("######################################");
                Console.WriteLine($"Email: {dato.email}");
                Console.WriteLine("######################################");
                Console.WriteLine($"TEl: {dato.tel}");
                Console.WriteLine("######################################");
                Console.WriteLine($"Depa: {dato.depa}");
                Console.WriteLine("######################################");
                Console.WriteLine($"Cargo: {dato.cargo}");
                Console.WriteLine("######################################");
                Console.WriteLine($"Precio_Hora: {dato.Precio_hora}");
                Console.WriteLine("######################################");
                Console.WriteLine($"Hora_Trabajo: { dato.horas_trabajo}");
                Console.WriteLine();
            }


            Console.WriteLine("Presione Enter para volver al menu");
            Console.ReadKey();



        }

        public void cobrar(List<EmpleadoAdm> Adm, List<EmpleadoG> EmG, List<Empleado_Ope> EmpOpe)
        {
            CobrarEmO EmO = new CobrarEmO();

            Console.WriteLine("Empleados Operativos Activos");

            foreach (var dato in EmpOpe)
            {

                salario_neto = EmO.cobrar(dato.Precio_hora, dato.horas_trabajo);
                Console.WriteLine("###################################################");
                Console.WriteLine($"Codigo: {dato.codigo} ");
                Console.WriteLine("######################################");
                Console.WriteLine($"Cedula: {dato.cedula}");
                Console.WriteLine("######################################");
                Console.WriteLine($"Nombre: {dato.nombre}");
                Console.WriteLine("######################################");
                Console.WriteLine($"Apellido: {dato.apellido}");
                Console.WriteLine("######################################");
                Console.WriteLine($"Bonos$: Operativo + 10% ");
                Console.WriteLine("######################################");
                Console.WriteLine($"Salario Neto: {salario_neto}");
                Console.ReadKey();

            }

        }

        public void pago(List<EmpleadoAdm> Adm, List<EmpleadoG> EmG, List<Empleado_Ope> EmpOpe)
        {
            CobrarEmO EmO = new CobrarEmO();

            Console.WriteLine("Empleados Operativos Activos");

            foreach (var dato in EmpOpe)
            {

                salario_neto = EmO.cobrar(dato.Precio_hora, dato.horas_trabajo);
                Console.WriteLine("###################################################");
                Console.WriteLine($"Codigo: {dato.codigo} ");
                Console.WriteLine("######################################");
                Console.WriteLine($"Nombre: {dato.nombre}");
                Console.WriteLine("######################################");
                Console.WriteLine($"Categoria: Operativo");
                Console.WriteLine("######################################");
                Console.WriteLine($"Precio x Hora: {dato.Precio_hora}");
                Console.WriteLine("######################################");
                Console.WriteLine($"Horas trabajadas: {dato.horas_trabajo}");
                Console.WriteLine("######################################");
                Console.WriteLine($"Salario Neto: {salario_neto}");
                Console.ReadKey();

            }
        }
    }
}
