using BitbyBitBlog.Components;
using BitbyBitBlog.Services.BlogPostDataService;
using System.Collections.Generic;
using System.IO;
using BitbyBitBlog.Models;

namespace BitbyBitBlog.Pages
{
    public partial class Blog
    {
        private List<BlogPost> blogPostPreviews = new List<BlogPost>();

        protected override void OnInitialized()
        {
            // read all files in Content folder
            var contentFiles = Directory.EnumerateFiles("Content/");

            foreach (var path in contentFiles)
            {
                blogPostPreviews.Add(new BlogPostDataService(path).Read());
            }
        }
    }
}
