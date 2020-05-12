using System;
//using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

class EntryPoint : Tests
{
    
    private IWebElement element;

    public EntryPoint()
    {
        
    }

    static void Main()
    {
         EntryPoint ep = new EntryPoint();
        ep.NameAttributCheck();
        

    }

    public void NameAttributCheck() {
        String nameUrl = "http://testing.todvachev.com/selectors/name/";
        driver.Navigate().GoToUrl(nameUrl);
        element = driver.FindElement(By.Name("myName"));

        isElementDisplay();

        sortie();
    }

    public void isElementDisplay() {
        if (element.Displayed)
        {
            greenMessage("Okay gut Okay !!!");
        }
        else
        {
            redMessage("Bad - Mauvais !!");
        }
    }

    public void basicTest()
    {
        IWebDriver driver = new ChromeDriver();
        driver.Navigate().GoToUrl("http://testing.todvachev.com/");
        sortie();
    }
}

