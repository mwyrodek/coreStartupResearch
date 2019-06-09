using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using Tests;

namespace NunitTestConfig.Fakes
{
    public class FakePage
    {
        private DriverContext context;

        public FakePage(DriverContext context)
        {
            this.context = context;
        }


        public void GetSomeDataFromConfig()
        {
            Console.WriteLine($" Hello { context.Configuration["Test"] } !");
        }

        public void GetSomeObjectFromConfig()
        {
            var contextUserFromConfig = context.UserFromConfig;
            Console.WriteLine($"Login: {contextUserFromConfig.Login} Password: {contextUserFromConfig.Password}");
        }
        
    }
}
