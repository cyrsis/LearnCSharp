using System;
using System.Data;
using System.Data.SqlClient;
using AllCodeRush.Space.Bodies.Planets;
using System.Linq;
using AllCodeRush.Space;
using System.Collections.Generic;

namespace AllCodeRush.Code.NamespacesTypeQualifiers
{
	/* •—————————————————————————————————————————————————————————•
	    Feature: Sort Namespace References
         
	    Use Case: Sorts namespace references in the using section 
	    by length, or alphabetically..
	 
			Available: When the cursor is anywhere within the using 
	    section.

      See also: Optimize Namespace References
		 •—————————————————————————————————————————————————————————• */

	public class SortNamespaceReferences
	{
		public SolarSystem LoadGalaxy()
		{
			SolarSystem Sol = new SolarSystem();
			SqlConnection connection = new SqlConnection(Settings.GetSQLConnectionString());
			using (connection)
			{
				connection.Open();
				SqlCommand command = new SqlCommand("Select Name from Planets", connection);
				SqlDataReader Reader = command.ExecuteReader();
				while (Reader.Read())
				{
					Sol.Planets.Add(new Planet { Name = Reader.GetString(0) });
				}
				connection.Close();
			}
			return Sol;
		}
	}
}
