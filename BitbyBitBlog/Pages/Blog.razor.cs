using BitbyBitBlog.Components;
using BitbyBitBlog.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BitbyBitBlog.Pages
{
    public partial class Blog
    {
        private IEnumerable<BlogPostPreview> blogPostPreviews = new List<BlogPostPreview>()
        {
            new BlogPostPreview() { ImageFilePath = "../Images/Kenny.png", BlogPostPreviewText = "This blog post is about Kenneth" },
            new BlogPostPreview(),
            new BlogPostPreview(),
            new BlogPostPreview(),
            new BlogPostPreview(),
            new BlogPostPreview()
        };
    }
}
