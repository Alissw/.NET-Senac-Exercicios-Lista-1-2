using System;

namespace SegundaLista
{
    class ExercicioNove
    {
        public static  void Exercicio_Nove()
        {
            float altura;
            float peso;
            float imc;

            //Input dos dados
            Console.WriteLine("Insita sua altura: ");
            altura = Console.Read();
            Console.WriteLine("Insita seu peso: ");
            peso = Console.Read();

            //Cálculo
            imc = peso / (altura * altura);

            if (imc < 18.5)
            {
                Console.WriteLine("Abaixo de 18,5 | Abaixo do peso");
            }
            else if ((imc > 18.4) || (imc < 25))
            {
                Console.WriteLine("Entre 18,6 e 24,9 | Peso ideal");
            }
            else if ((imc >= 25) || (imc < 30))
            {
                Console.WriteLine("Entre 25,0 e 29,9 | Levemente acima do peso");
            }
            else if ((imc >= 30) || (imc < 35))
            {
                Console.WriteLine("Entre 30,0 e 34,9 | Obesidade Grau I");
            }
            else if ((imc >= 35) || (imc < 40))
            {
                Console.WriteLine("Entre 35,0 e 39,9 | Obesidade Grau II");
            }
            else
            {
                Console.WriteLine("Acima de 40 | Obesidade Grau III (Mórbida)");
            }
        }
    }
}