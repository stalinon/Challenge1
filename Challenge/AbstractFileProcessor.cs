using System;
using System.IO;

namespace Challenge
{
    public abstract class AbstractFileProcessor
    {
        protected abstract string FileFormat { get; }

        protected abstract bool FileContentProcessing(string filename); 
        //возвращает true, если обработка проведена успешно

        public void ProcessFile(string fileName)
        {
            if (File.Exists(fileName) && Path.GetExtension(fileName).Contains(FileFormat))
                FileContentProcessing(fileName);
            else
            {
                try
                {
                    Exception FileException = new Exception("Invalid 'filename' or file doesn't exists");
                    throw FileException;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
