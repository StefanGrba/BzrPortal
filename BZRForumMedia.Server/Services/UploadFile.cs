namespace BZRForumMedia.Server.Services
{
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Http;
    using System;
    using System.IO;
    using System.Threading.Tasks;

    public static class UploadFile
    {
        public static async Task<string> Upload(string folderPath, IFormFile file, IWebHostEnvironment _webHostEnvironment)
        {
            folderPath +=  Guid.NewGuid().ToString() + "_" + file.FileName;

            string serverFolder = Path.Combine(_webHostEnvironment.WebRootPath, folderPath);

            await file.CopyToAsync(new FileStream(serverFolder, FileMode.Create));
            return "/" + folderPath;
        }
    }
}
