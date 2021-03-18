using System;
using System.IO;

namespace Challenge
{
    public abstract class AbstractFileProcessor
    {
        protected abstract string FileFormat { get; }

        protected abstract bool FileContentProcessing(string filename);

        public bool ProcessFile(string fileName)
        {
            if (File.Exists(fileName) && Path.GetExtension(fileName).Contains(FileFormat))
                return FileContentProcessing(fileName);
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
                return false;
            }
        }
    }
}
