using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practise.Extentions
{
    internal static class FileExtention
    {
        public static string GenerateFullPath(this string path, string fileName)
        {
            return $"{path}\\{fileName}";
        }
    }
}
