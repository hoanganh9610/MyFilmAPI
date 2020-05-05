using Microsoft.EntityFrameworkCore;
using MyFilm.Data.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyFilm.Data
{
    public class MyFilmDbContext:DbContext
    {
        public MyFilmDbContext(DbContextOptions options): base(options)
        {

        }
        public DbSet<Film> Films { get; set; }
        public DbSet<Link> Links { get; set; }
    }
}
