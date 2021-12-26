using System.IO;

namespace WebApplication2.Models
{
    public interface IFromFile
    {
        string ContentType { get; set; }
        int Length { get; }
        string FileName { get; }

        void CopyTo(FileStream stream);
    }
}