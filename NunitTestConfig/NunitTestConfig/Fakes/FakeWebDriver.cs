using System.Collections.ObjectModel;
using OpenQA.Selenium;

namespace Tests.Fakes
{
    
    public class FakeWebDriver : IWebDriver
    {
        public IWebElement FindElement(By @by)
        {
            throw new System.NotImplementedException("I am just fake for sake of preseting stuff");
        }

        public ReadOnlyCollection<IWebElement> FindElements(By @by)
        {
            throw new System.NotImplementedException("I am just fake for sake of preseting stuff");
        }

        public void Dispose()
        {
            throw new System.NotImplementedException("I am just fake for sake of preseting stuff");
        }

        public void Close()
        {
            throw new System.NotImplementedException("I am just fake for sake of preseting stuff");
        }

        public void Quit()
        {
            throw new System.NotImplementedException("I am just fake for sake of preseting stuff");
        }

        public IOptions Manage()
        {
            throw new System.NotImplementedException("I am just fake for sake of preseting stuff");
        }

        public INavigation Navigate()
        {
            throw new System.NotImplementedException("I am just fake for sake of preseting stuff");
        }

        public ITargetLocator SwitchTo()
        {
            throw new System.NotImplementedException("I am just fake for sake of preseting stuff");
        }

        public string Url { get; set; }
        public string Title { get; }
        public string PageSource { get; }
        public string CurrentWindowHandle { get; }
        public ReadOnlyCollection<string> WindowHandles { get; }
    }
}