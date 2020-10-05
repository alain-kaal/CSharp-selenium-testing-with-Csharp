/* the methods clearTest() & getValueTest() dont work !!*/
using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

class CheckBox : Tests
{
    private IWebElement checkBox;

    private string checkBoxName;
    private string checkBoxUrl;

    public CheckBox()
    {

        /* Initialisation de l'url et du chemins */
        string domaine = "http://testing.todvachev.com/";
        string specialElement = "special-elements/check-button-test-3/";
        checkBoxUrl = domaine + specialElement;

        string optionChild = "1"; // which checkbox will be selected
        string checkBox_01 = "#post-33 > div > p:nth-child(8) > input";
        string checkBox_02 = "[type=\"checkbox\"]:nth-child("+ optionChild +")";
        checkBoxName = checkBox_01 + checkBox_02;

        try
        {
            driver.Navigate().GoToUrl(checkBoxUrl);
            checkBox = driver.FindElement(By.CssSelector(checkBoxName));

        }
        catch (NoSuchElementException)
        {
            redMessage("I cannot see the check box attribut ! ");
        }
    }

    
    public void pathCheck()
    {
        isElementDisplay();

        sortie();
    }
    
    public void isChecked(){
        if (checkBox.GetAttribute("checked") == "true")
        {
            Console.WriteLine("The checbox is checked");
        }else{
            Console.WriteLine("The checbox is not checked");
        }
    }
    
    public void isElementDisplay()
    {

        string okay = "", problem = "";
        okay = "Ich kann CSS Path Element sehen. Sogar anfassen !!!";
        problem = "keinen CSS Path Element in Sicht. nur Bla bla ...";

        if (checkBox.Displayed){
            greenMessage(okay);
        } else{
            redMessage(problem);
        }
    }
    
}