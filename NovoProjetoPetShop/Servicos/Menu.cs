using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.MemoryMappedFiles;
using NovoProjetoPetShop.Repositorios;
using System.Data.Common;
using NovoProjetoPetShop.Modelo;

namespace NovoProjetoPetShop.Servicos
{
    public class Menu
    {
        List<String> conteudo;
        LerGravarArquivos adapter = new LerGravarArquivos();
        Validacoes validacoes = new Validacoes();

        public void BaseDeDados()
        {
            if (adapter.LerArquivosCsv() == null)
            {
                adapter.GravarArquivosCsv(conteudo);
                conteudo = adapter.LerArquivosCsv();
            }

        }

        public void OpcaoMenu()
        {
            int opcao = new Random().Next(1, 4);
            while (opcao != 0)
            {
                Console.WriteLine("1 - Inserir cliente");
                Console.WriteLine("2 - Atualizar cliente");
                Console.WriteLine("3 - Desativar cliente");
                Console.WriteLine("4 - Listar todos os clientes");
                Console.WriteLine("5 - Buscar cliente por CPF");
                Console.WriteLine("6 - Listar os aniversariantes do mês" +
                    "es do mês");
                Console.WriteLine("0 - Encerrar programa");

                Console.WriteLine("Digite um dos valores acima");
                opcao = Convert.ToInt16(Console.ReadLine());


                var metodosmenu = new MetodosMenu();

                switch (opcao)
                {
                    case 1:
                        String linha = metodosmenu.CadastrarClientes();
                        if (linha != "erro")
                        {
                            conteudo.Add(linha);
                            adapter.GravarArquivosCsv(conteudo);
                            Console.WriteLine("Cliente inserido com sucesso!");
                        }
                        else
                        {
                            Console.WriteLine("Erro ao inserir cliente, por favor, retorne.");
                        }
                        break;
                    case 2:
                        Console.WriteLine("Por favor informe o CPF para localizar o cliente a ser alterado");
                        String? cpfASerAlterado = Console.ReadLine();
                        if (cpfASerAlterado != null)
                        {
                            cpfASerAlterado = validacoes.RemoverMascaraCPF(cpfASerAlterado);
                            cpfASerAlterado = validacoes.MascararCPF(cpfASerAlterado);
                            for (int i = 0; i <= conteudo.Count; i++)
                            {
                                if (conteudo[i].Contains(";" + cpfASerAlterado + ";"))
                                {
                                    conteudo[i] = metodosmenu.AtualizarClientes(cpfASerAlterado);
                                }
                            }

                            adapter.GravarArquivosCsv(conteudo);
                            Console.WriteLine("Informações do cliente alteradas com sucesso!");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Por favor informe o CPF localizar o cliente a ser deletado");
                        String? cpfASerDeletado = Console.ReadLine();
                        if (cpfASerDeletado != null)
                        {
                            cpfASerDeletado = validacoes.RemoverMascaraCPF(cpfASerDeletado);
                            cpfASerDeletado = validacoes.MascararCPF(cpfASerDeletado);
                            for (int i = 0; i <= conteudo.Count; i++)
                            {
                                if (conteudo[i].Contains(";" + cpfASerDeletado + ";"))
                                {
                                    conteudo[i] = metodosmenu.DesativarClientes(conteudo[i]);
                                }
                            }
                            adapter.GravarArquivosCsv(conteudo);
                            Console.WriteLine("Informações do cliente deletadas com sucesso!");
                        }
                        break;


                    case 4:
                        metodosmenu.ListarTodosOsClientes();
                        break;
                    case 5:
                        Console.WriteLine("Por favor informe o CPF para localizar o cliente de interesse");
                        String? cpfDigitado = Console.ReadLine();
                        if (cpfDigitado != null)
                        {
                            cpfDigitado = validacoes.RemoverMascaraCPF(cpfDigitado);
                            cpfDigitado = validacoes.MascararCPF(cpfDigitado);
                            String clienteLocalizado = "";
                            for (int i = 0; i <= conteudo.Count; i++)
                            {
                                if (conteudo[i].Contains(";" + cpfDigitado + ";"))
                                {
                                    clienteLocalizado = metodosmenu.BuscarClientesPorCpf(conteudo[i]);

                                }
                            }
                            if (clienteLocalizado != "")
                            {
                                Console.WriteLine(conteudo);

                            }
                            else
                            {
                                Console.WriteLine("Cliente não localizado");
                            }

                        }

                        break;
                    case 6:
                        List<String> aniversariantes = metodosmenu.ListarAniversarianteDoMes(conteudo);
                        if (aniversariantes.Count > 0)
                        {
                            foreach (String aniversariante in aniversariantes)
                            {
                                Console.WriteLine(aniversariante);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Nenhum aniversariante no mes");
                        }
                        break;
                    default:
                        
                        break;
                }
            }
        }
    }
}
