using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        int n = 800000; // number of random numbers to generate
        double[,] doubleNumbers;
        int[,] intNumbers;
        Stopwatch timer = new Stopwatch();

        doubleNumbers = GenRandomNumbers(n);

        intNumbers = ConvertDoubleArrayToIntegerArray(doubleNumbers, n);

        timer.Start();
        AddIntegers(intNumbers, n);
        timer.Stop();
        Console.WriteLine("Addition of ints");
        Console.WriteLine("Elapsed time = " +
            timer.ElapsedMilliseconds + " ms " +
            timer.ElapsedTicks + " ticks\n");
        double addTicksInt = (float)timer.ElapsedTicks;

        timer.Restart();
        MultiplyIntegers(intNumbers, n);
        timer.Stop();
        Console.WriteLine("Multiplication of ints");
        Console.WriteLine("Elapsed time = " +
            timer.ElapsedMilliseconds + " ms " +
            timer.ElapsedTicks + " ticks\n");
        double multTicksInt = (float)timer.ElapsedTicks;

        timer.Restart();
        AddNumbers(doubleNumbers, n);
        timer.Stop();
        Console.WriteLine("Addition of doubles");
        Console.WriteLine("Elapsed time = " +
            timer.ElapsedMilliseconds + " ms " +
            timer.ElapsedTicks + " ticks\n");
        double addTicksDouble = (float)timer.ElapsedTicks;

        timer.Restart();
        MultiplyNumbers(doubleNumbers, n);
        timer.Stop();
        Console.WriteLine("Multiplication of doubles");
        Console.WriteLine("Elapsed time = " +
            timer.ElapsedMilliseconds + " ms " +
            timer.ElapsedTicks + " ticks\n");
        double multTicksDouble = (float)timer.ElapsedTicks;

        timer.Restart();
        SquareDirectMultiplication(doubleNumbers, n);
        timer.Stop();
        Console.WriteLine("Square via direct multiplication");
        Console.WriteLine("Elapsed time = " +
            timer.ElapsedMilliseconds + " ms " +
            timer.ElapsedTicks + " ticks\n");
        double squareTicksDirect = (float)timer.ElapsedTicks;

        timer.Restart();
        SquareMathPow(doubleNumbers, n);
        timer.Stop();
        Console.WriteLine("Square using Math.Pow function");
        Console.WriteLine("Elapsed time = " +
            timer.ElapsedMilliseconds + " ms " +
            timer.ElapsedTicks + " ticks\n");
        double squareTicksPow = (float)timer.ElapsedTicks;

        timer.Restart();
        SquareMathSqrt(doubleNumbers, n);
        timer.Stop();
        Console.WriteLine("Square root using Math.Sqrt function");
        Console.WriteLine("Elapsed time = " +
            timer.ElapsedMilliseconds + " ms " +
            timer.ElapsedTicks + " ticks\n");
        double sqrtTicks = (float)timer.ElapsedTicks;

      
    }

    // Function to generate an array of random doubles
    static double[,] GenRandomNumbers(int count)
    {
        Random rand = new Random(); // initiate random number generator
        double[,] num = new double[count, 3]; // make array
        for (int i = 0; i < count; ++i)
        {
            num[i, 0] = 10000.0 * rand.NextDouble(); // fill in elements of array
            num[i, 1] = 10000.0 * rand.NextDouble();
        }

        return num; // returns reference to array
    }

    // Function to convert a double array to an equivalent integer array
    static int[,] ConvertDoubleArrayToIntegerArray(double[,] doubleArray, int count)
    {
        int[,] intArray = new int[count, 3]; 
        int i;
        for (i = 0; i < count; ++i)
        {
            intArray[i, 0] = (int)doubleArray[i, 0];
            intArray[i, 1] = (int)doubleArray[i, 1];
        }
        return intArray;
    }

    // Function that adds integers
    static void AddIntegers(int[,] nums, int count)
    {
        int i;
        for (i = 0; i < count; ++i)
        {
            nums[i, 2] = nums[i, 0] + nums[i, 1];
        }
    }

    // Function that multiplies integers
    static void MultiplyIntegers(int[,] nums, int count)
    {
        int i;
        for (i = 0; i < count; ++i)
        {
            nums[i, 2] = nums[i, 0] * nums[i, 1];
        }
    }

    // Function that adds doubles
    static void AddNumbers(double[,] nums, int count)
    {
        int i;
        for (i = 0; i < count; ++i)
        {
            nums[i, 2] = nums[i, 0] + nums[i, 1];
        }
    }

    // Function that multiplies doubles
    static void MultiplyNumbers(double[,] nums, int count)
    {
        int i;
        for (i = 0; i < count; ++i)
        {
            nums[i, 2] = nums[i, 0] * nums[i, 1];
        }
    }

    // Function that finds the square directly 
    static void SquareDirectMultiplication(double[,] nums, int count)
    {
        int i;
        for (i = 0; i < count; ++i)
        {
            nums[i, 2] = nums[i, 0] * nums[i, 0];
        }
    }

    // Function that uses mathpow
    static void SquareMathPow(double[,] nums, int count)
    {
        int i;
        for (i = 0; i < count; ++i)
        {
            nums[i, 2] = Math.Pow(nums[i, 0], 2);
        }
    }

    // Function for sqrt
    static void SquareMathSqrt(double[,] nums, int count)
    {
        int i;
        for (i = 0; i < count; ++i)
        {
            nums[i, 2] = Math.Sqrt(nums[i, 0]);
        }
    }
}

