using System;
using Data.ClassePai.ClasseFilhas;

namespace ProjetoEventoConsole
{
    public class Input
    {
        public Input() { }
        public Teatro Teatro()
        {
            string titulo, diretor, local, lotacao, duracao, classificacao, data;
            string[] elenco;

            System.Console.WriteLine("Digite o título da peça  teatro");
            titulo = Console.ReadLine();
            System.Console.WriteLine("Digite o diretor da peça de teatro");
            diretor = Console.ReadLine();
            System.Console.WriteLine(@"Digite o elenco da peça de teatro, separando cada Ator por ',' (virgula)");
            elenco = Console.ReadLine().Split(';');
            System.Console.WriteLine("Digite o local do teatro");
            local = Console.ReadLine();
            System.Console.WriteLine("Digite a duração da peça");
            duracao = Console.ReadLine();
            System.Console.WriteLine("Digite a lotação do teatro");
            lotacao = Console.ReadLine();
            System.Console.WriteLine("Digite a classificação da peça de teatro");
            classificacao = Console.ReadLine();
            System.Console.WriteLine("Digite a data da peça de teatro");
            data = Console.ReadLine();

            Teatro teatro = new Teatro(titulo, local, Convert.ToInt32(lotacao), duracao, Convert.ToInt32(classificacao), Convert.ToDateTime(data), diretor, elenco);

            return teatro;
        }
        public Show Show()
        {
            string titulo, artista,generoShow, local, lotacao, duracao, classificacao, data;

            System.Console.WriteLine("Digite o título do show");
            titulo = Console.ReadLine();
            System.Console.WriteLine("Digite o artista do show");
            artista = Console.ReadLine();
            System.Console.WriteLine("Digite o genero do show");
            generoShow = Console.ReadLine();
            System.Console.WriteLine("Digite o local do show");
            local = Console.ReadLine();
            System.Console.WriteLine("Digite a duração do show");
            duracao = Console.ReadLine();
            System.Console.WriteLine("Digite a lotação do show");
            lotacao = Console.ReadLine();
            System.Console.WriteLine("Digite a classificação do show");
            classificacao = Console.ReadLine();
            System.Console.WriteLine("Digite a data do show");
            data = Console.ReadLine();

            Show show = new Show(titulo, local, Convert.ToInt32(lotacao), duracao, Convert.ToInt32(classificacao), Convert.ToDateTime(data),artista,generoShow);

            return show;
        }
        public Cinema Cinema()
        {
            string titulo, local, lotacao, duracao, classificacao, data,generoFilme;
            string[] n;
            DateTime[] sessao = null;

            System.Console.WriteLine("Digite o título do filme");
            titulo = Console.ReadLine();
            System.Console.WriteLine("Digite o gênero do filme");
            generoFilme = Console.ReadLine();
            System.Console.WriteLine(@"Digite o elenco da peça de teatro, separando cada Ator por ',' (virgula)");
                n = Console.ReadLine().Split(';');
                for(int i=0;i>n.Length;i++)
                    sessao[i] = DateTime.Parse(n[i]);

            System.Console.WriteLine("Digite o local do filme");
            local = Console.ReadLine();
            System.Console.WriteLine("Digite a duração do filme");
            duracao = Console.ReadLine();
            System.Console.WriteLine("Digite a lotação do filme");
            lotacao = Console.ReadLine();
            System.Console.WriteLine("Digite a classificação do filme");
            classificacao = Console.ReadLine();
            System.Console.WriteLine("Digite a data da peça do filme");
            data = Console.ReadLine();

            Cinema cinema = new Cinema(titulo, local, Convert.ToInt32(lotacao), duracao, Convert.ToInt32(classificacao), Convert.ToDateTime(data),sessao,generoFilme);

            return cinema;
        }
    }
}