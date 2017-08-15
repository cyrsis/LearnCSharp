using System.Dynamic;

namespace CustomerDataViewer
{
    static class CustomerDataServiceDynamic
    {
        public static dynamic GetCustomerData()
        {
            // Simulate getting data from external service

            dynamic customerData = new ExpandoObject();

            customerData.FirstName = "Gentry";
            customerData.SecondName = "Jones";
            customerData.Height = 170;
            customerData.Age = 33;

            return customerData;
        }
    }
}