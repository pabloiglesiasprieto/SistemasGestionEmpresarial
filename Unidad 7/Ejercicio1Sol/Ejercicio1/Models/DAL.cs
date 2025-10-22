
using Ejercicio1.Models.Entities;

namespace Ejercicio1.Models
{
    public class DAL
    {
        private static List<Persona> personas = new List<Persona>
            {
                new Persona("Ana", 25,3),
                new Persona("Luis", 28,1),
                new Persona("Marta", 22,5),
                new Persona("Carlos", 35,4),
                new Persona("Sofía", 27,1),
                new Persona("Javier", 30,2),
                new Persona("Macarenut", 19,3),
                new Persona("Paula",17)
            };

        private static List<Departamento> departamentos = new List<Departamento>
            {
                new Departamento(1, "Recursos Humanos"),
                new Departamento(2, "Desarrollo"),
                new Departamento(3, "Marketing"),
                new Departamento(4, "Ventas"),
                new Departamento(5, "Finanzas")
            };


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static List<Persona> getPersonas()
        {
            return DAL.personas;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static List<Departamento> getDepartamentos()
        {
            return DAL.departamentos;
        }


    }
}
