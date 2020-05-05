using MyFilm.Data;
using MyFilm.Data.Model;
using MyFilm.Repository.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFilm.Repository.Repositories
{
    public class FilmRepository : MyFilmService
    {
        private readonly MyFilmDbContext _db;

        public FilmRepository(MyFilmDbContext db)
        {
            _db = db;
        }
        public IQueryable<Film> GetFilms => _db.Films;

        public async Task<POJO> DeleteAsync(int? Id)
        {
            POJO model = new POJO();
            Film film = await GetFilm(Id);
            if (film != null)
            {
                try
                {
                    _db.Films.Remove(film);
                    await _db.SaveChangesAsync();
                    model.Flag = true;
                    model.Message = "Has been Deleted.";
                }
                catch (Exception ex)
                {
                    model.Flag = false;
                    model.Message = ex.ToString();
                }
            }
            else
            {
                model.Flag = false;
                model.Message = "Student does not exist.";
            }

            return model;

        }

        public async Task<Film> GetFilm(int? Id)
        {
            Film film = new Film();
            if (Id != null)
            {
                film = await _db.Films.FindAsync(Id);
            }

            return film;
        }

        public async Task<POJO> Save(Film film)
        {
            POJO model = new POJO();
            if (film.FilmId == 0)
            {
                try
                {
                    film.CreateDate = DateTime.Now;
                    await _db.AddAsync(film);
                    await _db.SaveChangesAsync();

                    model.Id = film.FilmId;
                    model.Flag = true;
                    model.Message = "Has Been Added.";

                }
                catch (Exception ex)
                {
                    model.Flag = false;
                    model.Message = ex.ToString();
                }
            }
            else if (film.FilmId != 0)
            {
                Film _Entity = await GetFilm(film.FilmId);
                _Entity.FilmId = film.FilmId;
                _Entity.FilmName = film.FilmName;
                _Entity.FilmImage = film.FilmImage;
                _Entity.FilmTypeId = film.FilmTypeId;
                _Entity.Episode = film.Episode;
                _Entity.ReleaseDate = film.ReleaseDate;
                _Entity.Story = film.Story;
                _Entity.FilmStatus = film.FilmStatus;
                _Entity.ModifiedDate = DateTime.Now;
                try
                {
                    await _db.SaveChangesAsync();
                    model.Id = film.FilmId;
                    model.Flag = true;
                    model.Message = "Has Been Updated.";
                }
                catch (Exception ex)
                {
                    model.Flag = false;
                    model.Message = ex.ToString();
                }
            }

            return model;

        }
    }
}
