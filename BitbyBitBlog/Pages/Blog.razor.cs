using BitbyBitBlog.Components;
using BitbyBitBlog.Services.BlogPostDataService;
using System.Collections.Generic;
using System.IO;
using BitbyBitBlog.Models;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace BitbyBitBlog.Pages
{
    public partial class Blog
    {
        private List<BlogPost> blogPostPreviews = new List<BlogPost>();
        [Inject]
        private BlogPostDataService _blogService { get; set; }

        protected async override Task OnInitializedAsync()
        {
            // read all files in Content folder
            await _blogService.Initialize();
            var files = _blogService.BlogsToRead;

            foreach (var blogFileName in files.blogs)
            {
                var blog = await _blogService.ReadAsync(blogFileName);
                blogPostPreviews.Add(blog);
            }
        }
    }
}
