using System;
using System.Collections.Generic;

namespace E2
{
    class Program
    {
        static void Main(string[] args)
        {
           string especialidad;
           Clinica Favaloro=new Clinica();
           List<Medico> Medico= Favaloro.Mostrar_Lista();
    //----------------------------------------------------------------------       
           Console.WriteLine("Bienvenido a la clinica!, para consultar sobre un turno ingrese la especialidad deseada:\n");
           Console.WriteLine("Pediatria\nPsicologia\nOdontologia\n");
           especialidad=Console.ReadLine();
          
 //-----------------------------------------------------------------------

           foreach (var busca in Medico)
           {
               if(busca.MostrarEspecialidad()==especialidad)
               {
                   if(busca.EstaDisponible())
                      Console.WriteLine("Ha conseguido un turno y sera atendido por el/la doctor/a:"+ busca.MostrarNombre());
                   else
                      Console.WriteLine("Disculpe pero no podemos cubrir la demanda de turnos en esa especialidad, por favor intente mas tarde\n");
                   }
            }
        }
           
    }
}
