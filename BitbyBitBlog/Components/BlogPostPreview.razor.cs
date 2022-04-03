using Microsoft.AspNetCore.Components;
using BitbyBitBlog.Services.BlogPostDataService;
using System.IO;
using BitbyBitBlog.Models;

namespace BitbyBitBlog.Components
{
    public partial class BlogPostPreview
    {
        [Parameter]
        public string ImageFilePath { get; set; } = "../Images/noimage.png";
        [Parameter]
        public string BlogPostPreviewText { get; set; } = "default preview text";
        [Parameter]
        public string Title { get; set; } = "default title";
        [Parameter]
        public int Id { get; set; } = 0;
    }
}
