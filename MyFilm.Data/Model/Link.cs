using System;
using System.Collections.Generic;
using System.Text;

namespace MyFilm.Data.Model
{
    public class Link
    {
        public int LinkID { get; set; }
        public string LinkString { get; set; }
        public string LinkName { get; set; }
        public int FilmID { get; set; }
        public string CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
