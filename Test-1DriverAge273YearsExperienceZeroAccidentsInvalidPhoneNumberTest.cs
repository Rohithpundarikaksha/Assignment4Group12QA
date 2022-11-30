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
public class DriverAge273YearsExperienceZeroAccidentsInvalidPhoneNumberTest {
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
  public void driverAge273YearsExperienceZeroAccidentsInvalidPhoneNumber() {
    driver.Navigate().GoToUrl("http://localhost/prog8170a04/index.html");
    driver.Manage().Window.Size = new System.Drawing.Size(1936, 1048);
    driver.FindElement(By.CssSelector(".btn")).Click();
    driver.FindElement(By.Id("firstName")).Click();
    driver.FindElement(By.Id("firstName")).SendKeys("Samanta");
    driver.FindElement(By.Id("lastName")).Click();
    driver.FindElement(By.Id("lastName")).SendKeys("RuthPrabhu");
    driver.FindElement(By.Id("address")).Click();
    driver.FindElement(By.Id("address")).SendKeys("34 Lambard Street");
    driver.FindElement(By.Id("city")).Click();
    driver.FindElement(By.Id("city")).SendKeys("Kitchener");
    driver.FindElement(By.Id("province")).Click();
    driver.FindElement(By.Id("postalCode")).Click();
    driver.FindElement(By.Id("postalCode")).SendKeys("N2A 1Jk");
    driver.FindElement(By.Id("phone")).Click();
    driver.FindElement(By.Id("phone")).SendKeys("1234567890");
    driver.FindElement(By.Id("email")).Click();
    driver.FindElement(By.Id("email")).SendKeys("Akkinenei@gmail.com");
    driver.FindElement(By.CssSelector(".card:nth-child(3) > .card-header")).Click();
    driver.FindElement(By.Id("age")).Click();
    driver.FindElement(By.Id("age")).SendKeys("27");
    driver.FindElement(By.Id("experience")).Click();
    driver.FindElement(By.Id("experience")).SendKeys("3");
    driver.FindElement(By.Id("accidents")).Click();
    driver.FindElement(By.Id("accidents")).SendKeys("0");
    driver.FindElement(By.Id("btnSubmit")).Click();

    driver.FindElement(By.Id("postalCode")).SendKeys("N2A 1J4");
    driver.FindElement(By.CssSelector(".container")).Click();
    Assert.That(driver.FindElement(By.Id("phone-error")).Text, Is.EqualTo("Phone Number must follow the patterns 111-111-1111 or (111)111-1111"));
  }
}
