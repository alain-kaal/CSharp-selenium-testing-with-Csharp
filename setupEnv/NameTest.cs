using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

class NameTest : Tests
{
    private IWebElement element;
    private string nameUrl;

    public NameTest()
    {
        nameUrl = "http://testing.todvachev.com/selectors/name/";
        driver.Navigate().GoToUrl(nameUrl);
        element = driver.FindElement(By.Name("myName"));
    }

    public void NameAttributCheck()
    {
        isElementDisplay();
        sortie();
    }

    public void isElementDisplay()
    {
        if (element.Displayed)
        {
            greenMessage("Okay gut Okay !!!");
        }
        else {
            redMessage("Bad - Mauvais !!");
        }
    }
}

