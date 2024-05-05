using System;

class Program
{
    public static void Main(string[] args)
    {

        //variaveis 
        int precV = 0;
        int precC = 0;
        int somaV = 0;
        int somaC = 0;
        int div = 0;
        int qtdi = 0;
        int qtdii = 0;
        int qtdiii = 0;



        do
        {
            Console.WriteLine("Insira o preço do produto de compra: ");
            precC = int.Parse(Console.ReadLine());

            if (precC != 0)
            {
                Console.WriteLine("Insira o preço do produto de venda: ");
                precV = int.Parse(Console.ReadLine());



                double res2 = (precV / (double)precC) * 100;
                res2 = res2 - 100;



                if (res2 < 10)
                {
                    qtdi++;
                }
                else if (10 <= res2 && res2 <= 20)
                {
                    qtdii++;
                }
                else if (res2 > 20)
                {
                    qtdiii++;
                }



                somaC += precC;
                somaV += precV;
            }



        } while (precC != 0);

        // Resultado  em compra e vendas
        Console.WriteLine("Valor total de compras: " + somaC);
        Console.WriteLine("Valor total de vendas: " + somaV);


        double res = (somaV / (double)somaC) * 100;
        res = res - 100;


        // Resultado 
        Console.WriteLine("Mercadorias abaixo de 10% de lucro: " + qtdi);
        Console.WriteLine("Mercadorias entre 10% e 20% de lucro: " + qtdii);
        Console.WriteLine("Mercadorias acima de 20% de lucro: " + qtdiii);
        Console.WriteLine("A porcentagem do lucro total é de: {0}%", res);



    }
}