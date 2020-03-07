using System;

namespace SegundaLista{
    class ExercicioSeis
    {
        public static void Exercicio_Seis(){
        int tam = 10;
        int soma = 0;

        // Rotina para obter todos os ímpares
        Console.WriteLine("Ímpares entre 1 e 5: ");
        for (int i = 0; i <= tam; i++) {
            if (i % 2 == 1) {
                soma += i;
                Console.WriteLine(i);
            }
        }
        Console.WriteLine("Soma dos ímpares: " + soma);

        }
    }
}