using BitbyBitBlog.Models;
using System;
using System.IO;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace BitbyBitBlog.Services.BlogPostDataService
{
    public class BlogPostDataService : IReadBlogPostData
    {
        private readonly HttpClient _client;

        public BlogToReadModel BlogsToRead { get; set; }

        // Constructor
        public BlogPostDataService(HttpClient client)
        {
            _client = client ?? throw new ArgumentNullException(nameof(client));
        }

        public async Task<BlogPost> ReadAsync(string fileName) 
        {
            return await _client.GetFromJsonAsync<BlogPost>($"Content/{fileName}");
        }

        public async Task Initialize()
        {
            BlogsToRead = await _client.GetFromJsonAsync<BlogToReadModel>("Content/BlogsToRead.json");
        }
    }
}
