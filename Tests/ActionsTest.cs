using OpenQA.Selenium.Interactions;
using SauceDemo.Pages;

namespace SauceDemo.Tests
{
    public class ActionsTest : BaseTest
    {
        [SetUp]
        public void Setup()
        {
            Driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/context_menu");
        }
        [Test]
        public void CheckActionsTest()
        {
            var Actions = new Actions(Driver);
            var ActionPage = new ActionsPage(Driver);
            
            Actions
                .MoveToElement(ActionPage.HotSpot(), 5, 5)
                .ContextClick()
                .Build()
                .Perform();

            var allertText = Driver.SwitchTo().Alert();

            Assert.That(allertText.Text.Trim(), Is.EqualTo("You selected a context menu"));
        }
    }
}
