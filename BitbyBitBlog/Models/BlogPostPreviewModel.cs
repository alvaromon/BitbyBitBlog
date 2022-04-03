using System.Text.Json.Serialization;

namespace BitbyBitBlog.Models
{
    public class BlogPostPreviewModel
    {
        [JsonPropertyName("Title")]
        public string Title { get; set; }
        [JsonPropertyName("ImageFilePath")]
        public string ImageFilePath { get; set; }
        [JsonPropertyName("BlogPostPreviewText")]
        public string BlogPostPreviewText { get; set; }
    }
}
