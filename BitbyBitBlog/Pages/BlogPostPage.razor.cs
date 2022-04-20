using BitbyBitBlog.Models;
using BitbyBitBlog.Services.BlogPostDataService;
using Microsoft.AspNetCore.Components;
using System.IO;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace BitbyBitBlog.Pages
{
    public partial class BlogPostPage
    {
        [Parameter]
        public int Id { get; set; }
        public BlogPost BlogPost { get; set; } = new();

        [Inject]
        private HttpClient _client { get; set; }


        protected async override Task OnInitializedAsync()
        {
            // TODO: this should get removed when we add the data service to the DI
            // read all files in Content folder
            // contentFiles = Directory.EnumerateFiles("Content/");

            var files = await _client.GetFromJsonAsync<BlogToReadModel>("Content/BlogsToRead.json");

            foreach (var blogFileName in files.blogs)
            {
                var blog = await _client.GetFromJsonAsync<BlogPost>($"Content/{blogFileName}");

                if (blog.Id == Id)
                {
                    BlogPost = blog;
                }
            }
        }
    }
}
