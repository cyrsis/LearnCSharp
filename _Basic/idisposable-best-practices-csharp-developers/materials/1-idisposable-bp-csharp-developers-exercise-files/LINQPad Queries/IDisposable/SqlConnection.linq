<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\System.Data.dll</Reference>
  <Namespace>System.Data</Namespace>
</Query>

void Main()
{
	for (int i=0; i<1000; i++)
	{
		//using (var state = new DatabaseState())
		var state = new DatabaseState();
		{
			state.GetDate().Dump();
		}
	}
}

public class DatabaseState : IDisposable
{
	private SqlConnection _connection;
	
	public string GetDate()
	{
		if (_connection == null)
		{
			_connection = new SqlConnection("Server=.\\SQL2012DEV;Database=master;Integrated Security=SSPI;App=LINQPad;Max pool size=215;Connection Timeout=2;");
			_connection.Open();
		}		
		using (var command = _connection.CreateCommand())
		{
			command.CommandText = "SELECT getdate()";
			return command.ExecuteScalar().ToString();
		}
	}
	
	public void Dispose()
	{
		Dispose(true);
		GC.SuppressFinalize(this);
	}
	
	protected void Dispose(bool disposing)
	{
		var action = disposing ? "Disposing" : "Finalizing";
		string.Format("{0}, SqlConnection: {1}", action, _connection.GetHashCode()).Dump();
		if (disposing)
		{
			_connection.Close();
			_connection.Dispose();
		}
	}
	
	~DatabaseState()
	{
		Dispose(false);
	}
}