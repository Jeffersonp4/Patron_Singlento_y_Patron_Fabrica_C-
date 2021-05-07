using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea2._2
{
    class Fabrica
    {
        public static Ifabrica construyeFabrica(string elige)
        {

            switch (elige)
            {
                case "1":
                    return new EmpleadoG();
                case "2":
                    return new EmpleadoAdm();
                case "3":
                    return new Empleado_Ope();
                default:
                    Console.WriteLine("Por favor Digite una opcion valida!");
                    Console.ReadLine();
                    Console.Clear();
                    Program.menu();
                    return null;

                    


            }
        }
    }
}