using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Many2Many.Model
{
    public class FilmDirector
    {
        [ForeignKey("Film")]
        [StringLength(20)]
        public string FilmName { get; set; }

        public Film Film { get; set; }

        [ForeignKey("Director")]
        [StringLength(20)]
        public string DirectorName { get; set; }

        public Director Director { get; set; }

    }
}
