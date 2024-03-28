using MySqlConnector;

namespace Infrastructure
{
    public class DbSession : IDisposable
    {
        internal MySqlConnection Connection;

        public DbSession(string connectionString)
        {
            Connection = new MySqlConnection(connectionString);
        }
        public void Dispose() => Connection.Dispose();
    }
}
