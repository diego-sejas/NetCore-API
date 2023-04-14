using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi_Disney.Models
{
    [Table("movies")]
    public class Movie
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        
        public int Age { get; set; }

        [NotNull]
        [Range(1, 5)]
        public int Score { get; set; }

        public List<Character_Movie> Character_Movies { get; set; }

        public long GenereId { get; set; }
        public Genere Genere { get; set; }


    }
}
