using Blog.Screens.TagScreens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Screens.CategoryScreens
{
    public static class MenuCategoryScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("GESTÃO DE CATEGORIAS");
            Console.WriteLine("---------------");
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine();
            Console.WriteLine("1 - Listar as categorias cadastradas");
            Console.WriteLine("2 - Cadastrar uma nova categoria");
            Console.WriteLine("3 - Atualizar uma categoria");
            Console.WriteLine("4 - Excluir uma categoria");
            Console.WriteLine();
            Console.Write("Digite a opção desejada e confirme: ");
            var option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    ListCategoryScreen.Load();
                    break;
                case 2:
                    CreateCategoryScreen.Load();
                    break;
                case 3:
                    UpdateCategoryScreen.Load();
                    break;
                case 4:
                    DeleteCategoryScreen.Load();
                    break;
                default:
                    Load();
                    break;
            }
        }
    }
}
