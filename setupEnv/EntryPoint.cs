using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

class EntryPoint
{
    IWebDriver driver;

    public EntryPoint()
    {
        driver = new ChromeDriver();
    }

    static void Main()
    {
         EntryPoint ep = new EntryPoint();
        ep.NameAttributCheck();
        

    }

    private void NameAttributCheck() {
        String nameUrl = "http://testing.todvachev.com/selectors/name/";
        //IWebDriver driver = new ChromeDriver();
        driver.Navigate().GoToUrl(nameUrl);
        IWebElement element = driver.FindElement(By.Name("myName"));
        if (element.Displayed)
        {
            Console.WriteLine("Okay gut Okay !!!");
        }
        else
        {
            Console.WriteLine("Bad - Mauvais !!");
        }

        Thread.Sleep(3000);
        driver.Quit();
    }

    private void basicTest()
    {
        IWebDriver driver = new ChromeDriver();
        driver.Navigate().GoToUrl("http://testing.todvachev.com/");
        Thread.Sleep(3000);
        driver.Quit();
    }
}

