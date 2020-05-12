using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


class Tests
    {
    protected IWebDriver driver;

    public Tests() {
        driver = new ChromeDriver();
    }
    protected static void redMessage(string message)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(message);
        Console.ForegroundColor = ConsoleColor.White;
    }
    protected static void greenMessage(string message)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(message);
        Console.ForegroundColor = ConsoleColor.White;
    }

    public void sortie()
    {
        Thread.Sleep(1000);
        driver.Quit();
    }
}

