using System.Collections.Generic; 
namespace E3
{
    public class Figuritas
    {
        string nombre, posicion, pais;
        int numerofig;
        
        public Figuritas(string nombre, string posicion, string pais, int numerofig)
        {
            this.nombre=nombre;
            this.posicion=posicion;
            this.pais=pais;
            this.numerofig=numerofig;
        }
        public string MostrarNombres()=> nombre;
        public string MostrarPosicion()=> posicion;
        public string MostrarPais()=>pais;
        public string Posicion()=>posicion;
       
 //       public string IngresaNombre()
   //     {

    //    }
    //    public string IngresaPosicion()
    //    {
        
    //    }
    //    public string IngresaPais()
     //   {

        //}

        
        
    }
}