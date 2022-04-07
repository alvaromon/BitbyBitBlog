using BitbyBitBlog.Models;
using System.Linq;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace BitbyBitBlog.Components
{
    public partial class LatestBlogPostPreview
    {
        public BlogPostPreviewModel Preview { get; set; } = new();
        public BlogPost Blog { get; set; } = new();


        protected override async Task OnInitializedAsync()
        {
            //TODO: use BlogPostDataService

            var files = await _client.GetFromJsonAsync<BlogToReadModel>("Content/BlogsToRead.json");

            var latestBlog = files.blogs.Last();

            Blog = await _client.GetFromJsonAsync<BlogPost>($"Content/{latestBlog}");
            Preview = Blog.BlogPostPreview;
        }
    }
}
