using System;
using Microsoft.JSInterop;
using System.Threading.Tasks;
using System.IO;
using System.Net.Http;
using Microsoft.AspNetCore.Components;

namespace BitbyBitBlog.Services.FileService
{
    public class FileService
    {
        [Inject]
        private HttpClient _client { get; set; }

        // Constructor
        public FileService(HttpClient client)
        {
            _client = client ?? throw new ArgumentNullException(nameof(client));
        }

        public async Task SaveAsAsync(IJSRuntime js, string filePath)
        {
            var bytes = await _client.GetByteArrayAsync(filePath);
            await js.InvokeAsync<object>("saveAsFile", Path.GetFileName(filePath), Convert.ToBase64String(bytes));
        }
    }
}
