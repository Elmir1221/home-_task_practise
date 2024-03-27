using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practise
{
    internal class ExampleFile
    {
        public async Task WriteToExistFile(string path, string text)
        {
            using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write)) 
            {
                using (StreamWriter wr = new StreamWriter(fs))
                {
                    //wr.WriteLine();
                  await  wr.WriteAsync(text);


                }
            }

            //StreamWriter wr = new StreamWriter(fs);

            

            //fs.Close();
            //wr.Close();
        }
        public void ReadFromFile(string path )
        {
            //    FileStream fs = new FileStream(path , FileMode.Open, FileAccess.Read);
            //    StreamReader st = new StreamReader(fs);

            //    string result = st.ReadToEnd();

            //    Console.WriteLine(result);

            //    st.Close();
            //    fs.Close();
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    string result = sr.ReadToEnd();

                    Console.WriteLine(result);
                }
            }

        }

        public void WriteToNewFile(string path, string text)
        {
            //FileStream fs = new FileStream("C: \\Users\\FA507XV\\Desktop\\HomeWork\\ss5.txt",FileMode.CreateNew, FileAccess.Write);
            ////StreamWriter var = new StreamWriter(fs);
            //byte[] datas = Encoding.UTF8.GetBytes("Hello Esgerxan Bey, how are you");
            try
            {
                using (FileStream fs = new FileStream("C: \\Users\\FA507XV\\Desktop\\HomeWork\\ss5.txt", FileMode.CreateNew, FileAccess.Write))
                {
                    byte[] datas = Encoding.UTF8.GetBytes(text);
                    fs.Write(datas, 0, datas.Length);
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

        }
    }
}
