using System;
using System.Collections.Generic; 
namespace E3
{
     class Program
     {
          static void Main(string[] args)
          {
              string nombre, posicion, pais;
              int decision=5,jug=0;
              Album Mundial=new Album();//es para acceder a album

              List<Figuritas> fig = Mundial.MostraJug();//al ser la lista de tipo Figuritas, se puede acceder a los metodos que tiene esa clase por medio de esta lista
              while (decision!=0)
              {
               Console.WriteLine("Bienvenido al Album de figuritas\n");
               Console.WriteLine("Ingrese [1] para Añadir una figurita, ver la lista de Jugadores y saber si el album esta completo\n");
               Console.WriteLine("Ingrese [2] para ver la cantidad de Delanteros\n");
               Console.WriteLine("Ingrese [3] para ver la cantidad de Mediocampistas\n");
               Console.WriteLine("Ingrese [0] para salir\n");
               decision=Int32.Parse(Console.ReadLine());
               if(decision==1)
               {
               Console.WriteLine("Ingrese una figurita!(Nombre,Posicion,Pais)\n");//Ingreso
                 nombre=Console.ReadLine();         
                 posicion=Console.ReadLine();
                 pais=Console.ReadLine();
                 Mundial.Album1(nombre,posicion,pais);
               Console.WriteLine("La figurita ha sido Agregada!");
               Console.WriteLine("\n");
                 jug=Mundial.EstaCompleto();
               if(jug==352)
                  Console.WriteLine("Info: El album esta completo\n");
               else
                  Console.WriteLine("Info: El album no esta completo aun\n");
               
               Console.WriteLine("Lista de jugadores:\n");
//----------------------------------Muestra album--------------------------------------------------
              foreach (var item in fig)//muestra nuevos datos
              {
                  Console.WriteLine(item.MostrarNombres()+"  "+item.MostrarPosicion()+"  "+item.MostrarPais());
              }
//----------------------------------Muestra Cantidad de Delanteros y Mediocampistas-------------------------------------------------         
             Console.WriteLine("\n");
             Console.WriteLine("Ingrese [1] para Añadir una figurita, ver la lista de Jugadores y saber si el album esta completo\n");
             Console.WriteLine("Ingrese [2] para ver la cantidad de Delanteros\n");
             Console.WriteLine("Ingrese [3] para ver la cantidad de Mediocampistas\n");
             Console.WriteLine("Ingrese [0] para salir\n");
             decision=Int32.Parse(Console.ReadLine());
 //----------------------------------------------------------------------------------------------------     -    
               } 
             if(decision==2)
              {
                Console.WriteLine("Cantidad de Delanteros:"+Mundial.CuantosDelanteros());
                 Console.WriteLine("Ingrese [1] para Añadir una figurita, ver la lista de Jugadores y saber si el album esta completo\n");
                 Console.WriteLine("Ingrese [2] para ver la cantidad de Delanteros\n");
                 Console.WriteLine("Ingrese [3] para ver la cantidad de Mediocampistas\n");
                 Console.WriteLine("Ingrese [0] para salir\n");
                 decision=Int32.Parse(Console.ReadLine());
               }
             else
                if(decision==3)
                   {
                    Console.WriteLine("Cantidad de Mediocampistas:"+Mundial.CuantosMediocampistas());
                     Console.WriteLine("Ingrese [1] para Añadir una figurita, ver la lista de Jugadores y saber si el album esta completo\n");
                     Console.WriteLine("Ingrese [2] para ver la cantidad de Delanteros\n");
                     Console.WriteLine("Ingrese [3] para ver la cantidad de Mediocampistas\n");
                     Console.WriteLine("Ingrese [0] para salir\n");
                     decision=Int32.Parse(Console.ReadLine());
                   }    
       }

    }   
}
}