using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MulloJosue_LigaPro.Models
{
    public class Equipo
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre del equipo es obligatorio.")]
        [MaxLength(100, ErrorMessage = "El nombre del equipo no puede exceder los 100 caracteres.")]
        [DisplayName("Nombre del equipo")]
        public string Nombre { get; set; }

        [Range(0, 100, ErrorMessage = "El número de partidos jugados debe estar entre 0 y 100.")]
        public int PartidosJugados { get; set; }

        [Range(0, 100, ErrorMessage = "El número de partidos ganados debe estar entre 0 y 100.")]
        public int PartidosGanados { get; set; }

        [Range(0, 100, ErrorMessage = "El número de partidos perdidos debe estar entre 0 y 100.")]
        public int PartidosPerdidos { get; set; }

        [Range(0, 100, ErrorMessage = "El número de partidos empatados debe estar entre 0 y 100.")]
        public int PartidosEmpatados { get; set; }
        public string LogoPath { get; set; }
        public string Descripcion { get; set; }
    }
}