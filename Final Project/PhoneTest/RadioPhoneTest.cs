using Microsoft.VisualStudio.TestTools.UnitTesting;
using FinalProject;

namespace PhoneTest
{
    [TestClass]
    public class RadioPhoneTest
    {
        [TestMethod]
        public void RadioPhone_Properties_In_Constructor_Are_Acces()
        {
            RadioPhone radioPhone = new RadioPhone("IP-DECT Panasonic KX-TGP600", "Panasonic", 3294, 450, true);

            Assert.AreEqual(radioPhone.Name, "IP-DECT Panasonic KX-TGP600");
            Assert.AreEqual(radioPhone.Company, "Panasonic");
            Assert.AreEqual(radioPhone.Price, 3294);
            Assert.AreEqual(radioPhone.RadiusAction, 450);
            Assert.AreEqual(radioPhone.AnsweringMachine, true);
        }
    }
}
