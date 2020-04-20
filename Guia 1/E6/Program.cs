using System;

namespace E6
{
    class Program
    {
        static void Main(string[] args)
        {
           int menu=6,num=0,num1=0,num2=0,lfib=0;
           double cubo=0;
           Console.WriteLine("Bienvenido al menu:\n");
           while (menu!=0)
           {
               Console.WriteLine("Para utilizar el metodo fibonacci ingrese[1] para hacer el factorial de un numero ingrese[2], para ver el mayor de dos numeros ingrese[3], para ver el menor de dos numeros ingrese[4], para elevar un numero al cuadrado ingrese [5], para finalizar el programa ingrese [0]\n");
               menu=Int32.Parse(Console.ReadLine());
               if(menu==1)
               {
                   Matematica X=new Matematica();
                  Console.WriteLine("Por favor ingrese el limite de numeros que mostrara el fibonacci.. ej : 2(1,1)\n");
                  lfib=Int32.Parse(Console.ReadLine());
                  Console.WriteLine("Fibonacci:\n");
                  X.Fibonacci(lfib);
                  Console.WriteLine("Si desea hacer algo mas recuerde que puede tambien hacer el factorial de un numero ingresando[2], ver el mayor de dos numeros ingresando[3], ver el menor de dos numeros ingresando[4],elevar un numero al cuadrado ingresando [5], para finalizar el programa ingrese [0]\n");
                  menu=Int32.Parse(Console.ReadLine());
               }
               if(menu==2)
               {
                  Matematica X=new Matematica();
                  Console.WriteLine("Ingrese el numero deseado para saber su factorial:\n");
                  num=Int32.Parse(Console.ReadLine());
                  Console.WriteLine("El factorial de "+num+" es de: ");
                  X.Factorial(num);
                  Console.WriteLine("Si desea hacer algo mas recuerde que puede tambien hacer el factorial de un numero ingresando[2], ver el mayor de dos numeros ingresando[3], ver el menor de dos numeros ingresando[4],elevar un numero al cuadrado ingresando [5], para finalizar el programa ingrese [0]\n");
                  menu=Int32.Parse(Console.ReadLine());
               }
               if(menu==3)
               {
                   Matematica X=new Matematica();
                   Console.WriteLine("Ingrese dos numeros para idenficar el mayor:\n");
                   num1=Int32.Parse(Console.ReadLine());
                   num2=Int32.Parse(Console.ReadLine());
                   Console.WriteLine("El mayor de entre los dos es: "+X.Mayor(num1,num2));
                   Console.WriteLine("Si desea hacer algo mas recuerde que puede tambien hacer el factorial de un numero ingresando[2], ver el mayor de dos numeros ingresando[3], ver el menor de dos numeros ingresando[4],elevar un numero al cuadrado ingresando [5], para finalizar el programa ingrese [0]\n");
                   menu=Int32.Parse(Console.ReadLine());
               }
               if(menu==4)
               {
                   Matematica X=new Matematica();
                   Console.WriteLine("Ingrese dos numeros para idenficar el menor:\n");
                   num1=Int32.Parse(Console.ReadLine());
                   num2=Int32.Parse(Console.ReadLine());
                   Console.WriteLine("El mayor de entre los dos es: "+X.Menor(num1,num2));
                   Console.WriteLine("Si desea hacer algo mas recuerde que puede tambien hacer el factorial de un numero ingresando[2], ver el mayor de dos numeros ingresando[3], ver el menor de dos numeros ingresando[4],elevar un numero al cuadrado ingresando [5], para finalizar el programa ingrese [0]\n");
                   menu=Int32.Parse(Console.ReadLine());
               }
               if(menu==5)
               {
                   Matematica X=new Matematica();
                   Console.WriteLine("Ingrese un numero para saber su valor elevado al cubo:\n");
                   cubo=Int32.Parse(Console.ReadLine());
                   Console.WriteLine("El valor de "+cubo+" elevado al cubo es de:"+X.Cubo(cubo));
                   Console.WriteLine("Si desea hacer algo mas recuerde que puede tambien hacer el factorial de un numero ingresando[2], ver el mayor de dos numeros ingresando[3], ver el menor de dos numeros ingresando[4],elevar un numero al cuadrado ingresando [5], para finalizar el programa ingrese [0]\n");
                   menu=Int32.Parse(Console.ReadLine());
               }

        }
     }
    }
    class Matematica
    {
        int fibo=0,fibo1=1,fact=1,numeroMayor=0,numeroMenor=0;
        double alCubo=0;

      //  public Matematica()//constructor
       // {

        //}

      public void Fibonacci(int lfib)
      {
       
       for (int i = 1; i<=lfib ; i++)     
       {
           if(i==1)
           {
             Console.WriteLine(fibo1);
           }
           else
           { 
             fibo1=fibo+fibo1;
             Console.WriteLine(fibo1);  
           }
          
        }  
       } 
      public void Factorial(int num)
      {
        for(int i=1;i<=num;i++)
        {
            fact=fact*i;
            Console.WriteLine(fact);
        }
      }
    
      public int Mayor(int num1,int num2)
      {
        numeroMayor = num1>num2 ?  num1 : num2;
        return numeroMayor;
      }
    
      public int Menor(int num1, int num2)
      {
        numeroMenor = num1<num2 ?  num1 : num2;
        return numeroMenor;
      }
    
      public double Cubo(double cubo)
      {
        alCubo=Math.Pow(cubo,3);
        return alCubo;        
      }
    
    }

 
}
