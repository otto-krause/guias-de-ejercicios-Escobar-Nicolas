using System;

namespace E5
{
    class Program
    {
        static void Main(string[] args)
        {
              int menu=6;
              double L1=0,L2=0,L3=0;
              while (menu!=0)
              {
                  Console.WriteLine("Bienvenido al menu:\n"); 
                      Console.WriteLine("Ingrese los lados del triangulo, por favor:\n");
                        L1=Int32.Parse(Console.ReadLine());
                          L2=Int32.Parse(Console.ReadLine());
                            L3=Int32.Parse(Console.ReadLine());
                             Console.WriteLine("Si Desea ingresar hacer algo mas, puede crear el objeto ingresando [2] y con [3] y puede ver los mensajes del mismo");
                             menu=Int32.Parse(Console.ReadLine());
                      if(menu==2)
                      {
                           triangulo X= new triangulo(L1,L2,L3);
                       Console.WriteLine("Objeto Creado!\n");
                        Console.WriteLine("Si Desea ingresar hacer algo mas, recuerde que puede crear el objeto ingresando [2] y con [3] y puede ver los mensajes del mismo");
                             menu=Int32.Parse(Console.ReadLine());
                      }
                      if(menu==3)
                          {
                              triangulo X= new triangulo(L1,L2,L3);
                              Console.WriteLine("Estos son los mensajes:");
                              Console.WriteLine("EsEscaleno devuelve(true,false) si su triangulo es o no escaleno, dependiendo de los lados del mismo y lo que devuelve este es:"+X.EsEscaleno()+"\n");
                              Console.WriteLine("EsIsosceles devuelve(true,false) si su triangulo es o no isosceles, dependiendo de los lados del mismo y lo que devuelve este es:"+X.EsIsosceles()+"\n");
                              Console.WriteLine("EsEquilatero devuelve(true,false) si su triangulo es o no equilatero, dependiendo de los lados del mismo y lo que devuelve este es:"+X.EsEquilatero()+"\n");
                              Console.WriteLine("EsTrianguloRectangulo devuelve(true,false) si su triangulo es o no rectangulo, dependiendo de los lados del mismo y teorema de pitagoras y lo que devuelve este es:"+X.EsTrianguloRectangulo(L1,L2,L3)+"\n");
                              menu=0;
                          }
              }
        }
    }
    class triangulo
    {
        double l1,l2,l3,total;
     
      public triangulo(double L1, double L2, double L3)
      {
         this.l1= L1;
         this.l2= L2;
         this.l3= L3;
      }
    
      public bool EsEscaleno()
      {
       if(l1!=l2&&l2!=l3)
       {
         if(l3!=l1)
             return true;
         else
             return false;
       }
       else
           return false;
      }
    
      public bool EsIsosceles()
      {
          if(l1==l2&&l2!=l3)
          {
              if(l1!=l2)
                  return true;
              else
                  return false;
          }
          else
          {
             return false;
          }
      }

      public bool EsEquilatero()
      {
        if(l1==l2&&l2==l3)
        {
            if(l1==l3)
            {
                return true;
            }
            else
                return false;
        }
        else
           return false;
      }
      public bool EsTrianguloRectangulo(double L1, double L2,double L3)
      {
          L1=Math.Pow(L1,2);
          L2=Math.Pow(L2,2);
          L3=Math.Pow(L3,2);
          total=L1+L2;

          if(total==L3)
              return true;
          else
             return false;
      }
    }
}

