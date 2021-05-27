using BasicFramework.Framework.Models;
using OpenQA.Selenium;

namespace BasicFramework.Pages
{
    public class LoginPage : BasePage
    {
        public LoginPage(IWebDriver driver) : base(driver)
        {
        }

        private IWebElement UsernameBox => Driver.FindElement(By.Id("user-name"));

        private IWebElement PasswordBox => Driver.FindElement(By.Id("password"));

        private IWebElement LoginButton => Driver.FindElement(By.Id("login-button"));

        public HomePage Login(User user)
        {
            UsernameBox.SendKeys(user.Login);
            PasswordBox.SendKeys(user.Password);
            LoginButton.Click();
            return new HomePage(Driver);
        }
    }
}