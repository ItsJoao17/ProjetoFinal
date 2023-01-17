using Microsoft.Win32;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_final
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Iniciar lasses
            Livros livro = new Livros();

            int[] codigo = new int[2];
            string[] titulo = new string[2]; 
            string[] autor  = new string[2];

            int i=1, op= 0;

            //Menu

            do
            {
                Console.WriteLine("Escolha a operação que deseja efetuar? \n " +
                "\n 1 =  registar livros \n 2 = atualizar livros " +
                "\n 3 = consultar a informação de um livro a partir do código " +
                "\n 4 = listar os livros pelo género.\n 5 = listar os livros pelo autor." +
                "\n 6 = listar os utilizadores\n 7= comprar livros \n 8 = vender livros" +
                "\n 9 = consultar stock \n 10 = consultar o total de livros vendidos e respetiva receita " +
                "\n 0 = Sair");

                op = Convert.ToInt32(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Console.WriteLine("Registar livro: ");
                        Console.WriteLine("Codigo - ");
                        Console.WriteLine("Titulo - ");
                        Console.WriteLine("Autor - ");

                        break;
                    case 2:
                        Console.WriteLine("atualizar livros");
                        break;
                    case 3:
                        Console.WriteLine("consultar a informação de um livro a partir do código");
                        break;
                    case 4:
                        Console.WriteLine("listar os livros pelo género.");
                        break;
                    case 5:
                        Console.WriteLine("listar os livros pelo autor.");
                        break;
                    case 6:
                        Console.WriteLine("listar os utilizadores");
                        break;
                    case 7:
                        Console.WriteLine("comprar livros");
                        break;
                    case 8:
                        Console.WriteLine("vender livros");
                        break;
                    case 9:
                        Console.WriteLine("consultar stock");
                        break;
                    case 10: Console.WriteLine("consultar o total de livros vendidos e respetiva receita"); break;

                    default: Console.WriteLine("Número inválido!"); break;
                }
            } while (op != 0);
            Console.ReadKey();
        }
    }
}
