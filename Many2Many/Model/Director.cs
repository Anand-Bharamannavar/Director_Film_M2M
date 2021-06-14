using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Many2Many.Model
{
    public class Director
    {
        [Key]
        [StringLength(20)]
        public string DirectorName { get; set; }

        [Required]
        public byte Age { get; set; }

        [Required]
        [StringLength(10)]
        public string Gender { get; set; }

        [Required]
        public byte AwardCount { get; set; }

        public IList<FilmDirector> FilmDirectors { get; set; }

    }
}
