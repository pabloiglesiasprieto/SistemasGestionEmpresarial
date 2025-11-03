using Domain.Entities.Persona;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class PersonaRepository100 : IPersonaRepository
    {
        private List<Persona> _personas = new List<Persona>
        {
            new Persona(1, "Juan", "Perez"),
            new Persona(2, "Maria", "Gomez"),
            new Persona(3, "Carlos", "Lopez"),
            new Persona(4, "Ana", "Martinez"),
            new Persona(5, "Luis", "Garcia"),
            new Persona(6, "Laura", "Fernandez"),
            new Persona(7, "Andres", "Torres"),
            new Persona(8, "Carmen", "Diaz"),
            new Persona(9, "Jorge", "Ramirez"),
            new Persona(10, "Sofia", "Ruiz"),
            new Persona(11, "Pedro", "Sanchez"),
            new Persona(12, "Lucia", "Mendoza"),
            new Persona(13, "Fernando", "Silva"),
            new Persona(14, "Patricia", "Morales"),
            new Persona(15, "Diego", "Castro"),
            new Persona(16, "Valentina", "Rojas"),
            new Persona(17, "Ricardo", "Vargas"),
            new Persona(18, "Gabriela", "Ortega"),
            new Persona(19, "Hector", "Jimenez"),
            new Persona(20, "Natalia", "Cruz"),
            new Persona(21, "Martin", "Herrera"),
            new Persona(22, "Elena", "Navarro"),
            new Persona(23, "Javier", "Dominguez"),
            new Persona(24, "Isabel", "Silva"),
            new Persona(25, "Santiago", "Mora"),
            new Persona(26, "Daniela", "Paredes"),
            new Persona(27, "Alberto", "Cabrera"),
            new Persona(28, "Monica", "Fuentes"),
            new Persona(29, "Victor", "Acosta"),
            new Persona(30, "Carolina", "Salazar"),
            new Persona(31, "Felipe", "Bravo"),
            new Persona(32, "Mariana", "Vega"),
            new Persona(33, "Joaquin", "Campos"),
            new Persona(34, "Paula", "Valencia"),
            new Persona(35, "Sebastian", "Soto"),
            new Persona(36, "Gabriela", "Cortes"),
            new Persona(37, "Esteban", "Rivas"),
            new Persona(38, "Lorena", "Benitez"),
            new Persona(39, "Mauricio", "Pino"),
            new Persona(40, "Daniela", "Cervantes"),
            new Persona(41, "Andres", "Ayala"),
            new Persona(42, "Natalia", "Estrada"),
            new Persona(43, "Ricardo", "Salinas"),
            new Persona(44, "Veronica", "Medina"),
            new Persona(45, "Jorge", "Luna"),
            new Persona(46, "Sofia", "Reyes"),
            new Persona(47, "Pablo", "Montoya"),
            new Persona(48, "Camila", "Figueroa"),
            new Persona(49, "Eduardo", "Campos"),
            new Persona(50, "Daniela", "Rojas"),
            new Persona(51, "Adrian", "Moreno"),
            new Persona(52, "Angela", "Cruz"),
            new Persona(53, "Ignacio", "Vargas"),
            new Persona(54, "Laura", "Paredes"),
            new Persona(55, "Hugo", "Salazar"),
            new Persona(56, "Carla", "Torres"),
            new Persona(57, "Joaquín", "Gonzalez"),
            new Persona(58, "Camila", "Ramirez"),
            new Persona(59, "Rafael", "Mendoza"),
            new Persona(60, "Isabella", "Fernandez"),
            new Persona(61, "Cristian", "Silva"),
            new Persona(62, "Valeria", "Morales"),
            new Persona(63, "Alfonso", "Castro"),
            new Persona(64, "Adriana", "Rojas"),
            new Persona(65, "Leonardo", "Vargas"),
            new Persona(66, "Marisol", "Ortega"),
            new Persona(67, "Diego", "Jimenez"),
            new Persona(68, "Samantha", "Cruz"),
            new Persona(69, "Andres", "Perez"),
            new Persona(70, "Paula", "Gomez"),
            new Persona(71, "Felipe", "Lopez"),
            new Persona(72, "Angela", "Martinez"),
            new Persona(73, "Victor", "Garcia"),
            new Persona(74, "Carolina", "Fernandez"),
            new Persona(75, "Hector", "Torres"),
            new Persona(76, "Isabel", "Diaz"),
            new Persona(77, "Pablo", "Ramirez"),
            new Persona(78, "Lorena", "Ruiz"),
            new Persona(79, "Fernando", "Sanchez"),
            new Persona(80, "Veronica", "Mendoza"),
            new Persona(81, "Sebastian", "Silva"),
            new Persona(82, "Natalia", "Morales"),
            new Persona(83, "Ricardo", "Castro"),
            new Persona(84, "Gabriela", "Rojas"),
            new Persona(85, "Javier", "Vargas"),
            new Persona(86, "Monica", "Ortega"),
            new Persona(87, "Eduardo", "Jimenez"),
            new Persona(88, "Lucia", "Cruz"),
            new Persona(89, "Andres", "Perez"),
            new Persona(90, "Valentina", "Gomez"),
            new Persona(91, "Martin", "Lopez"),
            new Persona(92, "Elena", "Martinez"),
            new Persona(93, "Santiago", "Garcia"),
            new Persona(94, "Daniela", "Fernandez"),
            new Persona(95, "Alberto", "Torres"),
            new Persona(96, "Carolina", "Diaz"),
            new Persona(97, "Victor", "Ramirez"),
            new Persona(98, "Mariana", "Ruiz"),
            new Persona(99, "Felipe", "Sanchez"),
            new Persona(100, "Isabella", "Mendoza")
        };

        /// <summary>
        /// Devuelve todas las personas en el repositorio.
        /// </summary>
        /// <returns>Lista con todas las personas.</returns>
        public List<Persona> GetAllPersonas()
        {
            return _personas;
        }
    }
}

