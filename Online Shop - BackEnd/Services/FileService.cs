using Online_Shop___BackEnd.Services.Interfaces;
using System.IO;

namespace Online_Shop___BackEnd.Services
{
    public class FileService : IFileService
    {
        public string ReadFile(string path, string body)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                body = reader.ReadToEnd();
            };

            return body;
        }
    }
}
