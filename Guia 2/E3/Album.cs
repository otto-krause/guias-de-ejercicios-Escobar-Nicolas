using System.Collections.Generic; 
namespace E3
{
    public class Album
    {
        public List<Figuritas> Figuritas= new List<Figuritas>();
        int cont=4;
        string nombre,posicion,pais;
        public Album()
        {
            Figuritas nro1= new Figuritas("Messi","Delantero","Argentina",1);
            Figuritas nro2= new Figuritas("Aguero","Delantero","Argentina",2);
            Figuritas nro3= new Figuritas("Di Maria","Mediocampista","Argentina",3);
            this.Figuritas.Add(nro1);
            this.Figuritas.Add(nro2);
            this.Figuritas.Add(nro3);
        }
    
        public List<Figuritas> MostraJug ()
        {
           return Figuritas;
        }
         
        public string MostrarNombres()=> nombre;
        public string MostrarPosicion()=> posicion;
        public string MostrarPais()=>pais;

        
        public Album(string nombre, string posicion, string pais)
        {
            Figuritas n=new Figuritas(nombre,posicion,pais,cont);
            Figuritas.Add(n);
        }
        
        public int CuantosDelanteros()//sinceramente no se me pudo ocurrir otra manera igual, seguire buscando.
        {
            int contD=0;
            foreach (var item in Figuritas)
            {
                if(item.Posicion()=="Delantero")
                   {
                       contD++;
                   }
            }
            return contD;//retorna delanteros
        }
        public int CuantosMediocampistas()
        {
            int contM=0;
            foreach (var item in Figuritas)
            {
                if(item.Posicion()=="Mediocampista")
                   {
                   contM++;
                   }
            
            }
            return contM;//retorna Mediocampistas
        }


    
      public void Album1(string nombre, string posicion, string pais)
        {
           this.nombre=nombre;
           this.posicion=posicion;
           this.pais=pais; 
           Figuritas n=new Figuritas(nombre,posicion,pais,cont);
           this.Figuritas.Add(n);
           cont++;


        }

        public int EstaCompleto()
        {
            return cont;
        }

    }
}