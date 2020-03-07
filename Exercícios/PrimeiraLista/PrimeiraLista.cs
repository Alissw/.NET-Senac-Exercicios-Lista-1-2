using System;

namespace PrimeiraLista
{
    class Exercicios
    {
        public static void Menu()
        {
            //Escopo global
            int opc;
            do
            {
                Console.WriteLine("[1]  -  Média de notas");
                Console.WriteLine("[2]  - Calcular área");
                Console.WriteLine("[3]  - Calcular volume");
                Console.WriteLine("[4]  - Maior que o dobro");
                Console.WriteLine("[5]  - Calcular Bhaskara");
                Console.WriteLine("[6]  - Calcular velocidade média");
                Console.WriteLine("[7]  - Calcular imposto");
                Console.WriteLine("[9]  - Comparando Strings");
                Console.WriteLine("[10] - String para INT");
                Console.WriteLine("[11] - Imposto de renda ");
                Console.WriteLine("[12] - Número primo ");
                Console.WriteLine("[13] - Sair ");
                Console.Write("Digite a opção desejada: ");
                opc = Convert.ToInt32(Console.ReadLine());
                switch (opc)
                {
                    case 1:

                        int nota1, nota2, nota3;
                        float media1;
                        Console.WriteLine("Exercício 1 - Média ");
                        Console.Write("Primeira nota: ");
                        nota1 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Segunda nota: ");
                        nota2 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Terceira nota: ");
                        nota3 = Convert.ToInt32(Console.ReadLine());

                        Console.Clear();
                        media1 = ((nota1 + nota2 + nota3) / 3);
                        Console.WriteLine("\n Resposta: " + media1);
                        Console.ReadLine();
                        break;
                    case 2:
                        //Exercicio2 - ÁREA
                        Console.WriteLine("Exercício 2 - Área ");
                        int lado1, lado2;
                        Console.Write("Lado 1: ");
                        lado1 = Convert.ToInt16(Console.ReadLine());
                        Console.Write("Lado 2: ");
                        lado2 = Convert.ToInt16(Console.ReadLine());

                        Console.Clear();
                        long area2 = lado1 * lado2;
                        Console.WriteLine("\n Exercício #2 - Resposta: " + area2);
                        break;
                    case 3:
                        int larg = 100;
                        int alt = 150;
                        int prof = 200;
                        long volume3;
                        //Exercicio3 - VOLUME
                        Console.WriteLine("Exercício 3 - Volume ");
                        Console.Write("Largura: ");
                        larg = Convert.ToInt16(Console.ReadLine());
                        Console.Write("Altura: ");
                        alt = Convert.ToInt16(Console.ReadLine());
                        Console.Write("Profundidade");
                        larg = Convert.ToInt16(Console.ReadLine());

                        Console.Clear();
                        volume3 = larg * alt * prof;
                        Console.WriteLine("\n Exercício #3 - Resposta: " + volume3);
                        break;
                    case 4:
                        //Exercicio4 - > ou < DOBRO
                        long dobro4;
                        int valor1, valor2;
                        Console.WriteLine("Exercício 3 - > || < dobro ");
                        Console.Write("Valor 1: ");
                        valor1 = Convert.ToInt16(Console.ReadLine());
                        Console.Write("Valor 2: ");
                        valor2 = Convert.ToInt16(Console.ReadLine());

                        Console.Clear();
                        dobro4 = (valor2 + valor2);
                        Console.WriteLine("\n Exercício #4 - Resposta: ");
                        Console.WriteLine("  ->Valor#1 = " + valor1);
                        Console.WriteLine("  ->Valor#2 = " + valor2);

                        if (valor1 > dobro4)
                        {
                            Console.WriteLine("  -->O Valor#1 é MAIOR que o dobro do Valor#2!");
                        }
                        else
                        {
                            Console.WriteLine("  -->O Valor#1 é MENOR que o dobro do Valor#2!");
                        }
                        break;
                    case 5:
                        //Exercicio5 - BHASKARA
                        int a = 1;
                        int b = 12;
                        int c = -13;
                        double delta, x1, x2;
                        Console.Clear();
                        delta = (b * b) + (-4 * (a * c));
                        Console.WriteLine("\n Exercício #5 - Resposta: ");
                        Console.WriteLine(" Delta: " + delta);

                        if (delta >= 0)
                        {
                            x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                            x2 = (-b - Math.Sqrt(delta)) / (2 * a);

                            Console.WriteLine(" x1 = " + x1);
                            Console.WriteLine(" x2 = " + x2);
                        }
                        else
                        {
                            Console.WriteLine(" Delta Não Possui Raiz!");
                        }
                        break;
                    case 6:
                        //Exercicio6 - VELOCIDADE
                        float dist6 = 240; //metros
                        float tempo6 = 3; //horas
                        float veloc6;

                        Console.Clear();
                        veloc6 = dist6 / tempo6;
                        Console.WriteLine("\n Exercício #6 - Resposta: " + veloc6 + " Km/h");
                        break;
                    case 7:
                        //Exercicio7 - IMPOSTO
                        float perc7 = 10;
                        float fatur7 = 5000;
                        float imposto7;

                        imposto7 = (fatur7 * perc7) / 100;
                        Console.WriteLine("\n Exercício #7 - Resposta: R$" + imposto7);

                        break;
                    case 8:
                        //Exercicio8 - PAR ou ÍMPAR
                        int num1 = 2;

                        if (num1 < 0)
                        {
                            Console.WriteLine("\n Exercício #8 - Resposta: O NÚMERO É NEGATIVO");
                        }
                        if (num1 > 0)
                            if (num1 % 2 == 0)
                            {
                                Console.WriteLine("\n Exercício #8 - Resposta: " + num1 + " É PAR");
                            }
                            else
                            {
                                Console.WriteLine("\n Exercício #8 - Resposta: " + num1 + " É ÍMPAR");
                            }
                        else{
                            Console.WriteLine("\n Exercício #8 - Resposta: " + num1 + "O número é neutro");

                        }
                        break;
                    case 9:
                        //Exercicio10 - STRINGS
                        {
                            String str1 = "teste1";
                            String str2 = "teste2".Substring(1);
                            Console.Clear();
                            //Console.WriteLine("str1: " + str1 + ", str2: " + str2);
                            if (str1 == str2)
                            {
                                Console.WriteLine("\n Exercício 10 - Resposta: STRING#1 é igual a STRING#2");
                            }
                            else
                            {
                                Console.WriteLine("\n Exercício #10 - Resposta: STRING#1 é diferente de STRING#2");
                            }
                        }
                        break;
                    case 10:
                        try
                        {
                            String numero = "10";
                            int numeroConvertido = Convert.ToInt16(numero);
                            int numeroVezes2 = numeroConvertido * 2;

                            Console.WriteLine("\n Exercício #11 - Resposta: " + numeroVezes2);
                        }

                        catch (NotFiniteNumberException)
                        {
                            Console.WriteLine("\n Exercício #11 - Resposta: Número inválido!");
                        }
                        break;
                    case 11:
                        //Exercicio12 - IMPOSTO DE RENDA
                        double salarioM = 3500;
                        double porc12 = salarioM <= 1903.98

                            ? 0
                            : salarioM >= 1903.99 && salarioM <= 2826.65
                                ? 7.5
                                : salarioM >= 2826.66 && salarioM <= 3751.05
                                    ? 15
                                    : salarioM >= 3751.06 && salarioM <= 4664.68
                                        ? 22.5
                                        : 27.5;

                        Console.WriteLine("\n Exercício #12 - Resposta: ");
                        Console.WriteLine("  ->Salário é: R$" + salarioM);
                        Console.WriteLine("  ->Alíquota do IR: " + porc12);
                        break;
                    case 12:
                        //DESAFIO - NÚMERO PRIMO
                        long numDes = 9973;
                        double numeroDouble = numDes;
                        if ((numeroDouble / numeroDouble) == (numDes / numDes))
                        {
                            if (numeroDouble / 2 != numDes / 2 || numDes == 2)
                            {
                                Console.WriteLine("\n DESAFIO - Resposta: Este numero É PRIMO!\n\n");
                            }
                            else
                            {
                                Console.WriteLine("\n DESAFIO - Resposta: Este numero NÃO É PRIMO!\n\n");
                            }
                        }
                        else
                        {
                            Console.WriteLine("\n DESAFIO - Resposta: Numero NÃO É PRIMO!\n\n");
                        }
                        break;

                    default:
                        Console.WriteLine("Sessão encerrada!");
                        break;
                }
            } while (opc != 13);
        }
    }
}