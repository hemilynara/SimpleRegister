using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CP_MVC_RM550889.Models
{
    public class Avaliacao
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }
        public string TituloDaAvaliacao { get; set; }
        public string Comentario { get; set; }
        public Aval UserAvaliacao { get; set; }

    }
}
