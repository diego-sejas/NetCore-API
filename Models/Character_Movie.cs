using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi_Disney.Models
{
    public class Character_Movie
    {
        public long Id { get; set; }

        public long Characterid { get; set; }
        public Character Character { get; set; }

        public long MovieId { get; set; }
        public Movie Movie { get; set; }
    }
}
