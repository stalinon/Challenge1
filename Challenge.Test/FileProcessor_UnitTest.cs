using Xunit;
using Challenge;
using System.IO;
using System.Linq;

namespace Challenge_Test
{
    public class FileProcessor_UnitTest
    {
        [Fact]
        public void ProcessFileText_UnitTest()
        {
            string expectedLastWord = "somestring";
            string fileName = @"C:\Users\aestriplex\source\repos\testChallenge\Challenge_UnitTest\example.txt";
            FileProcessor objectText = new FileProcessor(new TextFileProcessing());
            objectText.ProcessFile(fileName);
            string text = " ";
            using (var reader = new StreamReader(fileName))
            {
                text = reader.ReadToEnd();
            }
            string specSymb = "\r\n";
            string lastWord = text.Split(' ').LastOrDefault().TrimEnd(specSymb.ToCharArray());
            Assert.Equal(expectedLastWord, lastWord);
        }
        [Fact]
        public void ProcessFileHtml_UnitTest()
        {
            string expectedLastWord = "somestring";
            string fileName = @"C:\Users\aestriplex\source\repos\testChallenge\Challenge_UnitTest\example.txt";
            FileProcessor objectText = new FileProcessor(new TextFileProcessing());
            objectText.ProcessFile(fileName);
            string text = " ";
            using (var reader = new StreamReader(fileName))
            {
                text = reader.ReadToEnd();
            }
            string specSymb = "\r\n";
            string lastWord = text.Split(' ').LastOrDefault().TrimEnd(specSymb.ToCharArray());
            Assert.Equal(expectedLastWord, lastWord);
        }
        [Fact]
        public void ProcessFileJson_UnitTest()
        {
            string expectedLastWord = "somestring";
            string fileName = @"C:\Users\aestriplex\source\repos\testChallenge\Challenge_UnitTest\example.txt";
            FileProcessor objectText = new FileProcessor(new TextFileProcessing());
            objectText.ProcessFile(fileName);
            string text = " ";
            using (var reader = new StreamReader(fileName))
            {
                text = reader.ReadToEnd();
            }
            string specSymb = "\r\n";
            string lastWord = text.Split(' ').LastOrDefault().TrimEnd(specSymb.ToCharArray());
            Assert.Equal(expectedLastWord, lastWord);
        }
    }
}

