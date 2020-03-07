using System;

namespace SegundaLista
{
    class ExercicioSete
    {
        public static void Exercicio_Sete()
        {
            int i = 0;
            int qtd = 0;
            double media = 0;
            double nota = 0;
            double soma = 0;

            //Repete a entrada enquanto nota for >= 0
            while (nota >= 0)
            {
                Console.WriteLine("Digite a " + (i + 1) + "ª nota: ");
                nota = Convert.ToDouble(Console.ReadLine());
                i++;


                if (nota >= 0)
                {
                    //Calcula a média das notas
                    qtd = qtd + 1;
                    soma = soma + nota;
                    media = soma / qtd;

                }
                else
                {
                    //Mostrar média das notas
                    Console.WriteLine("Soma das notas: " + soma);
                    Console.WriteLine("Quantidade de notas digitadas: " + qtd);
                    Console.WriteLine("Média do aluno: " + media);
                    break;
                }
            } 
        }
    }
}