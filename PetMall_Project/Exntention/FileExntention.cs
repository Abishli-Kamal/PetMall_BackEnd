using Microsoft.AspNetCore.Http;

namespace PetMall_Project.Exntention
{
    public static class FileExntention
    {
        public static bool IsOkay(this IFormFile file,int mb)
        {
            return file.ContentType.Contains("image") && file.Length < mb * 1024 * 1024;
        }
    }
}
