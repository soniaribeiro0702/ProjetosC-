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
        public void ExecutarGravacaoELeitura()
        {
            GravarArquivosCsv();
            LerArquivosCsv();
        }           
        public void GravarArquivosCsv()
        {
            try
            {
                StreamWriter sw = new StreamWriter($"C:{Path.DirectorySeparatorChar}ProjetosAtuais{Path.DirectorySeparatorChar}ProjetosC-{Path.DirectorySeparatorChar}NovoProjetoPetShop{Path.DirectorySeparatorChar}EntradasESaidas{Path.DirectorySeparatorChar}Saidas{Path.DirectorySeparatorChar}Sample.csv");

                sw.WriteLine("Insira as informações de interesse");

                sw.WriteLine("From the StreamWriter class");

                sw.Close();
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

        public void LerArquivosCsv()
        {
            try
            {
                using var file = new StreamReader($"C:{Path.DirectorySeparatorChar}ProjetosAtuais{Path.DirectorySeparatorChar}ProjetosC-{Path.DirectorySeparatorChar}NovoProjetoPetShop{Path.DirectorySeparatorChar}EntradasESaidas{Path.DirectorySeparatorChar}Entradas{Path.DirectorySeparatorChar}Sample.csv");
                string? line;

                while ((line = file.ReadLine()) != null)
                    Console.WriteLine(line);

                file.Close();

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

       
    }
}

    

