using System;
namespace projFinal
{
    class Program
    {
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
                        AtualizarSeries();
                    break;

                     case "4":
                        ExcluirSeries();
                    break;

                     case "5":
                        VisualizarSeries();
                    break;

                     case "C":
                        Console.Clear();
                    break;

                    default:
                    throw new ArgumentOutOfRangeException();

                }
            }
        {
            
        }
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
            return opcaoUsuario;
        }   
        }
    } 
}
