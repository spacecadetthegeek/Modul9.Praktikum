using System;

class Program
{
    static void Main(string[] args)
    {
        NumberReader numberReader = new NumberReader();
        numberReader.NumberEnterEvent += ShowNumber;
        try
        {
            numberReader.Read();
        }

        catch (FormatException)
        {
            Console.WriteLine("Введено некорректное значение!"); 
        }

    }

    static void ShowNumber(int number)
    {
        switch(number)
        {
            case 1: Console.WriteLine("Выбрана сортировка А-Я"); break;
            case 2: Console.WriteLine("Выбрана сортировка Я-А"); break;
        }
    }


}

class NumberReader
{
    public delegate void NumberEnterDelegate(int number);
    public event NumberEnterDelegate NumberEnterEvent;



    public void Read()
    {
        Console.WriteLine("\nВведите 1, если хотите сортровку А-Я или введите 2, если хотите сортировку Я-А:");

        int number = Convert.ToInt32(Console.ReadLine());

        if (number != 1 && number != 2) throw new FormatException();

        NumberEntered(number);


    }

    protected virtual void NumberEntered(int number)
    {
        NumberEnterEvent?.Invoke(number);
    }
}