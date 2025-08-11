using System.ComponentModel.DataAnnotations;

namespace netdemoTarea3.Models
{
    public class Mascota
    {
        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; } = string.Empty;

        [Required]
        public string Tipo { get; set; } = string.Empty;

        [Required]
        public int Edad { get; set; }
    }
}
