using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea2._2
{
    class EmpleadoG:Empleados,Ifabrica
    {
        
        public void crear(List<EmpleadoAdm> listaadm, List<EmpleadoG> ListaEmpG, List<Empleado_Ope> listaEmpO)
        {
            EmpleadoG EmpG1 = new EmpleadoG();
            int num = 1000;
            Random aleatorio = new Random();
            num = aleatorio.Next(1000, 9000);


            Console.WriteLine("Digite su cedula: ");
            EmpG1.cedula = Console.ReadLine();
            Console.WriteLine("Digite Su nombre: ");
            EmpG1.nombre = Console.ReadLine();
            Console.WriteLine("Digite su apellido: ");
            EmpG1.apellido = Console.ReadLine();
            Console.WriteLine("Digite su correo electronico: ");
            EmpG1.email = Console.ReadLine();
            Console.WriteLine("Digite su numero telofonico: ");
            EmpG1.tel = long.Parse(Console.ReadLine());
            Console.WriteLine("Digite el departamento: ");
            EmpG1.depa = Console.ReadLine();
            Console.WriteLine("Digite su cargo: ");
            EmpG1.cargo = Console.ReadLine();
            Console.WriteLine("Digite Cuanto gana por hora: ");
            EmpG1.Precio_hora = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite Cuanta horas usted trabaja: ");
            EmpG1.horas_trabajo = int.Parse(Console.ReadLine());

            EmpG1.codigo = EmpG1.depa.Substring(0, 3) + num;

            SGerente generav = SGerente.GetSgenerar(EmpG1.cedula,EmpG1.codigo, EmpG1.nombre, EmpG1.apellido, EmpG1.email, EmpG1.tel, EmpG1.depa, EmpG1.cargo, EmpG1.Precio_hora, EmpG1.horas_trabajo);
            ListaEmpG.Add(EmpG1);

            Console.WriteLine("Empleado Agregado con exito!");
            Console.WriteLine("Presione Enter para volver al menu");
            Console.ReadKey();
        }

        public void ver(List<EmpleadoAdm> Adm, List<EmpleadoG> EmG, List<Empleado_Ope> EmpOpe)
        {

            Console.Clear();
            Console.WriteLine("Empleado Generencial");
            Console.WriteLine();


            foreach (var dato in EmG)
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
            CobrarG EmG1 = new CobrarG();

            Console.WriteLine("Empleado Gerencial Activo");

            foreach (var dato in EmG)
            {

                salario_neto = EmG1.cobrar(dato.Precio_hora, dato.horas_trabajo);
                Console.WriteLine("###################################################");
                Console.WriteLine($"Codigo: {dato.codigo} ");
                Console.WriteLine("######################################");
                Console.WriteLine($"Cedula: {dato.cedula}");
                Console.WriteLine("######################################");
                Console.WriteLine($"Nombre: {dato.nombre}");
                Console.WriteLine("######################################");
                Console.WriteLine($"Apellido: {dato.apellido}");
                Console.WriteLine("######################################");
                Console.WriteLine($"Bonos$: Gerencial + 50% ");
                Console.WriteLine("######################################");
                Console.WriteLine($"Salario Neto: {salario_neto}");
                Console.ReadKey();

            }

        }

        public void pago(List<EmpleadoAdm> Adm, List<EmpleadoG> EmG, List<Empleado_Ope> EmpOpe)
        {
            CobrarG EmG1 = new CobrarG();

            Console.WriteLine("Empleado Gerencial Activo");

            foreach (var dato in EmG)
            {

                salario_neto = EmG1.cobrar(dato.Precio_hora, dato.horas_trabajo);
                Console.WriteLine("###################################################");
                Console.WriteLine($"Codigo: {dato.codigo} ");
                Console.WriteLine("######################################");
                Console.WriteLine($"Nombre: {dato.nombre}");
                Console.WriteLine("######################################");
                Console.WriteLine($"Categoria: Gerencial");
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
