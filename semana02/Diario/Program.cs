using System;

class Program
{
    static void Main(string[] args)
    {
        Registro registro1 = new Registro();
        registro1._data = "03/11/2026";
        registro1._textoPergunta = "Qual foi a melhor parte do seu dia?";
        registro1._textoResposta = "Terminei o protótipo do Diário.";

        registro1.Exibir();

        GeradorDePerguntas gerador = new GeradorDePerguntas();
        
        string pergunta = gerador.ObterPerguntaAleatoria();
        Console.WriteLine($"{pergunta}");
        
        string pergunta2 = gerador.ObterPerguntaAleatoria();
        Console.WriteLine($"{pergunta2}");

        string pergunta3 = gerador.ObterPerguntaAleatoria();
        Console.WriteLine($"{pergunta3}");


    }
}