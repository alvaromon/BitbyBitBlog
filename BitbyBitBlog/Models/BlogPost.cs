using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BitbyBitBlog.Models
{
    public class BlogPost
    {
        [JsonPropertyName("Id")]
        public int Id { get; set; } = -1;
        [JsonPropertyName("Title")]
        public string Title { get; set; } = "default title";
        [JsonPropertyName("BlogText")]
        public string BlogText { get; set; } = "default blog text";
        [JsonPropertyName("Images")]
        public List<string> Images { get; set; } = new List<string>();
        [JsonPropertyName("BlogPostPreview")]
        public BlogPostPreviewModel BlogPostPreview { get; set; } = new();
    }
}
