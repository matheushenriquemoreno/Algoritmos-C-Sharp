using System.Drawing.Imaging;
using System.IO;
using System.Reflection;

using ImageMagick;

using NUnit.Framework;

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace TesteInterface
{
    [TestFixture]
    public class TesteDeInterface
    {
        [Test]
        public void TesteChrome()
        {
            var diretorio = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

            using (IWebDriver driver = new ChromeDriver(diretorio))
            {
                driver.Navigate().GoToUrl("http://www.google.com.br");

                By elCampoDePesquisa = By.Name("q");
                IWebElement campoPesquisa = driver.FindElement(elCampoDePesquisa);

                By elBotaoPesquisa = By.Name("btnK");
                IWebElement botaoPesquisa = driver.FindElement(elBotaoPesquisa);

                campoPesquisa.SendKeys("LG Lugar de Gente");

                botaoPesquisa.Submit();

                var site = driver.PageSource.Contains("Avenida Quadra 1 B, Lote 22 e 31") ? true : false;

                Assert.IsTrue(site);

                driver.Quit();
            }
        }

        [Test]
        public void TesteBuscaCEP()
        {
            var diretorio = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

            var options = new ChromeOptions();

            options.AddArguments("--start-maximized");

            using (IWebDriver driver = new ChromeDriver(diretorio, options))
            {
                var time = new WebDriverWait(driver, new System.TimeSpan(0, 0, 30));

                var screenshot = (ITakesScreenshot)driver;


                driver.Navigate().GoToUrl("https://buscacepinter.correios.com.br/app/endereco/index.php");

                SalvarImagem(screenshot, diretorio, "PaginaInicial");

                //// Campo de CEP
                IWebElement CEP = driver.FindElement(By.Id("endereco"));

                //// Botao Pesquisa
                IWebElement botaoPesquisa = driver.FindElement(By.Id("btn_pesquisar"));

                CEP.SendKeys("74934700");
                botaoPesquisa.Click();

                //Thread.Sleep(2000);

                time.Until(d => d.FindElement(By.CssSelector("#resultado #resultado-DNEC")).Displayed);

                var cidade = driver.FindElement(By.CssSelector("#resultado-DNEC > tbody > tr > td:nth-child(3)"));
                var resultado = cidade.Text;

                Assert.AreEqual("Aparecida de Goiânia/GO", resultado);

                SalvarImagem(screenshot, diretorio, "Resultado");

                CompararScreenshot(diretorio);

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

            var arquivo = Path.Combine(diretorioDeImagens, nomeDoArquivo + ".atual.png");
            var print = screenshot.GetScreenshot();

            print.SaveAsFile(arquivo, ImageFormat.Png);
        }

        private void CompararScreenshot(string diretorio)
        {
            var numeroDeErros = 0;

            var diretorioDeImagens = Path.Combine(diretorio, "Imagens");

            var arquivos = Directory.EnumerateFiles(diretorioDeImagens, "*.atual.png");

            foreach (var nomeArquivo in arquivos)
            {
                var arquivoAtual = Path.Combine(diretorioDeImagens, nomeArquivo);
                var arquivoOrigem = arquivoAtual.Substring(0, arquivoAtual.Length - ".atual.png".Length) + ".baseline.png";
                var arquivoDiff = arquivoAtual.Substring(0, arquivoAtual.Length - ".atual.png".Length) + ".diff.png";

                if (!File.Exists(arquivoOrigem))
                {
                    File.Move(arquivoAtual, arquivoOrigem);
                    continue;
                }
                using (var imagemOrigem = new MagickImage(arquivoOrigem))
                using (var imagemAtual = new MagickImage(arquivoAtual))
                using (var imagemDiferente = new MagickImage())
                {
                    imagemOrigem.ColorFuzz = new Percentage(1);
                    var diferenca = imagemOrigem.Compare(imagemAtual, ErrorMetric.PerceptualHash, imagemDiferente);

                    //// Verifica se existe diferença de imagem.
                    if (diferenca > 0.0006)
                    {
                        numeroDeErros++;
                        imagemDiferente.Write(arquivoDiff);
                        continue;
                    }

                    File.Delete(arquivoDiff);
                    File.Delete(arquivoAtual);
                }
            }

            Assert.AreEqual(0, numeroDeErros, "Existem imagens diferente do esperado.");
        }
    }
}
