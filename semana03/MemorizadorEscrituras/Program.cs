using System;

class Program
{
    static void Main(string[] args)
    {
        Palavra palavra = new Palavra("Deus");

        Console.WriteLine(palavra.ObterTexto());

        palavra.Ocultar();
        Console.WriteLine(palavra.ObterTexto());

        palavra.Exibir();
        Console.WriteLine(palavra.ObterTexto());

        Referencia referencia = new Referencia("Joao", 3, 16);
        Console.WriteLine(referencia.ObterTexto());

        Referencia referencia2 = new Referencia("Joao", 3, 16, 25);
        Console.WriteLine(referencia2.ObterTexto());
        
    
    }
}