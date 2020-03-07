using System;

namespace SegundaLista
{
    class ExercicioUm
    {
        public static void Exercicio_Um_Media(){
           Console.WriteLine("Exercício #1 - Média");

            float nota1, nota2, nota3, resultado;

           Console.Write("Primeira nota: ");
           nota1 = Convert.ToUInt16(Console.ReadLine());
           Console.Write("Segunda nota: ");
           nota2 = Convert.ToUInt16(Console.ReadLine());
           Console.Write("Terceira nota: ");
           nota3 = Convert.ToUInt16(Console.ReadLine());
           
           resultado = (nota1 + nota2 + nota3)/3;

           if(resultado>=7){
               Console.WriteLine("Aprovado com " + resultado);
           }else if (resultado <7 || resultado>=5){
               Console.WriteLine("Recuperação com " + resultado);
          }else{
               Console.WriteLine("Reprovado com " + resultado);
          }
        }
    }
    
}