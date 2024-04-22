using OpenQA.Selenium;
using SauceDemo.Pages;

namespace SauceDemo.Tests
{
    public class WindowsPageTest : BaseTest
    {
        [SetUp]
        public void Setup()
        {
            Driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/windows");
        }

        [Test]
        public void CheckOpenNewWindowTest()
        {
            var WindowsPage = new WindowsPage(Driver);
            var generalWindowHandle = Driver.CurrentWindowHandle;

            WindowsPage.OpenNewWindowBtn().Click();
            Driver.SwitchTo().Window(Driver.WindowHandles.Last());

            Assert.Multiple(() =>
            {
                Assert.That(Driver.WindowHandles.Count == 2);
                Assert.That(Driver.FindElement(By.XPath("//div/h3")).Text, Is.EqualTo("New Window"));
            });
        }
    }
}
