using OpenQA.Selenium;

namespace SauceDemo.Pages
{
    public class LoginPage : BasePage
    {
        private static readonly By UserNameFieldBy = By.XPath("//input[@data-test='username']");
        private static readonly By UserPasswordBy = By.CssSelector("[placeholder ='Password']");
        private static readonly By SubmitButtonBy = By.CssSelector("[type = 'Submit']");

        public LoginPage(IWebDriver driver) : base(driver)
        {
            Driver = driver;
        }
        protected IWebDriver Driver { get; set; }

        public IWebElement UserNameField() => Driver.FindElement(UserNameFieldBy);
        public IWebElement UserPasswordField() => Driver.FindElement(UserPasswordBy);
        public IWebElement SubmitButton() => Driver.FindElement(SubmitButtonBy);

        public void Login(string userName = "", string userPassword = "")
        {
            UserNameField().SendKeys(userName);
            UserPasswordField().SendKeys(userPassword);
            SubmitButton().Click();
        }
    }
}
