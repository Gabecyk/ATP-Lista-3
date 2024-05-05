using System;

class Program
{
    public static void Main(string[] args)
    {

        // variáveis
        double salario = 0; double media = 0; double maiors = 0;

        int nF = 0; int medianF = 0; int i = 0; int p = 0;


        while (salario != -1)
        {
            Console.WriteLine("Salário: ");
            salario = double.Parse(Console.ReadLine());

            if (salario < 0)
            {

            }
            else if (salario != -1)
            {
                Console.WriteLine("Número de filhos");
                nF = int.Parse(Console.ReadLine());
                media += salario;
                medianF += nF;
                i++;

                if (salario > maiors)
                {
                    maiors = salario;
                }
                if (salario <= 100)
                {

                    p++;
                }
            }



        }

        // Resultados
        media = media / i;
        medianF = medianF / i;
        double Porcentagem = (p / (double)i) * 100;

        Console.WriteLine("A média salárial: " + media);
        Console.WriteLine("A média de filhos: " + medianF);
        Console.WriteLine("O maior salário: " + maiors);
        Console.WriteLine($"Porcentagem de salarios de até 100: {p} ({Porcentagem:F2}%)");
    }
}