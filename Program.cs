using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // Først definerer man værdierne 
            int num1, num2;
            byte result;
            num1 = 30;
            num2 = 60;

            // Så tester vi lortet ved hjælp af en try block 
            try
            {
                result = Convert.ToByte(num1 * num2);
                Console.WriteLine("{0} x {1} = {2}", num1, num2, result);
                // Kommer der en fejl i udregningen, så hopper vi lige engang ned og prøver at ordne "el problema" nede i catch 
                
            }
            
            catch(OverflowException)
            {
                // Her kunne der være en kode som forhindre overstående kode i at "crashe" men det var ikke en del af opgaven, så "that's gonna be a no from me fam"
                Console.WriteLine("Everything is good?");
                // Af en eller anden grund skal der være en readline her ellers lukker programmet bare, sad :( ......
                Console.ReadLine();
            }
        }

    }
}

