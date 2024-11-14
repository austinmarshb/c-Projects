using System;

namespace FizzingBuzzer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Program program = new Program();
            program.FizzBuzz();
        }

        public void FizzBuzz()
        {
            for (int i = 1; i <= 100; i++)
            {
                string output = "";

                if (i % 3 == 0)
                    output += "Fizz";
                if (i % 5 == 0)
                    output += "Buzz";

                if (output == "")
                    output = i.ToString();

                Console.WriteLine(output);
            }
        }
    }
}
