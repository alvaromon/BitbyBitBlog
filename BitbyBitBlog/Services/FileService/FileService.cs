using System;
using Microsoft.JSInterop;
using System.Threading.Tasks;
using System.IO;

namespace BitbyBitBlog.Services.FileService
{
    public static class FileService
    {
        public async static Task SaveAsAsync(IJSRuntime js, string filePath)
        {
            var bytes = File.ReadAllBytes(filePath);
            await js.InvokeAsync<object>("saveAsFile", new FileInfo(filePath).Name, Convert.ToBase64String(bytes));
        }
    }
}
