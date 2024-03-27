using practise.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practise.Services
{
    internal class FileService : IFileService
    {
        public async Task DeleteAsync(string path)
        {
            if (File.Exists(path))
            {
                File.Delete(path);
            }
        }

        public async Task<string> ReadFromFileAsync(string path)
        {
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
               using (StreamReader sr = new StreamReader(fs))
               {
                    return await sr.ReadToEndAsync();

                    //Console.WriteLine(result);
               }
            }
            

        }

        public async Task WriteToExistFile(string path, string text)
        {

            using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write))
            {
                using (StreamWriter wr = new StreamWriter(fs))
                {

                    await wr.WriteAsync(text);


                }
            }



        }

        public async Task WriteToNewFileAsync(string path, string text)
        {
            try
            {
                if (!File.Exists(path))
                {
                    using (FileStream fs = new FileStream("C: \\Users\\FA507XV\\Desktop\\HomeWork\\ss5.txt", FileMode.CreateNew, FileAccess.Write))
                    {
                        byte[] datas = Encoding.UTF8.GetBytes(text);
                        await fs.WriteAsync(datas, 0, datas.Length);
                    }
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
