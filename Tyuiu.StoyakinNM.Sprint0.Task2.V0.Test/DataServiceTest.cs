using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.StoyakinNM.Sprint0.Task2.V0.Lib;

namespace Tyuiu.StoyakinNM.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Никита";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет..., Никита", res);
        }
    }
}
