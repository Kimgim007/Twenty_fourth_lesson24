using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twenty_fourth_lesson24.WebDriver;

namespace Twenty_fourth_lesson24.Tests
{
    internal class BaseTest
    {
        [SetUp]
        public void SetUp()
        {
            Driver.GetDriver().Navigate().GoToUrl("https://demoqa.com/automation-practice-form");
        }
        [TearDown]
        public void TearDown()
        {
            Driver.TeareDown();
        }
    }
}
