using System;

namespace MethodsandLoops_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print1000();
            PrintBy3();
            //EqualOrNot(1, 4);
            //IsEvenOrOdd(2);
            //IsPositiveOrNegative(3);
            //CanVote("18");
            //InRange(2);
            //ArrayedOfIndexers(7);
            //MultiplicationTable(11);
            //ComputeSumOfArray( new int[] { 1, 2, 3, 4, 5, 6 });
            //CubedNumber(5);

        }
       public static void Print1000()
        {
            for (int i = 1000; i < 1000; i--)
            {
                Console.WriteLine();
            }
        }
       public static void PrintBy3()
        {
            for (int i = 3; i < 999; i += 3)
            {
                Console.WriteLine(i);
            }

        }
        static void EqualOrNot(int x, int y)
        {
            if (x == y)
            {
                Console.WriteLine("x is equal to y");
            }
        }
        static void IsEvenOrOdd(int x)
        {
            if (x % 2 == 0)
            {
                Console.WriteLine("This number is even");
            }
            else
            {
                Console.WriteLine("This number is odd");
            }
        }

        static void IsPositiveOrNegative(int x)
        {
            if (x >= 0)
            {
                Console.WriteLine("This number is positvie");
            }
            else
            {
                Console.WriteLine("This number is negative");
            }
        }

        static void CanVote(string age)
        {
            int num;
            if (int.TryParse(age, out num))
            {
                Console.WriteLine("You are old enought to vote!");
            }
            else
            {
                Console.WriteLine("You are not old enough to vote!");
            }
        }

        static void InRange(int userInput)
        {
            if (userInput >= -10 && userInput <= 10)
            {
                Console.WriteLine("The number is in the range of 10 <--> -10");
            }
            else
            {
                Console.WriteLine("The nu,ber is not in the reange of 10 <--> -10");
            }
        }

        static void MultiplicationTable(int number)
        {
            int counter = 1;
            for (int i = 1; i < 12; i++)
            {
                Console.WriteLine($"{number} * {counter} = {number * counter}");
                counter++;
            }
        }
        static int[] ArraryOfIndexers(int number)
        {
            int[] arr = new int[number];
            Random r = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = r.Next(1, 100);
            }
            return arr;
        }

        static int ComputeSumOfArray(int[] arr)
        {
            int sum = 0;
            foreach (var item in arr)
            {
                sum += item;
            }
            return sum;
        }

        static void CubedNumber(int number)
        {
            for (int i = 1; i <= number ; i++)
            {
                Console.WriteLine($"The number is: {i} and the cube of {i} is (Math.Pow(i, 3))");
            }

        }
    }
    
}
