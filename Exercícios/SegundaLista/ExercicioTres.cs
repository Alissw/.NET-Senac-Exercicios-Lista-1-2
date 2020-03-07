using System;

namespace SegundaLista{
    class ExercicioTres{
        public static void Exercicio_Tres(){

            String palavraSecreta;
            String palavraDigitada;
            int qtdChances = 5;

            Console.WriteLine(":::Bem vindo ao jogo da forca simples:::");

            Console.WriteLine("Digite a palavra secreta: ");
            palavraSecreta = Console.ReadLine();

            Console.WriteLine("Vamos lá! Você tem " + qtdChances + " chances...");

            while(true){
                Console.WriteLine("Digite uma palavra:");
                palavraDigitada = Console.ReadLine();
                qtdChances--;

                if(palavraDigitada.Equals(palavraSecreta)){
                    Console.WriteLine("Parabéns, a palavra é: " + palavraSecreta);
                    break;
                }else if((palavraDigitada != palavraSecreta) && (qtdChances>0)){
                    Console.WriteLine("Você errou, mas ainda tem " + qtdChances + " chances, tente novamente...");
                }else{
                    Console.WriteLine("Você foi enforcado!");
                    break;
                }
            }
        }
    }
}