using Sixeyed.ExtensionLibrary.Domain.Model;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Sixeyed.ExtensionLibrary.Stubs.Api.Controllers
{
    public class CustomersController : ApiController
    {
        // GET api/customers
        public Customer Get(int id)
        {
            Customer customer = null;
            using (var container = new DomainModelContainer())
            {
                container.Configuration.LazyLoadingEnabled = false;
                customer = container.Customers.Find(id);
            }
            if (customer == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return customer;
        }

        // POST api/customers
        public HttpResponseMessage Post([FromBody]Customer customer)
        {
            using (var container = new DomainModelContainer())
            {
                container.Customers.Add(customer);
                container.Save();
            }
            var response = new HttpResponseMessage(HttpStatusCode.Created);
            response.AddLocationHeader(Request, customer.Id);
            return response;
        }
    }
}
