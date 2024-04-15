using OpenQA.Selenium;
using SauceDemo.Helper;
using SauceDemo.Pages;


namespace SauceDemo.Tests
{
    public class LoginTest : BaseTest
    {

        [Test]
        public void LoginPositiveTest()

        {
            var loginPage = new LoginPage(Driver);
            var productPage = new ProductsPage(Driver);

            loginPage.Login(Configurator.ReadConfiguration().UserStandardName, Configurator.ReadConfiguration().UserPassword);

            Assert.That(productPage.ShoppingCart().Displayed, Is.True, "User is not login in ");
        }
        [Test]
        public void LoginWithoutPasswordTest()
        {
            var loginPage = new LoginPage(Driver);
            var expectedErrorMessage = "Epic sadface: Password is required";
            loginPage.UserNameField().SendKeys(Configurator.ReadConfiguration().UserStandardName);
            loginPage.SubmitButton().Click();
            var actualErrorMessage = Driver.FindElement(By.TagName("h3")).Text;

            Assert.That(actualErrorMessage, Is.EqualTo(expectedErrorMessage));
        }
        [Test]
        public void LoginWithoutUserNameTest()
        {
            var loginPage = new LoginPage(Driver);
            var expectedErrorMessage = "Epic sadface: Username is required";
            loginPage.UserPasswordField().SendKeys(Configurator.ReadConfiguration().UserPassword);
            loginPage.SubmitButton().Click();
            var actualErrorMessage = Driver.FindElement(By.TagName("h3")).Text;
            Thread.Sleep(3000);
            Assert.That(actualErrorMessage, Is.EqualTo(expectedErrorMessage));
        }
    }
}
