using System.Configuration;
using System.Data.SqlClient;
using System.Data.SqlTypes;



namespace GymSystemManagment.DAL
{
    public class DatabaseConnection
    {
        public static string ConnectionString = ConfigurationManager.ConnectionStrings["conStringRroni"].ConnectionString.ToString();

        public static SqlConnection? sqlConnection;
        public static SqlDataAdapter? sqlDataAdapter;
        public static SqlCommand? sqlCommand;
    }
}
