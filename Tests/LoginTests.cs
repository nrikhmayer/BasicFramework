using System;
using BasicFramework.Framework;
using BasicFramework.Framework.Models;
using BasicFramework.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace BasicFramework.Tests
{
    [TestFixture]
    public class LoginTests : BaseTest
    {
        private User _user;
        private const string ProductTitle = "PRODUCTS";

        [SetUp]
        protected void Initialize()
        {
            _user = User.GetDefaultUser();
        }

        [Test]
        public void ValidLoginTest()
        {
            HomePage homePage = SiteNavigator.NavigateToLoginPage(Driver).Login(_user);

            Logger.Info("Wait example");
            WebDriverWait wait = new WebDriverWait(Driver, new TimeSpan(0, 0, 30));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.CssSelector(".peek")));

            Assert.AreEqual(ProductTitle, homePage.GetHeaderTitle(), "Title text differs from expected!");
        }
    }
}