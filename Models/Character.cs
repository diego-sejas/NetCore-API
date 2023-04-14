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
    [Table("characters")]
    public class Character
    {
        [Key]
        [DatabaseGenerated (DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [Required]
        [MaxLength(50), MinLength(5)]
        public string Name { get; set; }

        [NotNull]
        public int Age { get; set; }

        public int Weigth { get; set; }

        [Required]
        [MaxLength(100 , ErrorMessage = "history must be 100 characters or less"), MinLength(10)]
        public string History { get; set; }

        public string Image { get; set; }

        public Boolean Deleted = false;

        public DateTime CreatedDateTime { get; set; }
        public DateTime UpdatedDateTime { get; set; }

        public List<Character_Movie> Character_Movies { get; set; }
    }
}
