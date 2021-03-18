using System;

namespace Challenge
{
    public class FileProcessor
    {
        protected AbstractFileProcessor fileProcessorExample;

        public FileProcessor(AbstractFileProcessor fileProcessorExample)
        {
            this.fileProcessorExample = fileProcessorExample;
        }

        public bool ProcessFile(string fileName)
        {
            return fileProcessorExample.ProcessFile(fileName);
        }

    }

}
