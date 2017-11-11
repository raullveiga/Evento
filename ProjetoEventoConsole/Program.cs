using System;
using Data.ClassePai.ClasseFilhas;

namespace ProjetoEventoConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int op = 0;
            do
            {   
                System.Console.WriteLine("1- Shows\n2- Cinema \n3- Teatro\n9- Sair");
                op = Convert.ToInt16(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        Show();
                    break;

                    case 2:
                        Cinema();
                    break;

                    case 3:
                        Teatro();
                    break;

                    case 9:
                    break;
                    default:
                        System.Console.WriteLine("Opção inválida");
                    break;
                }
            } while (op !=9);
        }

        static void Teatro(){
            int op = 0;
            do
            {
                
                System.Console.WriteLine("1- Cadastrar Teatro\n2- Pesquisa por Título\n3- Pesquisa por Data\n9- Sair");
                op = Convert.ToInt16(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Teatro n = new Input().Teatro();
                        if(n.Cadastrar())
                            System.Console.WriteLine("Cadastro efetuado.");
                        else
                            System.Console.WriteLine("Cadastro não realizado.");
                    break;

                    case 2:
                        System.Console.WriteLine("Digite o titulo a ser pesquisado.");
                        System.Console.WriteLine(new Teatro().Pesquisar(Console.ReadLine()));
                    break;

                    case 3:
                        System.Console.WriteLine("Digite o nome do ator ser pesquisado.");
                        System.Console.WriteLine(new Teatro().Pesquisar(Convert.ToDateTime(Console.ReadLine())));
                    break;

                    case 4:
                        System.Console.WriteLine("Digite o nome do ator ser pesquisado.");
                        System.Console.WriteLine(new Teatro().PesquisarAtor(Console.ReadLine()));
                    break;

                    case 9:
                    break;

                    default:
                        System.Console.WriteLine("Opção inválida");
                    break;
                }

            } while (op!=9);
        }
        static void Show(){
            int op = 0;
            do
            {
                
                System.Console.WriteLine("1- Cadastrar Show\n2- Pesquisa por Título\n3- Pesquisa por Data");
                op = Convert.ToInt16(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Show n = new Input().Show();
                        if(n.Cadastrar())
                            System.Console.WriteLine("Cadastro efetuado.");
                        else
                            System.Console.WriteLine("Cadastro não realizado.");
                    break;

                    case 2:
                        System.Console.WriteLine("Digite o titulo a ser pesquisado.");
                        System.Console.WriteLine(new Show().Pesquisar(Console.ReadLine()));
                    break;

                    case 3:
                        System.Console.WriteLine("Digite o nome do ator ser pesquisado.");
                        System.Console.WriteLine(new Show().Pesquisar(Convert.ToDateTime(Console.ReadLine())));
                    break;

                    case 9:
                    break;

                    default:
                        
                    break;
                }

            } while (op!=9);
        }
        static void Cinema(){
            int op = 0;
            do
            {
                
                System.Console.WriteLine("1- Cadastrar Teatro\n2- Pesquisa por Título\n3- Pesquisa por Data");
                op = Convert.ToInt16(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Cinema n = new Input().Cinema();
                        if(n.Cadastrar())
                            System.Console.WriteLine("Cadastro efetuado.");
                        else
                            System.Console.WriteLine("Cadastro não realizado.");
                    break;

                    case 2:
                        System.Console.WriteLine("Digite o titulo a ser pesquisado.");
                        System.Console.WriteLine(new Cinema().Pesquisar(Console.ReadLine()));
                    break;

                    case 3:
                        System.Console.WriteLine("Digite o nome do ator ser pesquisado.");
                        System.Console.WriteLine(new Cinema().Pesquisar(Convert.ToDateTime(Console.ReadLine())));
                    break;
                        
                }

            } while (op!=9);
        }
    }
}
