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
    }
   
}