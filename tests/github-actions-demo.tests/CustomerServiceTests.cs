using github_actions_demo;

namespace github_actions_demo.tests
{
    public class CustomerServiceTests
    {
        [Fact]
        public void GetFullName_ReturnsCustomerFullName()
        {
            // Arrange
            var customer = new Customer
            {
                Id = 1,
                FirstName = "John",
                LastName = "Smith",
                Email = "john.smith@example.com"
            };

            var service = new CustomerService();

            // Act
            var result = service.GetFullName(customer);

            // Assert
            Assert.Equal("John Smith", result);
        }
    }
}
