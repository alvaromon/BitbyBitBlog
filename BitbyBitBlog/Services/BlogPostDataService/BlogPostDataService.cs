using BitbyBitBlog.Models;
using System;
using System.IO;
using System.Text;
using System.Text.Json;

namespace BitbyBitBlog.Services.BlogPostDataService
{
    public class BlogPostDataService : IReadBlogPostData
    {
        private readonly string _filePath;

        // Constructor
        public BlogPostDataService(string filePath)
        {
            _filePath = filePath ?? throw new ArgumentNullException(nameof(filePath));
        }

        public BlogPost Read() 
        {
            var jsonString = File.ReadAllText(_filePath);
            
            return JsonSerializer.Deserialize<BlogPost>(jsonString);
        }
    }
}
