using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.MemoryMappedFiles;
using System.Security.Cryptography.X509Certificates;

namespace NovoProjetoPetShop.Repositorios
{
    public class LerGravarArquivos
    {
        String caminho = "C:\\ProjetosAtuais\\ProjetosC-\\NovoProjetoPetShop\\base_de_dados.csv";
        public void GravarArquivosCsv(List<String> conteudo)
        {
            String cabecalho = "NOME;CPF;DATA DE NASCIMENTO;NOME PET;DATA_ALTERACAO;DATA_EXCLUSAO";
            try
            {
                StreamWriter arquivo = new StreamWriter(caminho);
                arquivo.WriteLine(cabecalho);

                if (conteudo.Count() > 0)
                {
                    arquivo.WriteLine(conteudo);
                }


                arquivo.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }

        }

        public List<String> LerArquivosCsv()
        {
            StreamReader file;
            try
            {
                List<String> conteudo = new List<String>();
                if (caminho == null || caminho == "")
                {
                    caminho = "C:\\ProjetosAtuais\\ProjetosC-\\NovoProjetoPetShop\\base_de_dados.csv";
                }
                file = new StreamReader(caminho);
                string? line;

                while ((line = file.ReadLine()) != null)
                {
                    conteudo.Add(line);
                    line = line;
                    Console.WriteLine(line);
                }
                file.Close();
                return conteudo;

            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
                return null;

            }


        }


    }

}



