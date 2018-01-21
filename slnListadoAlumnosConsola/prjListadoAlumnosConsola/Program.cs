using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjListadoAlumnosConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong cantAlumnos=0;
            float acumPromGeneral=0.0f;
            string mejorPromedioApellido="";
            float mejorPromedioPromedio=0.0f;
            string strApe;
            float prom;
            
            Console.Write("Ingrese Apellido - Salir para Finalizar: ");
            strApe = Console.ReadLine();
            

            while (strApe.ToLower() != "salir")
            {
                Console.Write("Ingrese Promedio: ");
                prom = float.Parse(Console.ReadLine());
                cantAlumnos++;
                acumPromGeneral += prom;
                if ((mejorPromedioApellido == "") || (prom > mejorPromedioPromedio))
                {
                    mejorPromedioApellido = strApe;
                    mejorPromedioPromedio = prom;
                    

                }
                Console.Write("Ingrese Apellido - Salir para Finalizar: ");
                strApe = Console.ReadLine();
            }
                Console.WriteLine("Cantidad de Alumnos: "+ cantAlumnos.ToString());
                Console.WriteLine("Promedio General: "+ (acumPromGeneral / cantAlumnos).ToString());
                Console.WriteLine("Apellido de Mejor Alumno: " + mejorPromedioApellido);
                Console.WriteLine("Promedio del Mejor Alumno: " + mejorPromedioPromedio.ToString());
                Console.Write("Para finalizar pulse Enter");
                Console.ReadLine();
        }
    }
}

            
        