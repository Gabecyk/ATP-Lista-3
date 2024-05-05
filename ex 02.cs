using System;

class Program
{
    static void Main(string[] args)
    {

        // variaveis 
        int num = 0;
        int nN = 0, nZ = 0, nP = 0;
        char res = '0';

        Console.WriteLine("Digite o valor inteiro:");


        // do while 
        do
        {
            num = int.Parse(Console.ReadLine());
            Console.WriteLine("Você quer acrescentar mais algum número? 'S' ou 'N'");
            res = char.Parse(Console.ReadLine());


            // verificar o número
            if (num > 0)
            {
                nP++;
            }
            else if (num < 0)
            {
                nN++;
            }
            else if (num == 0)
            {
                nZ++;
            }

        } while (res != 'N');
        int totalValores = nP + nN + nZ; 

        //  Porcentagem 
        double percentualPositivos = (nP / (double)totalValores) * 100;
        double percentualNegativos = (nN / (double)totalValores) * 100;
        double percentualZeros = (nZ / (double)totalValores) * 100;

        // Resultado 
        Console.WriteLine($"Números Positivos: {nP} ({percentualPositivos:F2}%)");
        Console.WriteLine($"Números Negativos: {nN} ({percentualNegativos:F2}%)");
        Console.WriteLine($"Números Zeros: {nZ} ({percentualZeros:F2}%)");



    }
}using System;

class Program
{
    static void Main(string[] args)
    {

        // variaveis 
        int num = 0;
        int nN = 0, nZ = 0, nP = 0;
        char res = '0';

        Console.WriteLine("Digite o valor inteiro:");


        // do while 
        do
        {
            num = int.Parse(Console.ReadLine());
            Console.WriteLine("Você quer acrescentar mais algum número? 'S' ou 'N'");
            res = char.Parse(Console.ReadLine());


            // verificar o número
            if (num > 0)
            {
                nP++;
            }
            else if (num < 0)
            {
                nN++;
            }
            else if (num == 0)
            {
                nZ++;
            }

        } while (res != 'N');
        int totalValores = nP + nN + nZ; 

        //  Porcentagem 
        double percentualPositivos = (nP / (double)totalValores) * 100;
        double percentualNegativos = (nN / (double)totalValores) * 100;
        double percentualZeros = (nZ / (double)totalValores) * 100;

        // Resultado 
        Console.WriteLine($"Números Positivos: {nP} ({percentualPositivos:F2}%)");
        Console.WriteLine($"Números Negativos: {nN} ({percentualNegativos:F2}%)");
        Console.WriteLine($"Números Zeros: {nZ} ({percentualZeros:F2}%)");



    }
}