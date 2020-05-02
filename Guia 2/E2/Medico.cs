namespace E2
{
    public class Medico
    {
        string nombre,apellido,especialidad;
        int CantTurnos;

        public Medico(string nombre, string apellido, string especialidad, int CantTurnos)
        {
            this.nombre=nombre;
            this.apellido=apellido;
            this.especialidad=especialidad;
            this.CantTurnos=CantTurnos;
        }
       
        public bool EstaDisponible()=> CantTurnos<50;//envia a program para verificar disponibilidad
       
        public string MostrarEspecialidad()=> especialidad;//muestra la especialidad en program
       
        public string MostrarNombre()=> nombre;//muestra el nombre del doctor
      }
}