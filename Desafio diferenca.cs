using System;
//Leia quatro valores inteiros A, B, C e D. A seguir, calcule e mostre a diferença do produto de A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D).
//Entrada
//O arquivo de entrada contém 4 valores inteiros.
//Saída
//Imprima a mensagem DIFERENCA com todas as letras maiúsculas, conforme exemplo abaixo, com um espaço em branco antes e depois da igualdade.



namespace Desafio
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d, dife;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            d = Convert.ToInt32(Console.ReadLine());              
            
            variavel = int.Parse(Console.ReadLine());

            dife = ((a * b) - (c * d));
            
            Console.WriteLine("DIFERENCA = " + dife);
            Console.ReadKey();
        }
    }
}