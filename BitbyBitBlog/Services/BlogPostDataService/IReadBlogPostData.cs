using BitbyBitBlog.Models;
using System.Threading.Tasks;

namespace BitbyBitBlog.Services
{
    public interface IReadBlogPostData
    {
        public Task<BlogPost> ReadAsync(string fileName);
    }
}
