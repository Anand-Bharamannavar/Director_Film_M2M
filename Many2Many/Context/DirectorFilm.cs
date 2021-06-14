using Many2Many.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Many2Many.Context
{
    public class DirectorFilm: DbContext
    {
        public DirectorFilm()
        {
        }

        public DirectorFilm(DbContextOptions<DirectorFilm> options)
            : base(options)
        {
        }
        public DbSet<Film> Films { get; set; }
        public DbSet<Director> Directors { get; set; }
        public DbSet<FilmDirector> FilmDirectors { get; set; }

       /* protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=.;Initial Catalog=codefirst_MM_DB;Integrated Security=True");
        }*/

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FilmDirector>().HasKey(sc => new { sc.FilmName, sc.DirectorName });
        }

    }
}
