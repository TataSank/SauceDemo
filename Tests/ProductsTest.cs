using SauceDemo.Helper;
using SauceDemo.Pages;


namespace SauceDemo.Tests
{
    public class ProductsTest : BaseTest
    {
        private LoginPage LoginPage;

        [SetUp]

        public void Setup()
        {
            LoginPage = new LoginPage(Driver);
        }

        [Test]
        public void DisplayProductDetailsByImg()
        {
            LoginPage.Login(Configurator.ReadConfiguration().UserStandardName, Configurator.ReadConfiguration().UserPassword);
            var ProductsPage = new ProductsPage(Driver);
            var ProductItemPage = new ProductsItemPage(Driver);
            ProductsPage.ProductImgFirst().Click();
            var expectedResult = "Sauce Labs Backpack";
            var actualresult = ProductItemPage.ProductItemFirstBy().Text;
            Assert.That(actualresult, Is.EqualTo(expectedResult));

        }

        [Test]
        public void DisplayProductDetailsByLabel()
        {
            LoginPage.Login(Configurator.ReadConfiguration().UserStandardName, Configurator.ReadConfiguration().UserPassword);
            var ProductsPage = new ProductsPage(Driver);
            var ProductItemPage = new ProductsItemPage(Driver);

            var expectedResult = "Sauce Labs Backpack";
            ProductsPage.ProductItemLabelFirst().Click();

            var actualresult = ProductItemPage.ProductItemFirstBy().Text;
            Assert.That(actualresult, Is.EqualTo(expectedResult));
        }

        [Test]
        public void AddToCartFirstItem()
        {
            LoginPage.Login(Configurator.ReadConfiguration().UserStandardName, Configurator.ReadConfiguration().UserPassword);
            var ProductsPage = new ProductsPage(Driver);

            ProductsPage.AddTocartBtn().Click();

            var actualresult = ProductsPage.CountProducts().Text;
            Assert.That(actualresult, Is.EqualTo("1"));

        }
    }
}
