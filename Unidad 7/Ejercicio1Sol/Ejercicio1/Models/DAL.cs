
using Ejercicio1.Models.Entities;

namespace Ejercicio1.Models
{
    public class DAL
    {
        private static List<Persona> personas = new List<Persona>
            {
                new Persona("Ana", 25),
                new Persona("Luis", 28),
                new Persona("Marta", 22),
                new Persona("Carlos", 35),
                new Persona("Sofía", 27),
                new Persona("Javier", 30)
            };

        private static List<Departamento> departamentos = new List<Departamento>
            {
                new Departamento(1, "Recursos Humanos"),
                new Departamento(2, "Desarrollo"),
                new Departamento(3, "Marketing"),
                new Departamento(4, "Ventas"),
                new Departamento(5, "Finanzas")
            };



        public static List<Persona> getPersonas()
        {
            return DAL.personas;
        }
        public static List<Departamento> getDepartamentos()
        {
            return DAL.departamentos;
        }


    }
}
