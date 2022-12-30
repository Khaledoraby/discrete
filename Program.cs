using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace perfect_number
{
    internal class Program
    {
        static bool Isperfect(int number)
        {

            int sum = 0;    
            for (int i=1;i<number;i++)
            {
                if (number%i == 0) sum=sum+1;  
            }

            if (sum == number) return true;
          
            return false;

        }


        static void Main(string[]args)
        {

            int x,y ;
            Console.WriteLine("enter the frist num ");
                x = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the second num");
            y = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            for( int i= x ;i<= y ; i++)
            {
                if (Isperfect(i)) Console.WriteLine("{0}, "+i);

                
            }



            Console.ReadKey();  

        }








    }
}
