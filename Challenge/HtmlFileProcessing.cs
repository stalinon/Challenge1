using System;

namespace Challenge
{
    public class HtmlFileProcessing : AbstractFileProcessor
    {
        protected override string FileFormat
        {
            get { return ".html"; }
        }

        protected override bool FileContentProcessing(string fileName)
        {
            try
            {
                //обработка содержимого файла
                Console.WriteLine($"Processing of {System.IO.Path.GetFileName(fileName)} started.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            return true;
        }
    }
}
