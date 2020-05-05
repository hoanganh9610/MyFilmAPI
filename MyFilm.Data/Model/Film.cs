using System;
using System.Collections.Generic;
using System.Text;

namespace MyFilm.Data.Model
{
    public class Film
    {
        public int FilmId { get; set; }
        public string FilmName { get; set; }
        public string FilmImage { get; set; }
        public int FilmTypeId { get; set; }
        public int Episode { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public int FilmRate { get; set; }
        public string Story { get; set; }
        public string FilmStatus { get; set; }
        public string CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
