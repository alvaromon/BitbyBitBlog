using BitbyBitBlog.Components;
using BitbyBitBlog.Services.BlogPostDataService;
using System.Collections.Generic;
using System.IO;
using BitbyBitBlog.Models;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace BitbyBitBlog.Pages
{
    public partial class Blog
    {
        private List<BlogPost> blogPostPreviews = new List<BlogPost>();

        protected async override Task OnInitializedAsync()
        {
            // read all files in Content folder
            //var contentFiles = Directory.EnumerateFiles("Content/");

            var files = await _client.GetFromJsonAsync<BlogToReadModel>("Content/BlogsToRead.json");

            foreach (var blogFileName in files.blogs)
            {
                var blog = await _client.GetFromJsonAsync<BlogPost>($"Content/{blogFileName}");
                blogPostPreviews.Add(blog);
            }
        }
    }
}
