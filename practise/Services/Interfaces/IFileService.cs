using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practise.Services.Interfaces
{
    internal interface IFileService
    {
        Task WriteToExistFile(string path, string text);
        Task<string> ReadFromFileAsync(string path);
        Task WriteToNewFileAsync(string path, string text);
        Task DeleteAsync(string path);
    }
}
