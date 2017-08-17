using System.Configuration;
using System.Data.SqlClient;

namespace Sixeyed.SpecFlowItAll.AcceptanceTests
{
    public class StepBase
    {
        public T ExecuteScalar<T>(string sqlFormat, params object[] args)
        {
            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ShopContext"].ConnectionString))
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = string.Format(sqlFormat, args);
                    var response = command.ExecuteScalar();
                    return (T)response;
                }
            }
        }
    }
}
