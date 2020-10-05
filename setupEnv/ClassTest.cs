using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

class ClassTest : Tests
{
    private IWebElement element;
    private string classUrl;
    private string className;

    public ClassTest()
    {
        classUrl = "http://testing.todvachev.com/selectors/class-name/";
        className = "testClass";
        driver.Navigate().GoToUrl(classUrl);
        element = driver.FindElement(By.ClassName(className));
    }

    public void classCheck()
    {
        isElementDisplay();
        sortie();
    }
    public void displayElement()
    {
        greenMessage(element.Text);
        sortie();
    }

    public void isElementDisplay()
    {
        string okay = "Class is Da.Ich kann selbe es pruefen !!!";
        string problem = "Bad - Mauvais !!";

        if (element.Displayed){
            greenMessage(okay);
        }
        else{
            redMessage(problem);
        }
    }
}

