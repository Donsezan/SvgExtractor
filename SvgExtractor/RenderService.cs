using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SvgExtractor
{
    public static class RenderService
    {
        public static async Task<List<string>> Start(string link)
        {
            var chromeOptions = new ChromeOptions();
            chromeOptions.AddArguments(new List<string>
            {
                "--silent-launch",
                "--no-startup-window",
                "no-sandbox",
                "headless"
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

        private static async Task<List<string>> WaitForLoad(IWebDriver driver, int timeoutSec = 0)
        {
            var sourceStateList = new List<string> {driver.PageSource};
            var loading = true;
            var limitCounter = 0;
            do
            {
                await Task.Delay(timeoutSec);
                var pageSource = driver.PageSource;
                sourceStateList.Add(pageSource);
                if (sourceStateList[sourceStateList.Count - 2].GetHashCode() == pageSource.GetHashCode())
                {
                    loading = false;
                    sourceStateList.RemoveAt(sourceStateList.Count - 1);
                }

                limitCounter++;
            } while (limitCounter < 100 && loading);

            var index = 0;
            foreach (var src in sourceStateList)
            {
                var svgCode = SeparateSvgInSource(src);
                File.WriteAllText($@"{Form1.TempFolder}\{Form1.FileExtension}-{index}.{Form1.FileExtension}", svgCode);
                index++;
            }

            return sourceStateList;
        }


        private static string SeparateSvgInSource(string source)
        {
            return source.Remove(source.IndexOf(@"</svg>", StringComparison.Ordinal) + 6)
                .Substring(source.IndexOf("<svg", StringComparison.Ordinal));
        }
    }
}