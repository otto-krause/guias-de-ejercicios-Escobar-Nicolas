using System;

namespace E4
{
    class Program
    {
        static void Main(string[] args)
        {
             int menu,minutos;
             
             Gatito batman= new Gatito("Antonio",true,30);
             Console.WriteLine("Este es el menu.., para saber el nombre del gatito ingrese[1], para saber si esta vacunado[2], para hacerlo jugar ingrese[3](gasta 2*minutos jugados), para que el gatito coma(recupera 50 de energia)[4],para saber si esta Saludable[5]:\n");
             menu= Int32.Parse(Console.ReadLine());

             switch(menu)
            {
                case 1:
                    Console.WriteLine("El nombre del gatito es:"+batman.Nombre());
                     break;
                case 2:
                    Console.WriteLine("El gatito esta vacunado?"+batman.EstaVacunado());
                     break;
                case 3:
                     minutos=Int32.Parse(Console.ReadLine());
                     Console.WriteLine("El gatito ha jugado y ahora tiene"+batman.Jugar(minutos)+"de Energia");
                     break;
                case 4:       
                     Console.WriteLine("El gatito ha comido asi que ahora mismo tiene"+batman.Comer()+"de Energia");
                     break;
                 case 5:
                     Console.WriteLine("El gatito esta saludable?"+batman.EstaSaludable());
                     break;
            }
       }     
    }         
             
    
    
    class Gatito
    {
      string nombre;
      bool Vacunas;
      int energia;
      
      
      public Gatito(string nombre, bool Vacunas, int energia)
      {
         this.nombre= nombre;
         this.Vacunas= Vacunas;
         this.energia= energia;
      }
      public string Nombre()
      {
          return nombre;
      }
      public bool EstaSaludable()
      {
         return Vacunas == true && energia>30;
      }
      public bool EstaVacunado()
      {
         return true;
      }
      public int Jugar(int minutos)
      {
         energia=energia-2*minutos;
         return energia;
      }
      public int Comer()
      {
          return energia=energia+50;
      }
    
    } 
}