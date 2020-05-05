using MyFilm.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFilm.Repository.Services
{
    public interface MyFilmService
    {
        IQueryable<Film> GetFilms { get; }
        Task<Film> GetFilm(int? id);
        Task<POJO> Save(Film _film);
        Task<POJO> DeleteAsync(int? id);
    }
}
