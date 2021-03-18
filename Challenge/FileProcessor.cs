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

        public void ProcessFile(string fileName)
        {
            fileProcessorExample.ProcessFile(fileName);
        }

    }

}
