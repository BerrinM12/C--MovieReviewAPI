using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace MovieReviewAPI.Models
{
    public class Movie
    {
        [Required]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Ganre { get; set; }
        public int Rating { get; set; }

        // one movie has many reviews (1 : M)
        [JsonIgnore]
        public ICollection<Review> Reviews { get; set; } = new List<Review>();
    }
}