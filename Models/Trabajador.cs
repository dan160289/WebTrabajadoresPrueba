using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebTrabajadoresPrueba.Models
{
    public class Trabajador
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Tipo { get; set; }

        [Required]
        public string Numero { get; set; }

        [Required]
        public string Nombres { get; set; }

        [Required]
        public string Sexo { get; set; }

        [Required]
        public int IdDep { get; set; }

        [Required]
        public int IdPro { get; set; }

        [Required]
        public int IdDis { get; set; }
    }
}
