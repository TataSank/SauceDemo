using SauceDemo.Pages;
using System.Reflection;

namespace SauceDemo.Tests
{
    public class UploadFileTest : BaseTest
    {
        [SetUp]
        public void Setup()
        {
            Driver.Navigate().GoToUrl("https://formy-project.herokuapp.com/fileupload");
        }
        [Test]
        public void CheckUploadFileTest()
        {
            var UploadFilePage = new UploadFilePage(Driver);
            var filePath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Resources", "TextFile1.txt");
           
            UploadFilePage.InputBtn().SendKeys(filePath);
            UploadFilePage.ResetBtn().Click();
        }
    }
}
