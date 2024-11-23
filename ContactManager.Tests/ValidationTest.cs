using ContactManager.Data;
using FluentAssertions;

namespace ContactManager.Tests
{
    [TestFixture]
    public class ValidationTest
    {

        [TestCase("John Smith", "01/01/2000", "1234567890", "johnsmith@test.com", Description = "All arguments are included")]
        public void PersonValidator_WhenAllArgumentsProvided_ReturnsValid(string name, string birthdate, string phone, string email)
        {
            bool expectedValidationBool = true;
            var person = new Person(name, birthdate, phone, email, 1);
            
            var result = Person.PersonValidator.Validate(person).IsValid;

            result.Should().Be(expectedValidationBool);
        }

        [TestCase("John Smith", "01/01/2000", "04235847297", "", Description = "Email is empty")] 
        [TestCase("John Smith", "01/01/2000", "", "johnsmith@test.com", Description = "Phone is empty")] 
        [TestCase("John Smith", "", "1234567890", "johnsmith@test.com", Description = "Birthdate is empty")] 
        [TestCase("", "01/01/2000", "1234567890", "johnsmith@test.com", Description = "Name is empty")]
        [TestCase("", "", "", "", Description = "All arguments empty")]
        public void PersonValidator_WhenEmptyArguments_ReturnsInvalid(string name, string birthdate, string phone, string email)
        {
            bool expectedValidationBool = false;
            var person = new Person(name, birthdate, phone, email, 1);

            var result = Person.PersonValidator.Validate(person).IsValid;

            result.Should().Be(expectedValidationBool);
        }
    }
}