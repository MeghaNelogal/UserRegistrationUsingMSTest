using UserRegistrationUsingMSTest;

namespace DetailValidation
{
    [TestClass]
    public class TestValidation
    {
        [TestMethod]
        public void GivenInputIsString_WhenTestFirstName_ShouldReturnFirstName()
        {
            Validation validation = new Validation();
            string actual = validation.ValidateFirstName("Megha");
            Assert.AreEqual(actual, "Megha");
        }
        [TestMethod]
        public void GivenInputIsString_WhenTestLastName_ShouldReturnLastName()
        {
            Validation validation = new Validation();
            string actual = validation.ValidateLastName("Nelogal");
            Assert.AreEqual(actual, "Nelogal");
        }

        [TestMethod]
        public void GivenInputIsString_WhenTestEmail_ShouldReturnEmail()
        {
            Validation validation = new Validation();
            string actual = validation.ValidateEmail("meghanelogal@gmail.co.in");
            Assert.AreEqual(actual, "meghanelogal@gmail.co.in");
        }
        [TestMethod]
        public void GivenInputIsString_WhenTestMobileNumber_ShouldReturnMobileNumber()
        {
            Validation validation = new Validation();
            string actual = validation.ValidateMobileNumber("+91 9008088513");
            Assert.AreEqual(actual, "+91 9008088513");
        }
    }
}

   
