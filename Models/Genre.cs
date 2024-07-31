using NuGet.Protocol.Plugins;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata;

namespace MvcMovie8.Models
{
    public class Genre
    {
        [Key]
        public int GenreId { get; set; }
        public string? GenreName { get; set; }
    }
}
