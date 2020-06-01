using System;
using System.IO;

namespace Arquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\In\file.txt";
            FileStream fileStream = null;
            StreamReader stream = null;
            string result = "";
            try
            {
                //fileStream = new FileStream(path, FileMode.Open);
                //stream = new stream(fileStream);
                //OU
                stream = File.OpenText(path);
                string line = "";

                while (!stream.EndOfStream)
                {
                    line = stream.ReadLine();
                   // Console.WriteLine(line);
                    result = line;
                }

                Console.WriteLine("**********");
                Console.WriteLine(result);
                result = Path.GetFileName(path);


            }
            catch (Exception e)
            {
                Console.WriteLine("An error occurred!");
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (stream != null) stream.Close();
                if (fileStream != null) fileStream.Close();
            }
        }

        private static void ArquivoComFileInfo()
        {
            string sourcePath = @"D:\In\file.txt";
            //string targetPath = @"D:\Out\file.txt";

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                //fileInfo.MoveTo(targetPath);
                string[] lines = File.ReadAllLines(sourcePath);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("An error occured");
                Console.WriteLine(e.Message);
            }
        }
    }
}
