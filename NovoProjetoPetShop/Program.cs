using NovoProjetoPetShop.Repositorios;

namespace NovoProjetoPetShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var LerGravar = new LerGravarArquivos();
            LerGravar.ExecutarGravacaoELeitura();

            var manipular = new ManipularArquivos();
            manipular.Manipular();


        }
    }
}