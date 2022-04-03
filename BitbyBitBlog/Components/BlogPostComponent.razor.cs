using BitbyBitBlog.Models;
using Microsoft.AspNetCore.Components;

namespace BitbyBitBlog.Components
{
    public partial class BlogPostComponent
    {
        [Parameter]
        public BlogPost BlogPost { get; set; }
    }
}
