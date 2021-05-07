using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea2._2
{
    class SGerente
    {
        //primero creamos la instancia o el objeto de nuestra propia clase
        private static SGerente generar;


        //Despues Creamos una variable para pasarle como parametro
        private static string cedula;
        private static string codigo;
        private static string nombre;
        private static string apellido;
        private static string email;
        private static long telef;
        private static string dep;
        private static string cargo;
        private static int precio_hora;
        private static int hora_trabajo;

        // Luego creamos  nuestro constructor privado propio de la misma clase para proteger nuestra variable
        private SGerente(string cedula1, string codigog, string nom, string ape, string emai, long tel, string dep1, string carg, int precio, int hora)
        {

            cedula = cedula1;
            codigo = codigog;
            nombre = nom;
            apellido = ape;
            email = emai;
            telef = tel;
            dep = dep1;
            cargo = carg;
            precio_hora = precio;
            hora_trabajo = hora;

        }

        public static SGerente GetSgenerar(string cedula1, string codigog, string nom, string ape, string emai, long tel, string dep1, string carg, int precio, int hora)
        {
            if (generar == null)
            {
                generar = new SGerente(cedula1,codigog, nom, ape, emai, tel, dep1, carg, precio, hora);
            }

            return generar;
        }




    }
}
