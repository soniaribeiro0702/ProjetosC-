﻿using NovoProjetoPetShop.Modelo;
using NovoProjetoPetShop.Repositorios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovoProjetoPetShop.Servicos
{


    public class MetodosMenu
    {
        Validacoes validacoes = new Validacoes();
        public String CadastrarClientes()
        {
            var cliente = new Cliente();

            cliente.Nome = ReceberNome();

            cliente.Cpf = ReceberCpf();

            cliente.DataDeNascimento = ReceberDataDeNascimento();

            cliente.NomeDoPet = ReceberNomeDoPet();

            String linha = cliente.Nome.ToString() + ";" + cliente.Cpf.ToString() + ";" + cliente.DataDeNascimento.ToString() + ";" + cliente.NomeDoPet.ToString() + ";" + DateTime.Now;
            return linha;
        }

        private String ReceberNome()
        {
            Console.WriteLine("Digite o nome do cliente:");
            var nome = Console.ReadLine();
            while (nome == null || nome.Length < 4 || nome.Length > 80)
            {
                Console.WriteLine($"O nome do cliente precisa conter entre 3 e 80 caracteres. Por favor, digite novamente, ou, digite 0 para retornar ao menu anterios");
                Console.WriteLine("Digite o nome do cliente: ");
                nome = Console.ReadLine();
                if (nome == "0")
                {
                    return "erro";
                }
            }
            return nome;
        }
        private String ReceberCpf()
        {
            bool valido = false;
            Console.WriteLine("Digite o CPF do cliente:");
            var cpf = Console.ReadLine();
            valido = validacoes.ValidaCPF(cpf);
            while (!valido)
            {
                Console.WriteLine("CPF inválido!!! Digite novamente ou digite 0 para retornar ao menu anterior.");
                Console.WriteLine("Digite o CPF do cliente: ");
                cpf = Console.ReadLine();
                if (cpf == "0")
                {
                    return "erro";
                }
                valido = validacoes.ValidaCPF(cpf);
            }
            validacoes.RemoverMascaraCPF(cpf);
            validacoes.MascararCPF(cpf);
           

            return cpf;
        }
        private String ReceberDataDeNascimento()
        {

            Console.WriteLine("Digite a Data de nascimento ");
            var dataDeNascimento = Console.ReadLine();
            DateTime nascimento = DateTime.Now;
            if (dataDeNascimento != null)
            {
                nascimento = Validacoes.ValidarDataNascimento(dataDeNascimento);

            }
            while (nascimento == DateTime.Now)
            {
                Console.WriteLine("Data de nascimento inválida!!! Digite novamente ou digite 0 para retornar ao menu anterior.");
                Console.WriteLine("Digite a data de nascimento do cliente: ");
                dataDeNascimento = Console.ReadLine();
                if (dataDeNascimento == "")
                {
                    return "";
                }
                if (dataDeNascimento != null)
                {
                    nascimento = Validacoes.ValidarDataNascimento(dataDeNascimento);

                }

            }
            return nascimento.ToString();

        }
        private String ReceberNomeDoPet()
        {
            Console.WriteLine("Informe o nome do Pet");
            var nomePet = Console.ReadLine();
            if (nomePet != null)
            {
                return nomePet;

            }
            return nomePet.ToString();
        }


        public String AtualizarClientes(String cpf)
        {
            var AlterarDado = new Cliente();

            AlterarDado.Nome = ReceberNome();

            AlterarDado.DataDeNascimento = ReceberDataDeNascimento();

            AlterarDado.NomeDoPet = ReceberNomeDoPet();

            String linha = AlterarDado.Nome.ToString() + ";" + cpf + ";" + AlterarDado.DataDeNascimento.ToString() + ";" + AlterarDado.NomeDoPet.ToString() + ";" + DateTime.Now;
            return linha;


        }
        public String DesativarClientes(String conteudo)
        {
            String linha = conteudo + ";" + DateTime.Now;
            return linha;
        }
        public void ListarTodosOsClientes()
        {

        }
        public String BuscarClientesPorCpf(String cpf)
        {
            var PesquisarCliente = new Cliente();

            PesquisarCliente.Nome = ReceberNome();

            PesquisarCliente.DataDeNascimento = ReceberDataDeNascimento();

            PesquisarCliente.NomeDoPet = ReceberNomeDoPet();

            String linha = PesquisarCliente.Nome.ToString() + ";" + cpf + ";" + PesquisarCliente.DataDeNascimento.ToString() + ";" + PesquisarCliente.NomeDoPet.ToString() + ";" + DateTime.Now;
            return linha;
        }
        public List<String> ListarAniversarianteDoMes(List<String> conteudo)
        {

            int mes = DateTime.Now.Month;
            String mesAniversariante = mes.ToString();
            List<String> aniversariantes = new List<String>();

            if (mes < 10)
            {
                mesAniversariante = "0" + mes;
            }

            for (int i = 0; i <= conteudo.Count; i++)
            {
                if (conteudo[i].Contains("/" + mesAniversariante + "/"))
                {
                    aniversariantes.Add(conteudo[i]);
                }
            }
           
            return aniversariantes;
        }


    }

}
