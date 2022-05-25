using System;
using projFinal.Classes;

namespace projFinal
{
    class Program
    {
        static SerieRepositorio repositorio = new SerieRepositorio();
        static void Main(string[] args)
        {
             string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        ListarSeries();
                    break;

                     case "2":
                        InserirSeries();
                    break;

                     case "3":
                        AtualizarSerie();
                    break;

                     case "4":
                        ExcluirSerie();
                    break;

                     case "5":
                        VisualizarSerie();
                    break;

                     case "C":
                        Console.Clear();
                    break;

                    default:
                    throw new ArgumentOutOfRangeException();

                }

                opcaoUsuario = ObterOpcaoUsuario();
              
            }
        
            Console.WriteLine("Obrigado por utilizar nossos serviços");
            Console.ReadLine();
        
        }

            private static void ExcluirSerie()
            {
                 Console.Write("digite o id série: ");
                int indicaSerie = int.Parse(Console.ReadLine());

                repositorio.Exclui(indicaSerie);
                
            }

             private static void VisualizarSerie()
             {
                 Console.Write("digite o id série: ");
                int indicaSerie = int.Parse(Console.ReadLine());

                var serie = repositorio.RetornaPorId(indicaSerie);

                Console.WriteLine(serie);
             }
            private static void AtualizarSerie()
            {
                Console.Write("digite o id série: ");
                int indicaSerie = int.Parse(Console.ReadLine());
                

            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
            }

            Console.Write("Digite o genêro entre as opções acima ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.Write("Digite o Título da série: ");
            string entradaTitulo = (Console.ReadLine());

             Console.Write("Digite o Ano da série: ");
            string entradaAno = (Console.ReadLine());

             Console.Write("Digite a Descrição da série: ");
            string entradaDescricao = (Console.ReadLine());

            Serie novaSerie = new  Serie(id: repositorio.ProximoId(), 
                                                                genero: (Genero)entradaGenero, 
                                                                titulo: entradaTitulo,
                                                                ano: entradaAno,
                                                                descricao: entradaDescricao);
            }
       
        private static void ListarSeries()
        {
            Console.WriteLine("Listar séries");

            var lista = repositorio.Lista();

            if (lista.Count == 0)
            {
                Console.WriteLine("Nenhuma série cadastrada");
                return;
            }

            foreach (var serie in lista)
            {
                var excluido = serie.retornaExcluido();
                Console.WriteLine("#ID {0}: - {1} {2}", serie.retornaId(), serie.retornaTitulo(), (excluido ? "*Excluido*" : ""));
            }

        }

        private static void InserirSeries()
        {
            Console.WriteLine("Inserir nova série");

            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
            }

            Console.Write("Digite o genêro entre as opções acima ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.Write("Digite o Título da série: ");
            string entradaTitulo = (Console.ReadLine());

             Console.Write("Digite o Ano da série: ");
            string entradaAno = (Console.ReadLine());

             Console.Write("Digite a Descrição da série: ");
            string entradaDescricao = (Console.ReadLine());

            Serie novaSerie = new  Serie(id: repositorio.ProximoId(), 
                                                                genero: (Genero)entradaGenero, 
                                                                titulo: entradaTitulo,
                                                                ano: entradaAno,
                                                                descricao: entradaDescricao);
                                                                
                                                                
        }
        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("Séries Ao Seu Dispor");
            Console.WriteLine("Informe a opção desejada");
               
            Console.WriteLine("1- Listar Séries");
            Console.WriteLine("2- iserir nova série");
            Console.WriteLine("3- Atualizar série");
            Console.WriteLine("4- Excluir série");
            Console.WriteLine("5- Vizualisar série");
            Console.WriteLine("C- Limpar tela");
            Console.WriteLine("X- Sair");
            Console.WriteLine();
        
            string OpcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return OpcaoUsuario;
        }   
        }

    } 

