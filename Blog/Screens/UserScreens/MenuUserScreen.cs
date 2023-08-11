using Blog.Screens.TagScreens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Screens.UserScreens
{
    public static class MenuUserScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("GESTÃO DE USUÁRIOS");
            Console.WriteLine("---------------");
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine();
            Console.WriteLine("1 - Listar os usuários cadastrados");
            Console.WriteLine("2 - Cadastrar um novo usuário");
            Console.WriteLine("3 - Atualizar um usuário");
            Console.WriteLine("4 - Excluir um usuário");
            Console.WriteLine();
            Console.Write("Digite a opção desejada e confirme: ");
            var option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    ListUserScreen.Load();
                    break;
                case 2:
                    CreateUserScreen.Load();
                    break;
                case 3:
                    UpdateUserScreen.Load();
                    break;
                case 4:
                    DeleteUserScreen.Load();
                    break;
                default:
                    Load();
                    break;
            }
        }
    }
}
