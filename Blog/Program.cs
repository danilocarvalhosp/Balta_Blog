
using Blog;
using Blog.Screens.CategoryScreens;
using Blog.Screens.RoleScreens;
using Blog.Screens.TagScreens;
using Blog.Screens.UserScreens;
using Microsoft.Data.SqlClient;

internal class Program
{
    private const string CONNECTION_STRING = @"Server=localhost,1433;Database=Blog;User ID=sa;Password=Dan@8257;Trusted_Connection=False; TrustServerCertificate=True;";

    private static void Main(string [] args)
    {
        Database.Connection = new SqlConnection(CONNECTION_STRING);
        Database.Connection.Open();

        Load();

        Console.ReadKey();
        Database.Connection.Close();
    }

    private static void Load()
    {
        Console.Clear();
        Console.WriteLine("MEU BLOG");
        Console.WriteLine("---------------");
        Console.WriteLine("O que deseja fazer?");
        Console.WriteLine();
        Console.WriteLine("1 - Gestão de usuários");
        Console.WriteLine("2 - Gestão de perfis");
        Console.WriteLine("3 - Gestão de categorias");
        Console.WriteLine("4 - Gestão de tags");
        Console.WriteLine("5 - Vincular perfil/usuário");
        Console.WriteLine("6 - Vincular post/tag");
        Console.WriteLine("7 - Relatórios");
        Console.WriteLine();
        Console.Write("Digite a opção desejada e tecle Enter: ");

        try
        {
            var option = short.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    MenuUserScreen.Load();
                    break;
                case 2:
                    MenuRoleScreen.Load();
                    break;
                case 3:
                    MenuCategoryScreen.Load();
                    break;
                case 4:
                    MenuTagScreen.Load();
                    break;
                default:
                    Load();
                    break;
            }
        }
        catch (Exception)
        {
            Load();
        }
    }
}
