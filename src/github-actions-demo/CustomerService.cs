namespace github_actions_demo
{
    public class CustomerService
    {
        public string GetFullName(Customer customer)
        {
            return $"{customer.FirstName} {customer.LastName}";
        }

        public string GetCountry(Customer customer)
        {
            return $"{customer.Country}";
        }
    }
}
