using System;

namespace SegundaLista{
    class ExercicioDois
    {
        public static  void Exercicio_Dois(){
             int mes = 0;

            Console.WriteLine("Digite um número: ");
            mes = Convert.ToInt16(Console.ReadLine());

            switch(mes){
                case 1:{
                    Console.WriteLine("1 - Janeiro");
                    break;
                }
                case 2:{
                    Console.WriteLine("2 - Fevereiro");
                    break;
                }
                case 3:{
                    Console.WriteLine("3 - Março");
                    break;
                }
                case 4:{
                    Console.WriteLine("4 - Abril");
                    break;
                }
                case 5:{
                    Console.WriteLine(" 5 - Maio");
                    break;
                }
                case 6:{
                    Console.WriteLine("6 - Junho");
                    break;
                }
                case 7:{
                    Console.WriteLine("7 - Julho");
                    break;
                }
                case 8:{
                    Console.WriteLine("8 - Agosto");
                    break;
                }
                case 9:{
                    Console.WriteLine("9 - Setembro");
                    break;
                }
                case 10:{
                    Console.WriteLine("10 - Outubro");
                    break;
                }
                case 11:{
                    Console.WriteLine("11 - Novembro");
                    break;
                }
                case 12:{
                    Console.WriteLine("12 - Dezembro");
                    break;
                }default:{
                    Console.WriteLine("Mês inválido");
                    break;
                }
            }
        }
    }
}