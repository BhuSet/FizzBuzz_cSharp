using System;

namespace FizzBuzz_cSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = {"Fizz", "Buzz"};
            
            for(int i = 1; i <= 100; i++)
            {
                var output = "";

                if(i % 3 == 0)
                    output += names[0];
                if(i % 5 == 0)
                    output += names[1];
                
                if(string.IsNullOrEmpty(output))
                    output += i;
                
                Console.WriteLine(output);
            }
        }
    }
}
