using System;

namespace E1
{
    class Program
    {
        static void Main()
        {

            int Sum=0,prom=0,menor=0,aux;
            int[]vector=new int[10];
            Console.WriteLine("Ingrese los elementos del vector:\n");
            for (int i = 0; i < 10; i++)
            {
                vector[i]=Int32.Parse(Console.ReadLine());
                Sum+=vector[i];     
                if(i==0)
                {
                    menor=vector[i];      
                }
                else
                {
                    if(menor<vector[i])
                    {
                
                    }
                    else
                    {
                      menor=vector[i];  
                    }
                }
            }
             prom=Sum/10;
            // parte en que se empiezan a mostrar los resultados
            for(int i=0;i<10-1;i++)
            {
                for(int j=10-1;j>=i;j--)
                {
                    if(vector[j]>vector[i])
                    {
                        aux=vector[j];
                        vector[j]=vector[i];
                        vector[i]=aux;
                    }
                }
            }
            Console.WriteLine("La sumatoria de todos los elementos del vector es de:"+Sum+"\n");
            Console.WriteLine("El menor elemento del vector es:"+menor+"\n");
            Console.Write("El promedio de todos los elementos es de:"+prom+"\n");
            //impresion del vector de manera descendente(mayor-menor)
            Console.WriteLine("El vector ordenado de mayor a menor es asi:\n");
            for(int i=0;i<=10;i++)
            {
               Console.WriteLine(vector[i]+"\n");      
            }
        }
    }
}
