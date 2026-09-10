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
                Email = "john.smith@example.com",
                Country = "USA"
            };

            var service = new CustomerService();

            // Act
            var result = service.GetFullName(customer);

            // Assert
            Assert.Equal("John Smith", result);
        }

        [Fact]
        public void GetCountry_ReturnsCustomerFullName()
        {
            // Arrange
            var customer = new Customer
            {
                Id = 1,
                FirstName = "John",
                LastName = "Smith",
                Email = "john.smith@example.com",
                Country = "USA"
            };

            var service = new CustomerService();

            // Act
            var result = service.GetCountry(customer);

            // Assert
            Assert.Equal("USA", result);
        }
    }
}
