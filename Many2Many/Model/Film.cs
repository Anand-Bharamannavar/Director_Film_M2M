using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Many2Many.Model
{
    public class Film
    {

        [Key]
        [StringLength(20)]
        public string FilmName { get; set; }

        [Required]
        public int FilmID { get; set; }

        [Required]
        public double Collection { get; set; }

        [Required]
        public byte Rating { get; set; }

        public IList<FilmDirector> FilmDirectors { get; set; }

    }
}
