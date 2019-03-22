using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HTMLHelpers.Models
{
    public class Persona
    {
        [Required]
        public string cedula { get; set; }

        [Required]
        public string nombre { get; set; }

        [Required]
        public string apellido { get; set; }

        [Range(15,99)]
        public int edad { get; set; }

        public string telefono { get; set; }

        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string correo  { get; set; }

        public Genero genero { get; set; }

        public string EstadoCivil { get; set; }

        public string[] Hobbys { get; set; }

    }

    public enum Genero
    {
        Hombre,
        Mujer
    }

}