using System.Runtime.Serialization.Formatters;
using System.Linq;

namespace IdentificadorDeIdade
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("##################################");
            Console.WriteLine("###Identificação de Senioridade###");
            Console.WriteLine("##################################");

            String[] nomes = new string[10];
            List<int> idades = new List<int>();
            

            for (int i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine("Informe o nome da pessoa: ");
                nomes[i] = (Console.ReadLine());
                Console.WriteLine("Informe a idade dessa pessoa: ");
                idades.Add(Convert.ToInt32(Console.ReadLine()));

            }


            int maiorIdade = idades.Max();

            int indexListaIdades = idades.IndexOf(maiorIdade);

            Console.WriteLine($"A pessoa mais velha digitada é: {nomes[indexListaIdades]}");
                                
            Console.ReadKey();
        }

    }

}