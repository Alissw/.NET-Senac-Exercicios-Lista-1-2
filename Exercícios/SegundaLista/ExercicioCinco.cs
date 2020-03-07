using System;

namespace SegundaLista{
    class ExercicioCinco
    {
        public static void Exercicio_Cinco(){
           Console.Write("Digite a palavra desejada: ");
            String palavra = Console.ReadLine();

            for(int i = 0; i < palavra.Length; i++){
               Console.WriteLine("Palavra: " + palavra[i]);
            }
        }
    }
}