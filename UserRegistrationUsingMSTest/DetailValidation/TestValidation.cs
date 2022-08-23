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
    }
}