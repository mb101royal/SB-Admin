using System.Data;
using System.Data.SqlClient;

namespace SB_Admin.Helpers
{
    public class SqlHelper
    {
        private const string _connectionString = @"Server= DESKTOP-OG8IRC4\SQLEXPRESS;Database = Nov29;Trusted_Connection=true";
        public static async Task<DataTable> GetDatasAsync(string query)
        {
            using SqlConnection connection = new SqlConnection(_connectionString);
            await connection.OpenAsync();
            DataTable dt = new DataTable();
            using SqlDataAdapter sda = new SqlDataAdapter(query, connection);
            sda.Fill(dt);
            await connection.CloseAsync();
            return dt;
        }
        public static async Task<int> ExecAsync(string query)
        {
            using SqlConnection connection = new SqlConnection(_connectionString);
            await connection.OpenAsync();
            using SqlCommand command = new SqlCommand(query, connection);
            int result = command.ExecuteNonQuery();
            await connection.CloseAsync();
            return result;
        }
    }
}
