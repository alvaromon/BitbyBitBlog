using BitbyBitBlog.Models;
using Microsoft.AspNetCore.Components;
using MudBlazor;
using System.Threading.Tasks;

namespace BitbyBitBlog.Components
{
    public partial class BlogPostComponent
    {
        private CodeBlockTheme _customTheme = 0;

        [Parameter]
        public BlogPost BlogPost { get; set; } = new();

        protected override Task OnInitializedAsync()
        {
            _customTheme = CodeBlockTheme.DarkVioletBase16;
            return base.OnInitializedAsync();
        }
    }
}
