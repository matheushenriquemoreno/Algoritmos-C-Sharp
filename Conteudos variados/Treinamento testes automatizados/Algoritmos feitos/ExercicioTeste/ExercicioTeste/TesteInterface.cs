using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using System.IO;
using System.Reflection;
using OpenQA.Selenium.Support.UI;
using System.Drawing.Imaging;

namespace ExercicioTeste
{
    [TestFixture]
    public class TesteInterface
    {

        [Test]
        public void BuscaCepChrome()
        {
            var diretorio = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

            var options = new ChromeOptions();

            options.AddArguments("--start-maximized");

           using (IWebDriver driver = new ChromeDriver(diretorio, options))
           {
                var time = new WebDriverWait(driver, new System.TimeSpan(0, 0, 30)); // cria um tempo maximo de 30 segundos
                var screenshot = (ITakesScreenshot)driver;

                driver.Navigate().GoToUrl("https://buscacepinter.correios.com.br/app/endereco/index.php");

                SalvarImagem(screenshot, diretorio, "PaginaInicial");

                IWebElement PesquisaCep = driver.FindElement(By.Name("endereco"));

                PesquisaCep.SendKeys("74934600");

                IWebElement BuscaCep = driver.FindElement(By.Id("btn_pesquisar"));

                BuscaCep.Click(); // .submit()

                time.Until(d => d.FindElement(By.CssSelector("#resultado-DNEC")).Displayed);
                
                var cidade = driver.FindElement(By.CssSelector("#resultado-DNEC > tbody > tr > td:nth-child(3)"));
                var resultado = cidade.Text;

                // var site = driver.PageSource.Contains("Aparecida de Goiânia/GO") ? true : false; 

                 Assert.AreEqual("Aparecida de Goiânia/GO", resultado);

                driver.Quit();
           }
        }

        private void SalvarImagem(ITakesScreenshot screenshot, string diretorio, string nomeDoArquivo)
        {
            var diretorioDeImagens = Path.Combine(diretorio, "Imagens");

            if (!Directory.Exists(diretorioDeImagens))
            {
                Directory.CreateDirectory(diretorioDeImagens);
            }

            var arquivo = Path.Combine(diretorioDeImagens, nomeDoArquivo + "atual.png");
            var print = screenshot.GetScreenshot();

            print.SaveAsFile(arquivo, ImageFormat.Png);

        }

    }
}
