using System;

class Program
{
    public static void Main(string[] args)
    {
        int num = 0;

        Console.WriteLine("Informe um número");
        num = int.Parse(Console.ReadLine());


        for (int i = num - 1; i > 0; i--)
        {
            num = num * i;

        }


        if (num < 0)
        {
            Console.WriteLine("Número invalido");
        }
        else
        {
            Console.WriteLine(" " + num);
        }
    }
}