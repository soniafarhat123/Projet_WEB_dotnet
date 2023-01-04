using Domain;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class Jeux
    {
        [Key]
        public int IdJeux { get; set; }
        [Required]
        public string Nom { get; set; }
        public string Image { get; set; }
        public int Note { get; set; }
        public virtual ICollection<Article> ListArticle { get; set; }
    }
}
