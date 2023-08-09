
using Blog.Models;
using Blog.Repositories;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;

internal class Program
{
    private const string CONNECTION_STRING = @"Server=localhost,1433;Database=Blog;User ID=sa;Password=Dan@8257;Trusted_Connection=False; TrustServerCertificate=True;";

    private static void Main(string [] args)
    {
        var connection = new SqlConnection(CONNECTION_STRING);
        connection.Open();

        ReadUsersWithRoles(connection);
        //ReadRoles(connection);
        //ReadTags(connection);
        //ReadUser(connection);
        //ReadRole(connection);
        //ReadTag(connection);
        //CreateUser(connection);
        //CreateRole(connection);
        //CreateTag(connection);
        //UpdateUser(connection);
        //UpdateRole(connection);
        //UpdateTag(connection);
        //DeleteUser(connection);
        //DeleteRole(connection);
        //DeleteTag(connection);

        connection.Close();
    }

    public static void ReadUsersWithRoles(SqlConnection connection)
    {
        var repository = new UserRepository(connection);
        var items = repository.GetWithRoles();

        foreach (var item in items)
        {
            Console.WriteLine(item.Name);
            foreach (var role in item.Roles)
            {
                Console.WriteLine($" - {role.Name}");
            }
        }
    }

    public static void ReadRoles(SqlConnection connection)
    {
        var repository = new Repository<Role>(connection);
        var items = repository.Get();

        foreach (var item in items)
            Console.WriteLine(item.Name);
    }

    public static void ReadTags(SqlConnection connection)
    {
        var repository = new Repository<Tag>(connection);
        var items = repository.Get();

        foreach (var item in items)
            Console.WriteLine(item.Name);
    }

    public static void ReadUser(SqlConnection connection)
    {
        var repository = new Repository<User>(connection);
        var item = repository.Get(1);
        Console.WriteLine(item.Name);
    }

    public static void ReadRole(SqlConnection connection)
    {
        var repository = new Repository<Role>(connection);
        var item = repository.Get(1);
        Console.WriteLine(item.Name);
    }

    public static void ReadTag(SqlConnection connection)
    {
        var repository = new Repository<Tag>(connection);
        var item = repository.Get(1);
        Console.WriteLine(item.Name);
    }

    private static void CreateUser(SqlConnection connection)
    {
        var repository = new Repository<User>(connection);
        var user = new User
        {
            Bio = "8x Microsoft MVP",
            Email = "danilo@balta.io",
            Image = "https://balta.io/andrebaltieri.jpg",
            Name = "Danilo Carvalho",
            Slug = "danilo-carvalho",
            PasswordHash = Guid.NewGuid().ToString()
        };

        repository.Create(user);
    }

    private static void CreateRole(SqlConnection connection)
    {
        var repository = new Repository<Role>(connection);
        var role = new Role
        {
            Name = "Autor 2",
            Slug = "author2",
        };

        repository.Create(role);
    }

    private static void CreateTag(SqlConnection connection)
    {
        var repository = new Repository<Tag>(connection);
        var tag = new Tag
        {
            Name = "C#",
            Slug = "c-sharp",
        };

        repository.Create(tag);
    }

    private static void UpdateUser(SqlConnection connection)
    {
        var repository = new Repository<User>(connection);
        var user = repository.Get(3);
        user.Email = "danilocarvalhosp@gmail.com";

        repository.Update(user);
        Console.WriteLine(user?.Email);
    }

    private static void UpdateRole(SqlConnection connection)
    {
        var repository = new Repository<Role>(connection);
        var role = repository.Get(2);
        role.Name = "Danilo";

        repository.Update(role);
        Console.WriteLine(role.Name);
    }

    private static void UpdateTag(SqlConnection connection)
    {
        var repository = new Repository<Tag>(connection);
        var tag = repository.Get(2);
        tag.Name = "C SHARP";

        repository.Update(tag);
        Console.WriteLine(tag.Name);
    }

    private static void DeleteUser(SqlConnection connection)
    {
        var repository = new Repository<User>(connection);
        var user = repository.Get(3);
        repository.Delete(user);
    }

    private static void DeleteRole(SqlConnection connection)
    {
        var repository = new Repository<Role>(connection);
        var role = repository.Get(3);
        repository.Delete(role);
    }

    private static void DeleteTag(SqlConnection connection)
    {
        var repository = new Repository<Tag>(connection);
        var tag = repository.Get(3);
        repository.Delete(tag);
    }
}