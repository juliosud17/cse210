using System;

public class GeradorDePerguntas
{
    public List<string> _perguntas = new List<string>
    {
        "O que aconteceu hoje que você gostaria de lembrar no futuro?",
        "Qual foi a melhor parte do seu dia, mesmo que tenha sido algo simples?",
        "Como você se sentiu hoje? O que pode ter causado esse sentimento?",
        "Alguém fez ou disse algo que chamou sua atenção hoje?",
        "Qual foi um pequeno desafio que você enfrentou hoje?",
        "Se pudesse reviver cinco minutos do seu dia, quais escolheria?",
        "O que você percebeu ou aprendeu sobre si mesmo hoje?",
        "Houve algo que você gostaria de ter feito ou dito de maneira diferente?",
        "Pelo que você se sente grato hoje, mesmo que seja algo pequeno?",
        "Se pudesse deixar uma mensagem para a sua versão do futuro sobre hoje, o que diria?",
        
    };

       

    public string ObterPerguntaAleatoria()
    {
        Random gerador = new Random();
        int indice = gerador.Next(0,_perguntas.Count);
        string sorteada = _perguntas[indice];
        return sorteada;
    }

    
}