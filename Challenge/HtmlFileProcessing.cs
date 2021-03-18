using System;
using System.IO;

namespace Challenge
{
    public class HtmlFileProcessing : AbstractFileProcessor
    {
        protected override string FileFormat
        {
            get { return ".html"; }
        }

        protected override void FileContentProcessing(string fileName)
        {
            string text = "";
            try
            {
                //обработка содержимого файла
                Console.WriteLine($"Processing of {Path.GetFileName(fileName)} started.");
                using (var reader = new StreamReader(fileName))
                {
                    text = reader.ReadToEnd() + " somestring";
                }
                using (StreamWriter writer = new StreamWriter(fileName))
                {
                    writer.WriteLine(text);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
