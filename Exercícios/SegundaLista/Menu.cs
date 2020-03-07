using System;

namespace SegundaLista{
    class Menu
    {
        public static void MenuExercicios(){
            int opc;

            do{    
                Console.WriteLine("Lista de exercicios 2");
                Console.WriteLine("[1] - Calcular Média");
                Console.WriteLine("[2] - Representação de mês");
                Console.WriteLine("[3] - Jogo da forca ");
                Console.WriteLine("[4] - Tabuada");
                Console.WriteLine("[5] - String em linha");
                Console.WriteLine("[6] - Ímpares e múltiplos de 7");
                Console.WriteLine("[7] - Entrada de notas (Só para com Nº negativo)");
                Console.WriteLine("[8] - Fatorial");
                Console.WriteLine("[9] - IMC");
                Console.WriteLine("[10] - Determinando notas para inteirar valor");

                Console.Write("Operação: ");
                opc = Convert.ToInt16(Console.ReadLine());
                Console.Clear();

            
                switch(opc){
                    case 1:
                        ExercicioUm.Exercicio_Um_Media();
                    break;
                    case 2:
                        ExercicioDois.Exercicio_Dois();
                    break;
                    case 3:
                        ExercicioTres.Exercicio_Tres();
                    break;
                    case 4:
                        ExercicioQuatro.Exercicio_Quatro();
                    break;
                    case 5:
                        ExercicioCinco.Exercicio_Cinco();
                    break;
                    case 6:
                        ExercicioSeis.Exercicio_Seis();
                    break;
                    case 7:
                        ExercicioSete.Exercicio_Sete();
                    break;
                    case 8:
                        ExercicioOito.Exercicio_Oito();
                    break;
                    case 9:
                        ExercicioNove.Exercicio_Nove();
                    break;
                    case 10:
                        ExercicioDez.Exercicio_Dez();
                    break;
                    default:

                    break;
                }
            }while(opc != 10);
        }
    }
}