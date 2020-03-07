using System;

namespace SegundaLista{
    class ExercicioQuatro
    {
        public static void Exercicio_Quatro(){
            int numInicio, numFim;


            Console.WriteLine("Digite o início da tabuada que você deseja: ");
            numInicio = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Digite o fim da tabuada que você deseja: ");
            numFim = Convert.ToInt16(Console.ReadLine());


            if(numInicio < numFim){
                for(int i = numInicio; i<=numFim;i++){
                    Console.WriteLine("\n" + numInicio + " X " + i + " = " + numInicio*i);
                }
            }
        }
    }
}