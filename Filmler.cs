using CsvHelper.Configuration;
using FluentNHibernate.Mapping;
using System.ComponentModel.DataAnnotations.Schema;

namespace SınemaSeansTakip.Model
{
    public class Filmler
    {
        public virtual int Id { get; set; }
        public virtual string Ad { get; set; }

    }

    public sealed class FilmMap : ClassMap<Filmler>
    {
        public FilmMap()
        {
            Id(x => x.Id).GeneratedBy.Identity();
            Map(x => x.Ad);
            Table("Filmler");
        }
    }
}
