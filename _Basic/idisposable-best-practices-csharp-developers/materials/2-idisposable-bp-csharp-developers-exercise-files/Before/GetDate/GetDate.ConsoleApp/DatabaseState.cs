using System.Configuration;
using System.Data.SqlClient;

namespace GetDate.ConsoleApp
{
    public class DatabaseState 
    {
        protected SqlConnection _connection;

        public virtual string GetDate()
        {
            if (_connection == null)
            {
                var connectionString = ConfigurationManager.ConnectionStrings["master"];
                _connection = new SqlConnection(connectionString.ConnectionString);
                _connection.Open();
            }
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "SELECT getdate()";
                return command.ExecuteScalar().ToString();
            }
        }
    }
}
