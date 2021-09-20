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

        static string ReverseRule(int num, string output)
        {
            if(num % 17 == 0)
            {
                var reverseOutput = "";
                while(output.Length > 0)
                {
                    reverseOutput += output.Substring(output.Length-4);
                    output = output.Substring(0, output.Length-4);
                }
                return reverseOutput;
            }
            return output;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Max Limit to be printed : ");
            int maxNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Rule to apply : \n1. FizzBuzzFezz Rules only \n2. All Rules");
            var RulestoApply = Convert.ToInt32(Console.ReadLine());
            
            for(int i = 1; i <= maxNum; i++)
            {
                var output = "";

                output = FizzRule(i, output);
                output = BuzzRule(i, output);
                if(RulestoApply == 2)
                {
                    output = BangRule(i, output);
                    output = BongRule(i, output);
                }
                output = FezzRule(i, output);
                output = ReverseRule(i, output);
                
                Console.WriteLine((output == "")? i : output);
            }
        }
    }
}
