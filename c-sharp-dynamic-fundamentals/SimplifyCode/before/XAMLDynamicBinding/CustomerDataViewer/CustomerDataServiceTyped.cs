namespace CustomerDataViewer
{
    static class CustomerDataServiceTyped
    {
        public static Customer GetCustomerData()
        {
            // Simulate getting data from external service

            return new Customer
            {
                FirstName = "Gentry",
                SecondName = "Jones",
                Height = 170,
                Age = 33
            };
        }
    }
}
