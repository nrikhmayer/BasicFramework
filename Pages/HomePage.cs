using OpenQA.Selenium;

namespace BasicFramework.Pages
{
    public class HomePage : BasePage
    {
        public HomePage(IWebDriver driver) : base(driver)
        {
        }

        private IWebElement HeaderTitle => Driver.FindElement(By.CssSelector(".title"));

        public string GetHeaderTitle()
        {
            return HeaderTitle.Text;
        }
    }
}