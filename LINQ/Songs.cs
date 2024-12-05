using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public class Songs
    {

        public Songs(int id, string name, string band, DateTime releaseDate)
        {
            Id = id;
            Name = name;
            Band = band;
            ReleaseDate = releaseDate;
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Band { get; set; }

        public DateTime ReleaseDate { get; set; }

        #region

        public override string ToString() =>
            $"Id: {Id} | Name: {Name} | Band: {Band} | ReleaseDate: {ReleaseDate}";

        #endregion
    }
}
