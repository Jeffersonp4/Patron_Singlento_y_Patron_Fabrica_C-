using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea2._2
{
    class EmpleadoAdm:Empleados,Ifabrica
    {

        public void crear(List<EmpleadoAdm> listaadm, List<EmpleadoG> ListaEmpG, List<Empleado_Ope> listaEmpO)
        {
            EmpleadoAdm Adm = new EmpleadoAdm();
            int num = 1000;
            Random aleatorio = new Random();
            num = aleatorio.Next(1000, 9000);

            Console.WriteLine("Digite su cedula: ");
            Adm.cedula = Console.ReadLine();
            Console.WriteLine("Digite Su nombre: ");
            Adm.nombre = Console.ReadLine();
            Console.WriteLine("Digite su apellido: ");
            Adm.apellido = Console.ReadLine();
            Console.WriteLine("Digite su correo electronico: ");
            Adm.email = Console.ReadLine();
            Console.WriteLine("Digite su numero telofonico: ");
            Adm.tel = long.Parse(Console.ReadLine());
            Console.WriteLine("Digite el departamento: ");
            Adm.depa = Console.ReadLine();
            Console.WriteLine("Digite su cargo: ");
            Adm.cargo = Console.ReadLine();
            Console.WriteLine("Digite Cuanto gana por hora: ");
            Adm.Precio_hora = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite Cuanta horas usted trabaja: ");
            Adm.horas_trabajo = int.Parse(Console.ReadLine());

            Adm.codigo = Adm.depa.Substring(0, 3) + num;  

            listaadm.Add(Adm);

           
        }

        public void ver(List<EmpleadoAdm> Adm, List<EmpleadoG> EmG, List<Empleado_Ope> EmpOpe)
        {
            Console.Clear();
            Console.WriteLine("Empleado Administrativo");
            Console.WriteLine();
            

            foreach (var dato in Adm)
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
            CobrarAdm AdmCobra = new CobrarAdm();

            Console.WriteLine("Empleados Administrativos Activos");

            foreach (var dato in Adm)
            {

                salario_neto = AdmCobra.cobrar(dato.Precio_hora, dato.horas_trabajo);
                Console.WriteLine("###################################################");
                Console.WriteLine($"Codigo: {dato.codigo} ");
                Console.WriteLine("######################################");
                Console.WriteLine($"Cedula: {dato.cedula}");
                Console.WriteLine("######################################");
                Console.WriteLine($"Nombre: {dato.nombre}");
                Console.WriteLine("######################################");
                Console.WriteLine($"Apellido: {dato.apellido}");
                Console.WriteLine("######################################");
                Console.WriteLine($"Bonos$: Administrativo + 25% ");
                Console.WriteLine("######################################");
                Console.WriteLine($"Salario Neto: {salario_neto}");
                Console.ReadKey();

            }



        }

        public void pago(List<EmpleadoAdm> Adm, List<EmpleadoG> EmG, List<Empleado_Ope> EmpOpe)
        {
           
            CobrarAdm AdmCobra = new CobrarAdm();

            Console.WriteLine("Empleados Administrativos Activos");

            foreach (var dato in Adm)
            {

                salario_neto = AdmCobra.cobrar(dato.Precio_hora, dato.horas_trabajo);
                Console.WriteLine("###################################################");
                Console.WriteLine($"Codigo: {dato.codigo} ");
                Console.WriteLine("######################################");
                Console.WriteLine($"Nombre: {dato.nombre}");
                Console.WriteLine("######################################");
                Console.WriteLine($"Categoria: Administrativo");
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
