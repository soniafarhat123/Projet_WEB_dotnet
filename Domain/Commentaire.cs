using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class Commentaire
    {
        [Key]
        public int IdCommentaire { get; set; }
        [Required]  
        public string Nom { get; set; }
        [Required]
        public string Prenom { get; set; }
        [Required]
        public string Message { get; set; }
        [Required]
        public int NbreNote { get; set; }
        public virtual Article Article { get; set; }

    }
}
