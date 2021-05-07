using System;
using System.Collections.Generic;

namespace Tarea2._2
{
    class Program
    {
        static void Main(string[] args)
        {

            menu();


        }

        public static void menu()
        {
            //Listas 
            List<EmpleadoAdm> listaAdm = new List<EmpleadoAdm>();
            List<EmpleadoG> listaG = new List<EmpleadoG>();
            List<Empleado_Ope> listaO = new List<Empleado_Ope>();

            Console.WriteLine("###### Bienvenidos a la organizacion de Creacion de empleados ######");
            Console.WriteLine("Presione Enter para continuar");
            Console.ReadLine();


            //Creacion del menu 
            Ifabrica ifabrica; // Creamos una variable del tipo de la interfaz
            string opcion = "";
            bool continuar = true;

            while (continuar)
            {
                Console.Clear();
                Console.WriteLine("1- Crear un Empleado ");
                Console.WriteLine("2- Mostrar Empleado ");
                Console.WriteLine("3- Cobrar un Empleado ");
                Console.WriteLine("4- Recibo de pagos a Empleados ");
                Console.WriteLine("5- Salir del menu");
                Console.WriteLine();
                Console.Write("Escoge una opcion: ");
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        string elige = "";
                        Console.Clear();
                        Console.WriteLine("Vamos Agregar un Empleado");
                        Console.WriteLine();
                        Console.WriteLine("1- Empleado Generencial");
                        Console.WriteLine("2- Empleado Administrativo");
                        Console.WriteLine("3- Empleado Operativo");
                        Console.WriteLine();
                        Console.WriteLine("Escoge una opcion: ");
                        elige = Console.ReadLine();

                        ifabrica = Fabrica.construyeFabrica(elige);
                        ifabrica.crear(listaAdm, listaG, listaO);
                        break;

                    case "2":
                        Console.Clear();

                        string eligeE = "";
                        Console.Clear();
                        Console.WriteLine("Vamos a Mostrar los empleados");
                        Console.WriteLine();

                        Console.WriteLine("1- Empleado Gerencial");
                        Console.WriteLine("2- Empleado de Administracion");
                        Console.WriteLine("3- Empleado Operativo");
                        Console.WriteLine();
                        Console.WriteLine("Escoge una opcion: ");
                        eligeE = Console.ReadLine();

                        ifabrica = Fabrica.construyeFabrica(eligeE);
                        ifabrica.ver(listaAdm, listaG, listaO);
                        break;

                    case "3":
                        Console.Clear();

                        string elige3 = "";
                        Console.Clear();
                        Console.WriteLine("Vamos a Cobrar los empleados");
                        Console.WriteLine();

                        Console.WriteLine("1- Empleado Gerencial");
                        Console.WriteLine("2- Empleado de Administracion");
                        Console.WriteLine("3- Empleado Operativo");
                        Console.WriteLine();
                        Console.WriteLine("Escoge una opcion: ");
                        elige3 = Console.ReadLine();

                        ifabrica = Fabrica.construyeFabrica(elige3);
                        ifabrica.cobrar(listaAdm, listaG, listaO);
                        break;
                    case "4":

                        string elige4 = "";
                        Console.Clear();
                        Console.WriteLine("Vamos a ver Recibo de pago de los empleados");
                        Console.WriteLine();
                        Console.WriteLine("1- Empleado Gerencial");
                        Console.WriteLine("2- Empleado de Administracion");
                        Console.WriteLine("3- Empleado Operativo");
                        Console.WriteLine();
                        Console.WriteLine("Escoge una opcion: ");
                        elige4 = Console.ReadLine();

                        ifabrica = Fabrica.construyeFabrica(elige4);
                        ifabrica.pago(listaAdm, listaG, listaO);

                        break;

                    case "5":
                        continuar = false;
                        break;
                }
            }
        }

       



     
    }
}
