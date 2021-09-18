using System;

namespace ConsoleApp2
{ 
    class Program 
    { static void Main(string[] args) 
        { 
            int inicio; 
            int fim; 
            int total; 
            
            Console.WriteLine("Qual o horário do início do jogo?"); 
            
            inicio = Convert.ToInt32(Console.ReadLine()); 
            
            Console.WriteLine("Qual o horário de término do jogo?"); 
            
            fim = Convert.ToInt32(Console.ReadLine()); if (fim < inicio)             
            {             
                total = (24 - inicio) + fim;             
            }             
            else             
            {             
                total = fim - inicio;             
            }             
            Console.WriteLine("O total de horas do jogo de xadrez foi:"); 
            
            Console.Write(total); 
            
            Console.ReadKey();         
        }     
    } 
}