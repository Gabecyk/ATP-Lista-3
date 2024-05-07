using System;
class Program{

   public static void Main(string []args){
         int divisivelPor3e9 = 0;
                    int divisivelPor2e5 = 0;
                    int naoDivisivel = 0;

                    for (int i = 0; i < 10; i++) 
                    {
                        Console.Write($"Digite o {i + 1}º número: ");
                        int num = int.Parse(Console.ReadLine());

                        if (num % 3 ==0 && num % 9 ==0)
                        {
                            Console.WriteLine($"{num} e divisivel por 3 e 9");
                            divisivelPor3e9++;
                        }
                        else if (num % 2 == 0 && num % 5 ==0)
                        {
                            Console.WriteLine($"{num} e divisivel por 2 e 5");
                            divisivelPor2e5++;
                        }
                        else{
                            Console.WriteLine($"{num} não e divisivel por nenhum das opçoes");
                            naoDivisivel++;         
                        }
                    }
                        Console.WriteLine($"Quantidade de números divisíveis por 3 e 9: {divisivelPor3e9}");
                        Console.WriteLine($"Quantidade de números divisíveis por 2 e 5: {divisivelPor2e5}");
                        Console.WriteLine($"Quantidade de números não divisíveis por ambos: {naoDivisivel}");
                    
                     
                    

   }











}
