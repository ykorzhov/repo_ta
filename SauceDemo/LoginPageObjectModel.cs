using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SauceDemo
{
    internal class LoginPageObjectModel
    {
        private readonly IWebDriver driver;
    }
    public LoginPageObjectModel(IWebDriver driver)
    {
        this.driver = driver;
    }
}
