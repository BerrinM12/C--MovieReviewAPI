using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace MovieReviewAPI.Models
{
    public class Review
    {
        public int Id { get; set; }
        public string Comment { get; set; }
        public int Rating { get; set; }

        public int MovieId { get; set; }

        //[JsonIgnore]
        public Movie? Movie { get; set; } // 1 : 1 relationship
    }
}
