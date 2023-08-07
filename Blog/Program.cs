
using Microsoft.Data.SqlClient;

internal class Program
{
    private const string CONNECTION_STRING = @"Server=localhost,1433;Database=Blog;User ID=sa;Password=Dan@8257";
    private static void Main(string [] args)
    {
    }

    public static void ReadUsers()
    {
        using (var connection = new SqlConnection())
        {

        }
    }

}