using System;

namespace SegundaLista
{
    class ExercicioDez
    {
        public static void Exercicio_Dez()
        {
            Console.WriteLine("Digite o valor a ser calculado: ");
            int valor = Convert.ToInt16(Console.ReadLine());

            int nota = 0;
            int valorNota = 0;
            int qtdNotas = 0;
            String mensagem = "";

            while (valor != 0)
            {
                if (nota == 0)
                {
                    valorNota = 100;
                }
                else if (nota == 1)
                {
                    valorNota = 50;
                }
                else if (nota == 2)
                {
                    valorNota = 10;
                }
                else if (nota == 3)
                {
                    valorNota = 5;
                }
                else
                {
                    valorNota = 1;
                }

                qtdNotas = valor / valorNota;

                if (qtdNotas != 0)
                {
                    if (mensagem.Length > 0)
                    {
                        mensagem += " e ";
                    }
                    mensagem += qtdNotas + " nota(s) de R$ " + valorNota;
                    valor = valor % valorNota;
                }
                nota++;
            }
            Console.WriteLine(mensagem);
        }
    }
}