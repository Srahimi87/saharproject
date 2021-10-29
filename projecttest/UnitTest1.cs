using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using libraryclass;
using saharproject.Controllers;
using System.Web.Mvc;

namespace projecttest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void testMethod1()
        {
            //Arrange
            HomeController controller = new HomeController();
            //Act
            ViewResult result = controller.Index() as ViewResult;

            //Assert
            //Assert.IsTrue(true);  
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void testmethod2()
        {

        }
    }
}
