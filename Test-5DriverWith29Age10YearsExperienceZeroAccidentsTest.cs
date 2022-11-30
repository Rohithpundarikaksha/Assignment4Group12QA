// Generated by Selenium IDE
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;
[TestFixture]
public class DriverWith29Age10YearsExperienceZeroAccidentsTest {
  private IWebDriver driver;
  public IDictionary<string, object> vars {get; private set;}
  private IJavaScriptExecutor js;
  [SetUp]
  public void SetUp() {
    driver = new ChromeDriver();
    js = (IJavaScriptExecutor)driver;
    vars = new Dictionary<string, object>();
  }
  [TearDown]
  protected void TearDown() {
    driver.Quit();
  }
  [Test]
  public void driverWith29Age10YearsExperienceZeroAccidents() {
    driver.Navigate().GoToUrl("http://localhost/prog8170a04/");
    driver.Manage().Window.Size = new System.Drawing.Size(658, 752);
    driver.FindElement(By.CssSelector(".btn")).Click();
    driver.FindElement(By.Id("firstName")).Click();
    driver.FindElement(By.Id("firstName")).SendKeys("sai ");
    driver.FindElement(By.Id("lastName")).Click();
    driver.FindElement(By.Id("lastName")).SendKeys("krishna");
    driver.FindElement(By.Id("address")).Click();
    driver.FindElement(By.Id("address")).SendKeys("544 glen forrest");
    driver.FindElement(By.Id("city")).Click();
    driver.FindElement(By.Id("city")).SendKeys("waterloo");
    driver.FindElement(By.Id("province")).Click();
    driver.FindElement(By.Id("postalCode")).Click();
    driver.FindElement(By.Id("postalCode")).SendKeys("N2L 4H9");
    driver.FindElement(By.Id("phone")).Click();
    driver.FindElement(By.Id("phone")).SendKeys("123-123-1234");
    driver.FindElement(By.Id("email")).Click();
    driver.FindElement(By.Id("email")).SendKeys("sai@gmail.com");
    driver.FindElement(By.CssSelector(".card-body")).Click();
    driver.FindElement(By.Id("age")).Click();
    driver.FindElement(By.Id("age")).SendKeys("29");
    driver.FindElement(By.Id("experience")).Click();
    driver.FindElement(By.Id("experience")).SendKeys("10");
    driver.FindElement(By.Id("accidents")).Click();
    driver.FindElement(By.Id("accidents")).SendKeys("0");
    driver.FindElement(By.Id("btnSubmit")).Click();
    {
      string value = driver.FindElement(By.Id("finalQuote")).GetAttribute("value");
      Assert.That(value, Is.EqualTo("$1800"));
    }
  }
}
