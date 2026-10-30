using System;

class Program
{
    static void Main(string[] args)
    {
        Random gerador = new Random();
        int magico = gerador.Next(1, 101);

        int palpite = -1;

        while (palpite != magico)
        {
            Console.Write("Qual é o seu palpite? ");
            string resposta2 = Console.ReadLine();
            palpite = int.Parse(resposta2);

            if (palpite < magico)
            {
                Console.WriteLine("Mais alto");
            }
            else if (palpite > magico)
            {
                Console.WriteLine("Mais baixo");
            }
            else
            {
                Console.WriteLine("Você adivinhou!");
            }
        }

    }

}