using System;

namespace FizzBuzz_cSharp
{
    class Program
    {
        //static string[] names = {"Fizz", "Buzz"};
        static string FizzRule(int num, string output)
        {
            return((num % 3 == 0) ? output += "Fizz": output);
        }   

        static string BuzzRule(int num, string output)
        {
            return((num % 5 == 0) ? output += "Buzz" : output);
        }

        static string BangRule(int num, string output)
        {
            return((num % 7 == 0) ? output += "Bang" : output);
        }

        static string BongRule(int num, string output)
        {
            return((num % 11 == 0) ? output = "Bong" : output);
        }

        static string FezzRule(int num, string output)
        {
            if(num % 13 == 0)
            {
                var pos = output.IndexOf('B');
                return ((pos > 0) ? (output.Substring(0, pos) + "Fezz" + output.Substring(pos)) : ("Fezz" + output)); 
            }
            return output;
        }

        static void Main(string[] args)
        {
            
            for(int i = 1; i <= 195; i++)
            {
                var output = "";

                output = FizzRule(i, output);
                output = BuzzRule(i, output);
                output = BangRule(i, output);
                output = BongRule(i, output);
                output = FezzRule(i, output);
                
                //if(string.IsNullOrEmpty(output))
                    //output += i;
                
                Console.WriteLine((output == "")? i : output);
            }
        }
    }
}
