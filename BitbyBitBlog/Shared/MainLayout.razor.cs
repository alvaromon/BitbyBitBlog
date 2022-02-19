using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using MudBlazor;
using System;
using System.Threading.Tasks;

namespace BitbyBitBlog.Shared
{
    public partial class MainLayout
    {
        [Inject]
        protected IJSRuntime JS { get; set; } = default!;

        [Inject]
        public NavigationManager NavigationManager { get; set; } = default!;

        private MudTheme _currentTheme = new MudTheme();
        private MudTheme _defaultTheme = new MudTheme();
        private bool _isDarkMode = true; // Dark mode on by default

        private MudTheme _darkModeTheme = new MudTheme() 
        { 
            Palette = new Palette()
            { 
                Background = "#32333d"
            }
        };

        //public void ChangeTheme()
        //{
        //    _isDarkMode = !_isDarkMode;
        //    StateHasChanged();
        //}

        //protected override async Task OnAfterRenderAsync(bool firstRender)
        //{
        //    if (firstRender)
        //    {
        //        var theme = await JS.InvokeAsync<string>("readCookie", "blog_theme");
        //        if (theme is not null && theme == "dark")
        //        {
        //            // could be ?
        //            //_currentTheme.Palette = _currentTheme.PaletteDark;
        //            _currentTheme = _darkModeTheme;
        //        }
        //    }

        //    StateHasChanged();
        //}

        private async Task ToggleThemeAsync()
        {
            string themeCookieValue;
            if (_currentTheme == _defaultTheme)
            {
                themeCookieValue = "dark";
                _currentTheme = _darkModeTheme;
            }
            else 
            {
                themeCookieValue = "light";
                _currentTheme = new MudTheme(); // fix this later
            }

            await JS.InvokeVoidAsync("writeCookie", "blog_theme", themeCookieValue, DateTime.Now.AddMonths(1));
        }

        private bool open;
        private void ToggleOpen()
        {
            open = !open;
        }

        private void Nav(string relativePath, EventArgs e)
        {
            open = false;
            NavigationManager.NavigateTo(relativePath);
        }
    }
}
