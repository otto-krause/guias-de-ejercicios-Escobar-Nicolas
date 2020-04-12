using System;

namespace E2
{
    class Program
    {
        static void Main()
      {
       int num1,num2,cont=0;
       string decision;
       int NUM1;
       Console.WriteLine("Escriba lo que desea hacer...(Multiplicar, Dividir(cociente,resto)\n");
       decision=Console.ReadLine();
       if(decision=="Multiplicar")//Multiplicacion
       {
          Console.WriteLine("Ingrese el multiplicando y el multiplicador:\n");
          num1=Int32.Parse(Console.ReadLine());
          NUM1=num1;
          num2=Int32.Parse(Console.ReadLine());
          for (int i = 1; i <=num2; i++)
          {
              if(i==1)
              {
                num1=NUM1;
              }
              if(i>1)
              {
              num1=num1+num1;
              }
          }
        Console.WriteLine("El resultado de la multiplicacion es:"+num1);
       }
       else
       {
           if(decision=="Dividir")
           {
               Console.WriteLine("Ingrese el dividendo y el divisor:\n");
               num1=Int32.Parse(Console.ReadLine());
               num2=Int32.Parse(Console.ReadLine());            
               while (num1>0)
               {
                   num1=num1-num2;
                   cont=+1;
               }
               Console.WriteLine("El resto de la division es:"+num1+"Y el cociente es:"+cont);
           }
       }
    
    }
    }
}