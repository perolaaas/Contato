using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contato1
{
    class Program
    {
        static void Main(string[] args)
        {

            ListaContatos lCont = new ListaContatos();

            int opcao = 1;

            while (opcao != 0)
            {
                Console.Clear();
                menu();
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("\nDigite um email: ");
                        string email1 = Console.ReadLine();
                        Console.WriteLine("\nDigite um nome: ");
                        string nome1 = Console.ReadLine();
                        Console.WriteLine("\nDigite um telefone: ");
                        string telefone1 = Console.ReadLine();
                        Contato contato1 = new Contato(email1, nome1, telefone1);
                        lCont.incluir(contato1);
                        Console.WriteLine("\nContato inserido com sucesso!");
                        Console.ReadKey();
                        break;

                    case 2:
                        Console.WriteLine("\nDigite o email a ser alterado: ");
                        string email2 = Console.ReadLine();
                        Console.WriteLine("\nDigite um novo nome: ");
                        string nome2 = Console.ReadLine();
                        Console.WriteLine("\nDigite um novo telefone: ");
                        string telefone2 = Console.ReadLine();
                        Contato contato2 = new Contato(email2, nome2, telefone2);
                        if (lCont.validar(contato2) == true)
                        {
                            lCont.alterar(contato2);
                            Console.WriteLine("\nContato alterado com sucesso!");
                        }
                        else
                        {
                            Console.WriteLine("O email inserido é inválido!");
                        }
                        Console.ReadKey();
                        break;

                    case 3:
                        Console.WriteLine("\nDigite o email a ser excluído: ");
                        string email3 = Console.ReadLine();
                        Contato contato3 = new Contato(email3, "", "");
                        if (lCont.validar(contato3) == true)
                        {
                            lCont.excluir(contato3);
                            Console.WriteLine("\nContato excluído com sucesso!");
                        }
                        else
                        {
                            Console.WriteLine("O email inserido é inválido!");
                        }
                        Console.ReadKey();
                        break;

                    case 4:
                        Console.WriteLine("\nDigite o email pesquisado: ");
                        string email4 = Console.ReadLine();
                        Contato contato4 = new Contato(email4, "", "");
                        Console.WriteLine("\nEmail: " + lCont.pesquisar(contato4).Email
                                 + "\nNome: " + lCont.pesquisar(contato4).Nome
                                 + "\nTelefone: " + lCont.pesquisar(contato4).Telefone);
                        Console.ReadKey();
                        break;

                    case 5:
                        for (int i = 0; i < lCont.listCount(); i++)
                        {
                            Console.Write("\nEmail: " + lCont.lContatos[i].Email
                                        + "\nNome: " + lCont.lContatos[i].Nome
                                        + "\nTelefone: " + lCont.lContatos[i].Telefone);
                        }
                        Console.ReadKey();
                        break;

                    default:
                        if (opcao != 0)
                        {
                            Console.WriteLine("Opção inválida!");
                        }
                        break;
                }//switch
            }//while





            Console.ReadKey();

        }//Main

        static void menu()
        {
            Console.WriteLine("0. Sair");
            Console.WriteLine("1. Inserir");
            Console.WriteLine("2. Alterar");
            Console.WriteLine("3. Excluir");
            Console.WriteLine("4. Pesquisar");
            Console.WriteLine("5. Listar");
            Console.WriteLine("\nDigite uma opção: ");
        }

    }//class
}//namespace
