using Microsoft.Extensions.Configuration;
using OpenQA.Selenium;

namespace Tests
{
    public class DriverContext
    {
        public IConfiguration Configuration { get; private set; }
        public IWebDriver Driver{ get; private set; }

        public User UserFromConfig
        {
            get
            {
                var test = new User();
                Configuration.GetSection("User").Bind(test);
                return test;
            }
        
    }

        public DriverContext(IConfiguration configuration, IWebDriver driver)
        {
            Configuration = configuration;
            Driver = driver;
        }
    }
}