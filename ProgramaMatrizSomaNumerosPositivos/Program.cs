namespace ProgramaMatrizSomaNumerosPositivos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("######################################################");
            Console.WriteLine("###Programa para soma de números positivos em Bingo###");
            Console.WriteLine("######################################################");

            var matrizNumeros = new int[3, 3];
            matrizNumeros[0, 0] = 1;
            matrizNumeros[0, 0] = 8;
            matrizNumeros[0, 2] = 15;

            matrizNumeros[1, 0] = -6;
            matrizNumeros[1, 0] = 5;
            matrizNumeros[1, 2] = 5;

            matrizNumeros[2, 0] = 6;
            matrizNumeros[2, 0] = 5;
            matrizNumeros[2, 2] = -5;

            
            
            for (int contadorLinhas = 0; contadorLinhas < matrizNumeros.Length) ;

                int somaNumeros = 0;
                
        }
    }
}