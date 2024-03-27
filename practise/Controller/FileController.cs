using practise.Extentions;
using practise.Services;
using practise.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace practise.Controller
{
    internal class FileController
    {
        private readonly IFileService _fileService;

        public FileController()
        {
            _fileService = new FileService();
        }
        public async Task ReadDataAsync()
        {
            string result = await _fileService.ReadFromFileAsync("C: \\Users\\FA507XV\\Desktop\\HomeWork\\ss2.txt");
            Console.WriteLine(result);

            string data = AppDomain.CurrentDomain.BaseDirectory;
            var datas = data.Split("\\");
            var res = string.Empty;
            foreach (var item in datas)
            {
                if(item != "HomeWork")
                {
                    res += item + "\\";
                }
                else
                {

                }
            }
             res +=  "HomeWork";
            await Console.Out.WriteLineAsync(res);
        }

        public async Task CreateFileWithContentAsync()
        {
            string result = await _fileService.ReadFromFileAsync("C: \\Users\\FA507XV\\Desktop\\HomeWork\\ss2.txt");
            Console.WriteLine(result);

            string data = AppDomain.CurrentDomain.BaseDirectory;
            var datas = data.Split("\\");
            var path = string.Empty;
            foreach (var item in datas)
            {
                if (item != "HomeWork")
                {
                    path += item + "\\";
                }
                else
                {

                }
            }
            path += "HomeWork";
           

            await Console.Out.WriteLineAsync("add filename");
            string fileName = Console.ReadLine();  

            await Console.Out.WriteLineAsync("add text");
            string text = Console.ReadLine();

            string resultPath = path.GenerateFullPath(fileName);
            await _fileService.WriteToNewFileAsync(resultPath, text);

        }

        public async Task DeleteAsync()
        {
            await _fileService.DeleteAsync("C: \\Users\\FA507XV\\Desktop\\HomeWork\\ss7.txt");
        }
    }
}
