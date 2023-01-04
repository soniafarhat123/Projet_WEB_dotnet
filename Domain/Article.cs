using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain
{
    public class Article
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Titre { get; set; }
        [Required]
        public string Contenu { get; set; }
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        public int IdJeux { get; set; }
        public virtual Jeux Jeux { get; set; }
        [ForeignKey("Jeux")]
        public int? JeuxFK { get; set; } 
        public virtual ICollection<Commentaire> ListCommentaires { get; set; }


    }
}
