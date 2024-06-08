using System;
using System.ComponentModel.DataAnnotations;

namespace AplicacionRazor.modelos
{
    public class Curso
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Nombre del curso")]
        public string NombreCurso { get; set; }
        [Display(Name = "Cantidad de clases")]
        public int CantidadClases { get; set; }
        public int Precio { get; set; }
        [Display(Name = "Fecha de creacion")]
        public DateTime FechaCreacion { get; set; }
    }
}
