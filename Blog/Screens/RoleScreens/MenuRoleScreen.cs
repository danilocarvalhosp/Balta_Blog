using Blog.Screens.TagScreens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Screens.RoleScreens
{
    public static class MenuRoleScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("GESTÃO DE PERFIS");
            Console.WriteLine("---------------");
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine();
            Console.WriteLine("1 - Listar os perfis cadastradas");
            Console.WriteLine("2 - Cadastrar um novo perfil");
            Console.WriteLine("3 - Atualizar um perfil");
            Console.WriteLine("4 - Excluir um perfil");
            Console.WriteLine();
            Console.Write("Digite a opção desejada e confirme: ");
            var option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    ListRoleScreen.Load();
                    break;
                case 2:
                    CreateRoleScreen.Load();
                    break;
                case 3:
                    UpdateRoleScreen.Load();
                    break;
                case 4:
                    DeleteRoleScreen.Load();
                    break;
                default:
                    Load();
                    break;
            }
        }
    }
}
