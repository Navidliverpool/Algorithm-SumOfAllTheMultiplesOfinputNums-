using System;

namespace AlgorithmPracticeSumOfAllTheMultiplesOfinputNums
{
    public static class Kata
    {
        public static int Calculation(int firstInt, int secondInt, int value)
        {
            int count = 0;
            for (int i = 0; i < value; i++)
            {
                if (i % firstInt == 0 || i % secondInt == 0)
                {
                    count += i;
                }
                else if (i % firstInt == 0 && i % secondInt != 0)
                {
                    count += i;
                }
                else if(i % secondInt == 0 && i % firstInt != 0)
                {
                    count += i;
                }
            }
            return count;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.Calculation(3,5,10));
            Console.WriteLine("To calculate the " +
                "sum of all the multiples of the first inserted number and the " +
                "second one, insert the first number, please: ");

        }
    }
}
