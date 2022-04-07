using System.Text.Json.Serialization;

namespace BitbyBitBlog.Models
{
    public class BlogToReadModel
    {
        [JsonPropertyName("blogs")]
        public string[] blogs { get; set; }
    }
}
