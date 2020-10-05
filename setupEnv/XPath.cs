using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

class XPath : Tests
{
    private IWebElement xPathElement;

    private string xxPath;
    private string xPathUrl;

    public XPath()
    {
        /* Initialisation des chemins */
        xPathUrl = "http://testing.todvachev.com/selectors/css-path/";
        xxPath = "//*[@id=\"post-108\"]/div/figure/img";

        driver.Navigate().GoToUrl(xPathUrl);
        xPathElement = driver.FindElement(By.XPath(xxPath));
    }

    public void pathCheck(){
        isElementDisplay();
        sortie();
    }


    public void isElementDisplay()
    {
        string okay = "Ich kann  X-Path Element sehen. Sogar anfassen !!!";
        string problem = "Kein X-Path Element in sicht. nur Bla bla ...";

        if (xPathElement.Displayed)
        {
            greenMessage(okay);
        }
        else
        {
            redMessage(problem);
        }
    }
}


