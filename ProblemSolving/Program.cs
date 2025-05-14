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
        Console.WriteLine(IsPalindrom(14521));
        InvertedNumberPattern(5);
        NumberPattern(5);
        InvertedLetterPattern(5);
        LetterPattern(5);
        Console.WriteLine(AAAToZZZ());
        GuessLetterPass("AAF");
       Encrypt("Mohammed", 2);
       DeCrypt("Oqjcoogf", 2);
        //Console.WriteLine(GetRandomNumber(1, 10));
        PrintThreeRandom();
        Employees emp = new Employees("Ahmed",10,2);
        Console.WriteLine($"Your Salary is: {emp.Name}  {emp.CalculateNetSalary()}");
        emp = new Employees("Ali", 12, 2);
        Console.WriteLine($"Your Salary is: {emp.Name}   {emp.CalculateNetSalary()} {Employees.TAX}");
       PrintArrayWithRandom();
        Console.WriteLine("max num is  :" + PrintMaxNumOfRandom());
        Console.WriteLine("min num is  :" + PrintMinNumOfRandom());
        Console.WriteLine("sum   :" + SumNumOfRandom());
        Console.WriteLine("Average  :" + AverageOfRandom());
        CopyOfArray();
        

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


    public static bool IsPalindrom(int number)
    {
        int reverseNum = ReverseNumber(number);
        if (number == reverseNum)
        {
            return true;
        }
        return false;
    }

    public static void InvertedNumberPattern(int number)
    {
        for (int i = number; i >0; i--)
        {
            for (int j = i; j > 0; j--)
            {
                Console.Write(i+" ");
            }

            Console.WriteLine(" ");
        }
    }

    public static void NumberPattern(int number)
    {
        for (int i = 1; i < number; i++)
        {
            for (int j = i; j < number; j++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine(" ");
        }
    }

    public static void InvertedLetterPattern(int number)
    {
        for (int i = 65+number; i >= 65 ; i--) 
        {
            for (int j = i; j >= 65; j--)
            {
                Console.Write((char)i + " ");
            }
            Console.WriteLine(" ");
        }
    }

    public static void LetterPattern(int number)
    {
        for (int i = 65; i < 65+number; i++)
        {
            for (int j = 65; j <= i; j++)
            {
                Console.Write((char)i + " ");
            }
            Console.WriteLine(" ");
        }
    }

    public static IEnumerable<string> AAAToZZZ()
      
    {
       
        for (int i = 65; i <=90; i++)
        {


            for (int j = 65; j <= 90; j++)
            {

                for (int k = 65; k <= 90; k++)
                {
                    yield return $"{(char)i}{(char)j}{(char)k}";

                }

                
            }
           
        }
       
    }

    public static void GuessLetterPass(string pass)
    {
        int count = 0;
        foreach (string guess in AAAToZZZ()){
            count++;
            if (guess == pass){

                Console.WriteLine(guess);
                break;

            }
            Console.WriteLine($"{guess} ");

        }
        Console.WriteLine($"Guess is After {count}");
    }
        
    public static void Encrypt(string name ,int num)
    {
        string result = "";
        for (int i = 0; i <name.Length; i++)
        {
            char c = name[i];
            char encrypt = (char)(c + num);
            result += encrypt;
        }
        Console.WriteLine(result);
    }

    public static void DeCrypt(string name , int num)
    {
        string result = "";
        for (int i = 0; i < name.Length; i++)
        {
            char c = name[i];
            char decrypt = (char)(c - num);
            result += decrypt;
        }
        Console.WriteLine(result);
    }

    public static int GetRandomNumber(int min,int max)
    {
        Random random = new Random();
        int rand=random.Next(min, max + 1);
        return rand;
    }

    public static void PrintThreeRandom()
    {
        for (int i = 1; i < 4; i++)
        {
            Console.WriteLine(GetRandomNumber(1, 10)+ " ");
        }
    }
    class Employees
    {
        public const double TAX=0.03;
        public string Name;
        public double HoursWorked;
        public double HourlyWage;
        
        public Employees(string name , double hoursWorked, double hourlyWage)
        {
            Name = name;
            HourlyWage = hourlyWage;
            HoursWorked = hoursWorked;
           

        }


        public double CalculateNetSalary()
        {
            double sum = HourlyWage * HoursWorked;
                double net =sum - TAX;
            return sum;
        }
    }

    
    public static void FillArrayWithRandom(int[] a)
    {
      
        for (int i = 0; i < 10; i++)
        {
            a[i] = GetRandomNumber(1, 101);
        }
    }
    public static int[] PrintArrayWithRandom()
    {
        int[] a = new int[10];
        FillArrayWithRandom(a);
        foreach (int i in a)
        {
            Console.Write(i + " ,");
        }
        Console.WriteLine();
        return a;
    }

    public static int PrintMaxNumOfRandom()
    {
        int[] a = PrintArrayWithRandom();
        int max = a[0];
        for (int i = 0; i < a.Length; i++)
        {
           if( a[i] >max)
            {
                max = a[i];
            }
        }
        return max;
    }
    public static int PrintMinNumOfRandom()
    {
        int[]a= PrintArrayWithRandom();
       int min= a[0];
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] < min)
            {
                min = a[i];
            }
        }
        return min;
    }
    public static int SumNumOfRandom()
    {
        int[] a = PrintArrayWithRandom();
        int sum = 0;
        for (int i = 0; i < a.Length; i++)
        {
            sum += a[i];
        }
        return sum;
    }

    public static double AverageOfRandom()
    {
        int[] a = PrintArrayWithRandom();
        int n = a.Length;
        double average = SumNumOfRandom() / n;
        return average;
    }

    public static int[] CopyOfArray()
    {
        int[]a= PrintArrayWithRandom();
        Console.Write("Original Of Array: ");
        foreach (int n in a)
        {
           
            Console.Write(n+ " , ");
        }
       
        int[] b=new int[10];
        for (int i = 0; i < a.Length; i++)
        {
            b[i] = a[i];
        }
        Console.WriteLine(" ");
        Console.Write("Copy Of Array:   ");
        foreach (int m in b)
        {
            
            Console.Write(m + ",  ");
        }
        return b;
    }
}