using Xunit;
using Challenge;
namespace Challenge_Test
{
    public class FileProcessor_UnitTest
    {
        [Fact]
        public void ProcessFileText_UnitTest()
        {
            string fileName = @"C:\Users\aestriplex\source\repos\testChallenge\Challenge_UnitTest\example.txt";
            FileProcessor objectText = new FileProcessor(new TextFileProcessing());
            Assert.True(objectText.ProcessFile(fileName));
        }
        [Fact]
        public void ProcessFileHtml_UnitTest()
        {
            string fileName = @"C:\Users\aestriplex\source\repos\testChallenge\Challenge_UnitTest\example.html";
            FileProcessor objectText = new FileProcessor(new HtmlFileProcessing());
            Assert.True(objectText.ProcessFile(fileName));
        }
        [Fact]
        public void ProcessFileJson_UnitTest()
        {
            string fileName = @"C:\Users\aestriplex\source\repos\testChallenge\Challenge_UnitTest\example.json";
            FileProcessor objectText = new FileProcessor(new JsonFileProcessing());
            Assert.True(objectText.ProcessFile(fileName));
        }
    }
}

