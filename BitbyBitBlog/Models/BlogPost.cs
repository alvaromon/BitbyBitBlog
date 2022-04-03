using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BitbyBitBlog.Models
{
    public class BlogPost
    {
        [JsonPropertyName("Id")]
        public int Id { get; set; }
        [JsonPropertyName("Title")]
        public string Title { get; set; }
        [JsonPropertyName("BlogText")]
        public string BlogText { get; set; }
        [JsonPropertyName("Images")]
        public List<string> Images { get; set; }
        [JsonPropertyName("BlogPostPreview")]
        public BlogPostPreviewModel BlogPostPreview { get; set; }
    }
}
