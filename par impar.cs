/*
 * Created by SharpDevelop.
 * User: user
 * Date: 22/09/2021
 * Time: 17:13
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Projet
{
	class Program
	{
		public static void Main(string[] args)
		{
			int NumeroDigitado;

            Console.Write("Insira um número: "); 

            NumeroDigitado = Convert.ToInt32(Console.ReadLine());

            if (NumeroDigitado % 2 == 0)
            {
                Console.WriteLine("Par");
            }
            else
            {
                Console.WriteLine("Impar");
            }

            Console.ReadKey();
        }
    }
}