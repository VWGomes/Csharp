using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{ 
    class Program 
    { 
        static void Main(string[] args) 
        { 
            int numero = int.Parse(Console.ReadLine()); 
            if (numero > 10) 
            { Console.WriteLine("É MAIOR QUE 10!"); 
            } else 
            { Console.WriteLine("NÃO É MAIOR QUE 10!"); 
            } Console.ReadLine(); 
        } 
    } 
}