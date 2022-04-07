using BitbyBitBlog.Models;
using System;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Text.Json;

namespace BitbyBitBlog.Services.BlogPostDataService
{
    public class BlogPostDataService : IReadBlogPostData
    {
        private readonly string _filePath;

        // Constructor
        public BlogPostDataService(HttpClient client, string filePath)
        {
            _filePath = filePath ?? throw new ArgumentNullException(nameof(filePath));
        }

        public BlogPost Read() 
        {
            var jsonString = File.ReadAllText(_filePath);
            
            return JsonSerializer.Deserialize<BlogPost>(jsonString);
        }

        public static BlogPost Read(string jsonString)
        {
            return JsonSerializer.Deserialize<BlogPost>(jsonString);
        }
    }
}
