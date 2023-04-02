using System;

class MyException : Exception
{
    public MyException(string message) : base(message)
    {
    }
}

class Program
{
    static void Main(string[] args)
    {
        try
        {
            int[] arr = new int[5];
            arr[6] = 8;
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine($"IndexOutOfRangeException: {ex.Message}");
        }

        try
        {
            int a = 0;
            int b = 5 / a;
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine($"DivideByZeroException: {ex.Message}");
        }

        try
        {
            throw new TimeoutException();
        }
        catch (TimeoutException ex)
        {
            Console.WriteLine($"TimeoutException: {ex.Message}");
        }

        try
        {
            throw new MyException("Собственное исключение");
        }
        catch (MyException ex)
        {
            Console.WriteLine($"MyException: {ex.Message}");
        }

        try
        {
            throw new ArgumentException();
        }
        catch(ArgumentException ex)
        {
            Console.WriteLine($"ArgumentException: {ex.Message}");
        }

        finally
        {
            Console.WriteLine("Блок finally выполнен!");
        }
    }
}