using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SvgExtractor
{
    public class RenderService
    {
        public async Task<List<string>> duet(string link)
        {
            var chromeOptions = new ChromeOptions();
            chromeOptions.AddArguments(new List<string>()
            {
                "--silent-launch",
                "--no-startup-window",
                "no-sandbox",
                "headless",
            });

            var chromeDriverService = ChromeDriverService.CreateDefaultService();
            chromeDriverService.HideCommandPromptWindow = true; // This is to hidden the console. 
            var driver = new ChromeDriver(chromeDriverService, chromeOptions);
            driver.Navigate().GoToUrl(link);
            var list = await WaitForLoad(driver);
            driver.Close();
            driver.Dispose();
            return list;
        }

        private async Task<List<string>> WaitForLoad(IWebDriver driver, int timeoutSec = 10)
        {
            var sourceState = new List<string>();
            var source = driver.PageSource;
            source = source.Remove(source.IndexOf(@"</svg>") + 6).Substring(source.IndexOf("<svg"));
            sourceState.Add(source);
            bool loading = true;
            var i = 0;
            if (!Directory.Exists("Temp"))
            {
                Directory.CreateDirectory("Temp");
            }

            do
            {
                await Task.Delay(timeoutSec);
                source = driver.PageSource;
                source = source.Remove(source.IndexOf(@"</svg>") + 6).Substring(source.IndexOf("<svg"));
                sourceState.Add(source);
                Task.Factory.StartNew(async () =>
                {
                    var src = source;
                    var svgNumber = i;
                    File.WriteAllText($"Temp\\svg-{svgNumber}.svg", src);
                });
                if (sourceState[sourceState.Count - 2] == source)
                {
                    loading = false;
                    sourceState.RemoveAt(sourceState.Count - 1);
                }
                i++;
            } while (i < 100 && loading);

            return sourceState;
        }
    }
}