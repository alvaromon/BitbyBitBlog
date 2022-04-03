using BitbyBitBlog.Models;
using BitbyBitBlog.Services.BlogPostDataService;
using System.IO;
using System.Linq;

namespace BitbyBitBlog.Components
{
    public partial class LatestBlogPostPreview
    {
        private BlogPostPreviewModel preview;
        private BlogPost blog;

        protected override void OnInitialized() 
        {
            // read all files in Content folder
            var directory = new DirectoryInfo("Content/");
            var latestFile = directory.GetFiles().OrderByDescending(f => f.LastWriteTime).First();

            blog = new BlogPostDataService(latestFile.FullName).Read();

            preview = blog.BlogPostPreview;
        }
    }
}
