using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        PrimeNum(50);

        Console.WriteLine(IsPerfect(12));
        PerfektNumbers(500);
        ReversedOrder(1235);
        Console.WriteLine(SumOfDigit(1234));
        Console.WriteLine(ReverseNumber(777));
        Console.WriteLine($"number Of Digit Frequency : {FrequencyDigit(223322, 2)}");
        AllFrequencyDigit(2233);
        PrintInOrder(2345);
    }


    public static void PrimeNum(int num)
    {
        for (int i = 2; i < num; i++)
        {
            bool isPrime = true;


            for (int j = 2; j < i; j++)
            {


                if (i % j == 0)
                {
                    isPrime = false;
                    break;
                }

            }
            if (isPrime)
            {
                Console.WriteLine($" Prim Numbers: {i}");
            }



        }
    }

    public static bool IsPerfect(int number)
    {
        int sum = 0;

        for (int i = 1; i < number; i++)

        {
            if (number % i == 0)
            {
                sum += i;
            }
        }
        return sum == number;
    }


    public static void PerfektNumbers(int number)
    {
        for (int i = 1; i < number; i++)
        {
            if (IsPerfect(i))
            {
                Console.WriteLine(i);
            }
        }
    }

    public static int ReversedOrder(int num)
    {
        bool result = true;
        int lastDigit = 0;
        while (result)
        {
            lastDigit = num % 10;
            int restNum = num / 10;
            num = restNum;
            if (num == 0)
            {
                result = false;
            }
            Console.WriteLine(lastDigit);

        }

        return lastDigit;
    }

    public static int SumOfDigit(int num)
    {
        int sum = 0;
        while (num > 0)
        {
            int lastDigit = num % 10;
            sum += lastDigit;

            num = num / 10;
        }
        return sum;
    }


    public static int ReverseNumber(int number)
    {
        int result = 0;
        while (number > 0)
        {
            int lastDigit = number % 10;
            result = result * 10 + lastDigit;
            number = number / 10;
        }

        return result;

    }

    public static int FrequencyDigit(int digit, int num)
    {
        int count = 0;
        while (digit > 0)
        {
            int lastDigit = digit % 10;
            if (lastDigit == num)
            {
                count++;
            }
            digit = digit / 10;

        }
        return count;
    }

    public static void AllFrequencyDigit(int digit)
    {
        for (int i = 0; i < 10; i++)
        {
            int num = FrequencyDigit(digit, i);

            Console.WriteLine($"the digit {i} is {num} Time");

        }
    }

    public static void PrintInOrder(int number)
    {
        int lastDigit = 0;
        int num = ReverseNumber(number);
        Console.WriteLine("my num" + num);
        while (num > 0)
        {
            lastDigit = num % 10;
            Console.WriteLine(lastDigit);

            num = num / 10;
        }
    }

}