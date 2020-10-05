using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

class CssPath : Tests
{
    private IWebElement cssPathElement;

    private string cssPath;
    private string cssPathUrl;

    public CssPath()
    {
        /* Initialisation des chemins */
        cssPathUrl = "http://testing.todvachev.com/selectors/css-path/";
        cssPath = "#post-108 > div > figure > img";

        driver.Navigate().GoToUrl(cssPathUrl);

        cssPathElement = driver.FindElement(By.CssSelector(cssPath));
    }

    public void pathCheck()
    {
        isElementDisplay();
        sortie();
    }

    public void isElementDisplay(){

        string okay = "", problem = "";
        okay = "Ich kann CSS Path Element sehen. Sogar anfassen !!!";
        problem = "keinen CSS Path Element in Sicht. nur Bla bla ...";

        if (cssPathElement.Displayed)
        {
            greenMessage(okay);
        }
        else
        {
            redMessage(problem);
        }
    }
}


