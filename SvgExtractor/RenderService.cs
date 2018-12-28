using System.Collections.Generic;
using System.IO;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SvgExtractor
{
    public class RenderService
    {
        public List<string> duet(string link)
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
            ChromeDriver driver = new ChromeDriver(chromeDriverService, chromeOptions);
            driver.Navigate().GoToUrl(link);
            System.Threading.Thread.Sleep(100);
            var list = WaitForLoad(driver);
            driver.Close();
            driver.Dispose();
            return list;
        }

        private List<string> WaitForLoad(IWebDriver driver, int timeoutSec = 100)
        {
            var sourceState = new List<string>();
            var source = driver.PageSource;
            source = source.Remove(source.IndexOf(@"</svg>") + 6).Substring(source.IndexOf("<svg"));
            sourceState.Add(source);
            bool loading = true;
            var i = 0;
            do
            {
                System.Threading.Thread.Sleep(timeoutSec);
                source = driver.PageSource;
                source = source.Remove(source.IndexOf(@"</svg>") + 6).Substring(source.IndexOf("<svg"));
                sourceState.Add(source);
                File.WriteAllText($"svg-{i}.svg", source);
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