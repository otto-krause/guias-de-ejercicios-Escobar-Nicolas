using System;
using System.Collections.Generic;

namespace E1
{
    class Program
    {
        static void Main(string[] args)
        {
          int largo=0,cont=0,contm=0,p=0;
         List<int> numeros= new List<int> {1};//para que pueda cargar una vez
        
        do
        {
           numeros.Add(Int32.Parse(Console.ReadLine()));//agrega valores
            if(cont==0)
                 p=numeros[cont];
            if(numeros[cont]>50)
                {
                   contm+=1;//cuenta los mayores a 50
                }
             cont+=1;//cambia la posicion de numero[cont], tambien servira para la posicion del ultimo numero.     
        }while (numeros[cont]!=0); 
     
         largo=numeros.Count-2;
         Console.WriteLine("Numeros:");
        for (int i = 1; i <largo+1; i++)
        {
            Console.WriteLine(numeros[i]);
        }
        
         Console.WriteLine("Fueron ingresados "+largo+" numeros");//B
         Console.WriteLine("El primer numero ingresado fue:"+p+" Y el ultimo numero es: "+numeros[largo]);
         Console.WriteLine("La cantidad de numeros mayores a 50 son de:"+contm);
        
    }
}
}
