using MudBlazor;

namespace BitbyBitBlog.Shared
{
    public partial class MainLayout
    {
        private MudTheme _currentTheme = new MudTheme();
        private readonly MudTheme _defaultTheme = new MudTheme()
        {
            Palette = new Palette()
            {
                Primary = Colors.Indigo.Default,
                Secondary = Colors.Pink.Default,
                Background = Colors.Grey.Default
            }
        };
    }
}
