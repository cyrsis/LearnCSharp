using Common;
using System.Data;
using System.Data.SqlClient;

namespace WebDemo.DataAccessLayer
{
    public class DataAccess
    {
        public FrameDto LoadFrame()
        {
            try
            {
                using (IDbConnection conn = Connect())
                {
                        return LoadFrame(conn);
                }
            }
            catch (SqlException ex)
            {
                throw new DataNotAvailableException("Frame", ex);
            }
        }

        private IDbConnection Connect()
        {
            
            string connString =
                @"Data Source=localhost\SQLEXPRESS;Initial Catalog=frames;Persist Security Info=True;User ID=frameAdmin;Password=insecure";
            
            IDbConnection conn = new SqlConnection(connString);
            conn.Open();
            return conn;

        }

        private FrameDto LoadFrame(IDbConnection conn)
        {
            using (IDbCommand command = CreateCommand(conn))
            {
                return LoadFrame(command);
            }
        }

        private IDbCommand CreateCommand(IDbConnection conn)
        {
            
            IDbCommand command = conn.CreateCommand();
            
            command.CommandText = 
                "SELECT Length, Width, X, Y, Radius " +
                "FROM geometry.Frames INNER JOIN geometry.Circles ON Frames.FrameID=Circles.FrameID " +
                "ORDER BY CircleID";

            return command;

        }

        private FrameDto LoadFrame(IDbCommand command)
        {

            FrameDto frame = null;

            using (IDataReader reader = ExecuteReader(command))
            {
                while (reader.Read())
                {
                    frame = CreateFrame(reader, frame);
                    AddCircle(reader, frame);
                }
            }

            return frame;

        }

        private IDataReader ExecuteReader(IDbCommand command)
        {
            return command.ExecuteReader();
        }

        private FrameDto CreateFrame(IDataReader reader, FrameDto frame)
        {

            if (frame != null)
                return frame;

            return
                new FrameDto()
                {
                    Length = (decimal)reader["Length"],
                    Width = (decimal)reader["Width"]
                };

        }

        private static void AddCircle(IDataReader reader, FrameDto frame)
        {
            CircleDto circle = CreateCircle(reader);
            frame.Circles.Add(circle);
        }

        private static CircleDto CreateCircle(IDataReader reader)
        {
            CircleDto circle =
                new CircleDto()
                {
                    X = (decimal)reader["X"],
                    Y = (decimal)reader["Y"],
                    Radius = (decimal)reader["Radius"]
                };
            return circle;
        }

    }
}