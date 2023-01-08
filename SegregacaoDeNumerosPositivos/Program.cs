using Microsoft.VisualBasic;
using System.Collections;
using System.Runtime.InteropServices;



namespace SegregacaoDeNumerosPositivos
{
    internal class Program
    {

        //2.    Faça um algoritmo que receba 15 números e exiba somente os positivos para o usuário
        static void Main(string[] args)
        {
            Console.WriteLine("#####################################");
            Console.WriteLine("###Segragação de Números Positivos###");
            Console.WriteLine("#####################################");

            List<int> positivo = new List<int>();         
            int[] numeros = new int[5];
           
            int x = 0;
            for (int i = 0; i < numeros.Length; i++)
            {   
                Console.WriteLine("Digite 5 números de sua escolha: ");
                int numero = Convert.ToInt32(Console.ReadLine());

                numeros[i] = numero;

                if (numero >= 0)
                {
              
                    positivo.Add(numero);
                    x = x + 1;  
                }                
            }

            Console.WriteLine("Os números digitados foram: ");

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine(numeros[i]);                
            }

            Console.WriteLine("Dentre eles os positivos são: ");

            for (int i = 0; i < positivo.Count; i++)
            {
                Console.WriteLine(positivo[i]);
            }


        }
    }
}