using System;

public class Video
{
    private string _titulo;
    private string _autor;
    private int _duracao;
    private List<Comentario> _comentarios = new List<Comentario>();

    public Video(string titulo, string autor, int duracao)
    {
        _titulo = titulo;
        _autor = autor;
        _duracao = duracao;
    }

    public void AdicionarComentario(Comentario novoComentario)
    {
        _comentarios.Add(novoComentario);
    }

    public int ContarComentarios()
    {
        return _comentarios.Count;
    }

    public void ExibirComentarios()
    {
        foreach (Comentario comentario in _comentarios)
        {
            comentario.Exibir();
        }
    }

    public void ExibirVideo()
    {
        Console.WriteLine($"Título: {_titulo}");
        Console.WriteLine($"Autor: {_autor}");
        Console.WriteLine($"Duração: {_duracao} segundos.");
        Console.WriteLine($"Quantidade de comentários: {ContarComentarios()}");
        ExibirComentarios();
    }
}
