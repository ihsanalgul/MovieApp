using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Models
{
    public class GenelDatabaseSinifi : DbContext
    {

        public DbSet<Kategori> Kategoriler { get; set; }
        public DbSet<Film> Filmler { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Db\moviesDB.mdf;Integrated Security=True;Connect Timeout=3");




    }
}
