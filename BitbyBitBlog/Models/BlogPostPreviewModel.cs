using System.Text.Json.Serialization;

namespace BitbyBitBlog.Models
{
    public class BlogPostPreviewModel
    {
        [JsonPropertyName("Title")]
        public string Title { get; set; } = "default title";
        [JsonPropertyName("ImageFilePath")]
        public string ImageFilePath { get; set; } = "../Images/noimage.png";
        [JsonPropertyName("BlogPostPreviewText")]
        public string BlogPostPreviewText { get; set; } = "default preview text";
    }
}
