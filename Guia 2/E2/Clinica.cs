using System.Collections.Generic;
namespace E2
{
    public class Clinica
    {
        List<Medico> Medico= new List<Medico>();

        public Clinica()
        {
            Medico Pepe= new Medico("Pepe","Fernandez","Pediatria",45);
            Medico Laura= new Medico("Laura","Ramirez","Psicologia",60);
            Medico Diego= new Medico("Diego","Gutierrez","Odontologia",34);
            this.Medico.Add(Pepe);
            this.Medico.Add(Laura);
            this.Medico.Add(Diego);
        }
        public List<Medico> Mostrar_Lista()
        {
             return Medico;
        }
    }
}