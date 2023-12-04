using System;
class Program
{
    static void Main()
    {
        Console.Write("Введіть число: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number % 2 == 0)
        {
            Console.WriteLine("Введене число є парним");
        }
        else
        {
            Console.WriteLine("Введене число є непарним");
        }
        if (number % 3 == 0)
        {
            Console.WriteLine("Введене число ділиться на 3");
        }
        else
        {
            Console.WriteLine("Введене число не ділиться на 3");
        }
    }
}