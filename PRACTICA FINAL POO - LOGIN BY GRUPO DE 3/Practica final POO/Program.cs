using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VERIFICACIÓN_DE_UNA_CLAVE_3_OPORTUNIDADES
{
    class Program
      {
        static void Main(string[] args)

        {
            
            byte Intentos_Usuario;
            byte Usuario; string Nombre_Usuario; Usuario = 0; Intentos_Usuario = 0;
            byte Intentos;
            byte password; string CLAVE; password = 0; Intentos = 0;


            do
            {
                Console.Write("Favor introduzca un nombre de usuario: "); Nombre_Usuario = Console.ReadLine(); if ((Nombre_Usuario.ToUpper() == "ADMIN"))
                {
                    Usuario = 1;
                }
                else
                {
                    Intentos_Usuario++;
                }
            } while (((Intentos_Usuario < 3) & (Usuario == 0))); if (Usuario == 1)
            {
             
            }
            else
            {
               
            }
            
            do
            {
                Console.Write("Favor introduzca una contraseña: "); CLAVE = Console.ReadLine(); if ((CLAVE.ToUpper() == "EXAMEN"))
                {
                    password = 1;
                }
                else
                {
                    Intentos++;
                }
            } while (((Intentos < 3) & (password == 0))); if (password == 1)
            {
                Console.WriteLine("BIENVENIDOS ESTUDIANTES DE ESTE GRUPO ");
                Console.WriteLine("ELADIO ARMANDO BATISTA MARTINEZ 15-MISN-1-125 ");
                Console.WriteLine("FRANKLIN JOELVIN LIVENT 15-MISN-1-137 ");
                Console.WriteLine("ASHLEY SHAYNA PEREZ 15-MISN-1-001");

            }
            else
            {
                Console.WriteLine("Las datos introducidos son incorrectos, favor intentar mas tarde.");
            }

                        Console.Write("Pulse una Tecla para salir:"); Console.ReadLine();
        }
    }
}






