﻿
using Blog.Models;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;

internal class Program
{
    private const string CONNECTION_STRING = @"Server=localhost,1433;Database=Blog;User ID=sa;Password=Dan@8257;Trusted_Connection=False; TrustServerCertificate=True;";

    private static void Main(string [] args)
    {
        ReadUsers();
    }

    public static void ReadUsers()
    {
        using (var connection = new SqlConnection(CONNECTION_STRING))
        {
            var users = connection.GetAll<User>();

            foreach (var user in users)
            {
                Console.WriteLine(user.Name);
            }
        }
    }

}