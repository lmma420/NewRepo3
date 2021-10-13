using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace pilincha.Models
{
    public class Cancion
    {
        [Key]
        [Required]
        public string Nombre { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "nombre requerido")]
        public string Autor { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "nombre requerido")]
        [StringLength(200,MinimumLength =10, ErrorMessage = "La longitud es mucha")]
        public string Letra { get; set; }
        [StringLength(200, MinimumLength = 10, ErrorMessage = "La longitud es mucha")]

        [Required]
        public string Enlace { get; set; }

    }
}
