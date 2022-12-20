using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Server_Backend.Controllers;
using System;

namespace ServerTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var attackController = new AttackController();

            var result = attackController.startAttack("5", "2");
            var okResult = result as OkObjectResult;

            Assert.AreEqual(97, okResult.Value);
        }
    }
}
