using Microsoft.VisualStudio.TestTools.UnitTesting;
using FinalProject;

namespace PhoneTest
{
    [TestClass]
    public class IPhoneTest
    {
        [TestMethod]
        public void Iphone_MobilePhone_And_RadioPhone_Properties_In_Constructor_Are_Acces()
        {
            IPhone mobilePhone = new MobilePhone("iPhone 14", "Apple", 48999, "Нічний", 512);
            IPhone radioPhone = new RadioPhone("IP-DECT Panasonic KX-TGP600", "Panasonic", 3294, 450, true);

            Assert.AreEqual(mobilePhone.Name, "iPhone 14");
            Assert.AreEqual(mobilePhone.Company, "Apple");
            Assert.AreEqual(mobilePhone.Price, 48999);

            Assert.AreEqual(radioPhone.Name, "IP-DECT Panasonic KX-TGP600");
            Assert.AreEqual(radioPhone.Company, "Panasonic");
            Assert.AreEqual(radioPhone.Price, 3294);
        }
    }
}
