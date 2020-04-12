using System;

namespace E3
{
    class Program
    {
        static void Main(string[] args)
        {
           int num,decision;
           Console.WriteLine("Ingrese un numero  y luego ingrese [1]para saber si es primo o [2] para saber si es par:\n");
           num=Int32.Parse(Console.ReadLine());
           decision=Int32.Parse(Console.ReadLine());
           if(decision==1)
           {
              Esprimo(num);
           }
           else
           {
               if(decision==2)
               {
                 Espar(num);
               }
           }
        }
       //FUNCIONES
        static public void Esprimo(int num)
        {
          if(num%num==0&&num%1==0)
              Console.WriteLine("El numero es primo\n");
          else
              Console.WriteLine("El numero no es primo\n");
        }
        static public void Espar(int num)
        {
           if(num%2==0)
               Console.WriteLine("El numero es par\n");
           else
               Console.WriteLine("El numero no es par\n");
        }
    }
}