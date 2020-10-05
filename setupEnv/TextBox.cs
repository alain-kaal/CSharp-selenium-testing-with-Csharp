/* the methods clearTest() & getValueTest() dont work !!*/
using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

class TextBox : Tests
{
    private IWebElement textBoxElement;

    private string textBoxName;
    private string textBoxUrl;

    public TextBox()
    {

        /* Initialisation de l'url et du chemins */
        string domaine = "http://testing.todvachev.com/";
        string specialElement = "special-elements/text-input-field/";
        textBoxUrl = domaine + specialElement;

        textBoxName = "username";

        try
        {
            driver.Navigate().GoToUrl(textBoxUrl);
            textBoxElement = driver.FindElement(By.Name(textBoxName));
           
        }
        catch (NoSuchElementException){
            redMessage("I cannot see the text box attribut ! ");
        }
    }

    public void pathCheck()
    {
        isElementDisplay();
       
        sortie();
    }

    public void eingabeTest(){
        textBoxElement.SendKeys("Haku Kaku ... als Eingabe. ");
        sortie();
    }
    
    public void clearTest()
    {
        textBoxElement.Clear();  
    }

    public void getValueTest()
    {
        Console.WriteLine(textBoxElement.GetAttribute("value"));
        
    }



    public void isElementDisplay()
    {

        string okay = "", problem = "";
        okay = "Ich kann CSS Path Element sehen. Sogar anfassen !!!";
        problem = "keinen CSS Path Element in Sicht. nur Bla bla ...";

        if (textBoxElement.Displayed)
        {
            greenMessage(okay);
        }
        else
        {
            redMessage(problem);
        }
    }
}




