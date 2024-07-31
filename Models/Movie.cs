using NuGet.Protocol.Plugins;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata;

namespace MvcMovie8.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        public string? Title { get; set; }
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public decimal Price { get; set; }

        [ForeignKey("Genre")]
        public virtual int GenreId { get; set; }
        public virtual Genre? Genre { get; set; }
        //[InverseProperty("Movie")]
        //public virtual Genre? Genre { get; set; }
    }
}
