using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Моля, въведете рожденна дата:");
        string line = Console.ReadLine(); // Read string from console
        int value;
        if (int.TryParse(line, out value)) // Try to parse the string as an integer
        {
            Console.WriteLine("След 10 години Вие ще сте на:");
            Console.WriteLine(DateTime.Now.Year + 10 - value);
            Console.WriteLine("години");
        }
        else 
        {
            Console.WriteLine("Моля, въведете година на раждане!");
        }
    }
}
