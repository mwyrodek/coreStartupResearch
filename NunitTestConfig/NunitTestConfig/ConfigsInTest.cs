using System;
using System.Text;
using Microsoft.Extensions.Configuration;
using NunitTestConfig.Fakes;
using NUnit.Framework;
using Tests.Fakes;

namespace Tests
{
    [TestFixture]
    public class ConfigsInTest
    {
        private IConfiguration _configuration;
        private DriverContext _context;

        [SetUp]
        public void Setup()
        {
#if PROD
            Environment.SetEnvironmentVariable("ASPNETCORE_ENVIRONMENT", "Prod");
#elif TEST
            Environment.SetEnvironmentVariable("ASPNETCORE_ENVIRONMENT", "Test");
#endif

            var env = System.Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");

            _configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", true, true)
                .AddJsonFile($"appsettings.{env}.json", true, true)
                .Build();

            var fakeWebDriver = new FakeWebDriver();
            _context = new DriverContext(_configuration, fakeWebDriver);

        }

        [Test]
        public void SimpleValueRead()
        {
            Console.WriteLine($" Hello { _configuration["Test"] } !");
            Assert.Pass();
        }

        [Test]
        public void SectionMapping()
        {
            var test = new User();           
            _configuration.GetSection("User").Bind(test);


            Console.WriteLine($"Login: {test.Login} Password: {test.Password}");

        }

        [Test]
        public void ExampleOfPseudWebDriver()
        {
            var fakePage = new FakePage(_context);

            fakePage.GetSomeDataFromConfig();
            fakePage.GetSomeObjectFromConfig();
        }
    }
}