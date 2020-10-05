using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

class CssPathXPath : Tests
{
    private IWebElement cssPathElement;
    private IWebElement xPathElement;

    private string cssPath;
    private string xxPath;
    private string cssPathUrl;

    public CssPathXPath()
    {
        /* Initialisation des chemins */
        cssPathUrl = "http://testing.todvachev.com/selectors/css-path/";
        xxPath = "//*[@id=\"post-108\"]/div/figure/img";
        cssPath = "#post-108 > div > figure > img";

        driver.Navigate().GoToUrl(cssPathUrl);

        cssPathElement = driver.FindElement(By.CssSelector(cssPath));
        xPathElement = driver.FindElement(By.XPath(xxPath));
    }

    public void pathCheck(IWebElement element)
    {
        isElementDisplay(element);
        sortie();
    }
 

    public void isElementDisplay(IWebElement element)
    {
        string okay = "", problem = "";
        if (element == xPathElement)
        {
            okay = "Ich kann  X-Path Element sehen. Sogar anfassen !!!";
            problem = "Habe keinen X-Path Element gesehen. nur Bla bla ...";
        }
        else if (element == cssPathElement){
            okay = "Ich kann CSS Path Element sehen. Sogar anfassen !!!";
            problem = "keinen CSS Path Element in Sicht. nur Bla bla ...";
        }
        
        if (element.Displayed){
            greenMessage(okay);
        }else{
            redMessage(problem);
        }
    }

        public IWebElement getCssPathElement()
        {
            return this.cssPathElement;
        }

        public IWebElement getXPathElement()
        {
            return this.xPathElement;
        }
}


