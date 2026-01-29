using Microsoft.VisualStudio.TestTools.UnitTesting;
using PetPortal;

namespace PetPortal.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void DoublesNumber_Input3_Returns9()
        {
            var portal = new PetPortal.PetPortal();
            int result = portal.DoublesNumber(3);
            Assert.AreEqual(9, result);
        }

        [TestMethod]
        public void DoublesNumber_Input5_Returns25()
        {
            var portal = new PetPortal.PetPortal();
            int result = portal.DoublesNumber(5);
            Assert.AreEqual(25, result);
        }
    }
}
