using Microsoft.VisualStudio.TestTools.UnitTesting;
using FinalProject;

namespace PhoneTest
{
    [TestClass]
    public class MobilePhoneTest
    {
        [TestMethod]
        public void MobilePhone_Properties_In_Constructor_Are_Acces()
        {
            MobilePhone mobilePhone = new MobilePhone("iPhone 14", "Apple", 48999, "Нічний", 512);

            Assert.AreEqual(mobilePhone.Name, "iPhone 14");
            Assert.AreEqual(mobilePhone.Company, "Apple");
            Assert.AreEqual(mobilePhone.Price, 48999);
            Assert.AreEqual(mobilePhone.Color, "Нічний");
            Assert.AreEqual(mobilePhone.MemorySize, 512);
        }
    }
}
