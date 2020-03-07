using System;

namespace principal{
    class Program
    {
        public static void Main(String[] args){
            Console.WriteLine("Listas de exercícios");
            int opc;
            do{
                Console.WriteLine("[1] - Primeira lista");
                Console.WriteLine("[2] - Segunda lista\n");
                
                Console.Write("Digite a opção desejada: ");
                opc = Convert.ToInt16(Console.ReadLine());

                switch(opc){
                    case 1:
                        PrimeiraLista.Exercicios.Menu();
                        Console.Clear();
                    break;
                    case 2:
                        SegundaLista.Menu.MenuExercicios();
                        Console.Clear();
                    break;
                    default:
                        Console.WriteLine("Sessão encerrada");
                        Console.Clear();
                    break;
                }

            }while(opc != 12);
        }
    }
}