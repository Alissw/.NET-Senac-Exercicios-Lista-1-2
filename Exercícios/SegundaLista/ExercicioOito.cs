using System;

namespace SegundaLista
{
    class ExercicioOito
    {
        public static void Exercicio_Oito()
        {
            int fat = 1;
            int valor; // ou qualquer outro valor que queira calcular;
            Console.WriteLine("Digite o numero que deseja fatorar:");
            valor = Convert.ToInt16(Console.ReadLine());

            for (int i = 1; i <= valor; i++)
            {
                fat *= i;
            }

            Console.WriteLine("O fatorial de " + valor + " é igual a " + fat);
        }
    }
}