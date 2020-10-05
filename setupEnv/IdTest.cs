using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

class IdTest : Tests
{
    private IWebElement element;
    private string IdUrl;
    private string ID;

    public IdTest()
    {
        IdUrl = "http://testing.todvachev.com/selectors/id/";
        ID = "testImage";
        driver.Navigate().GoToUrl(IdUrl);
        element = driver.FindElement(By.Id(ID));
    }

    public void IdCheck()
    {
        isElementDisplay();
        sortie();
    }

    public void isElementDisplay()
    {
        string okay = "ID is Da.Ich habe selbe gesehen !!!";
        string problem = "Bad - Mauvais !!";

        if (element.Displayed){
            greenMessage(okay);
        }
        else {
            redMessage(problem);
        }
    }
}

