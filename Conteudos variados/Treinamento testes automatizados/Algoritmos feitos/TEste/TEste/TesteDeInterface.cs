using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

using System.IO;
using System.Reflection;

namespace TEste
{       
    [TestFixture]
    public class TesteDeInterface
    {

        [Test]
        public void TesteChrome()
        {
            var diretorio = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

            //IWebDriver driver = new ChromeDriver(diretorio)
            //driver.Navigate().GoToUrl("http://www.google.com.br/");


            using (IWebDriver driver = new ChromeDriver(diretorio))
            {
                driver.Navigate().GoToUrl("http://www.google.com.br/");

                By elementoCampoDePesquisa = By.Name("q");
                IWebElement campoPesquisa = driver.FindElement(elementoCampoDePesquisa);

                By elementoBotalPesquisa = By.Name("btnK");
                IWebElement botaoPesquisa = driver.FindElement(elementoBotalPesquisa);

                //By elEntrarSite = By.CssSelector(".LC20lb.DKV0Md");
                //IWebElement entrarSite = driver.FindElement(elEntrarSite);

                campoPesquisa.SendKeys("LG lugar de Gente");

                botaoPesquisa.Submit();

                var site = driver.PageSource.Contains("https://www.lg.com.br") ? true : false;

                Assert.IsTrue(site); // testa se a informação existe 


                //entrarSite.Click();

              
                driver.Quit();
            }
        }

        [Test]
        public void TesteFirefox ()
        {

        }


    }
}
