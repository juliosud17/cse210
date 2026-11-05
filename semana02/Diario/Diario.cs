using System;
using System.IO;

public class Diario
{
    public List<Registro> _registros = new List<Registro>();
    
    public void AdicionarRegistro(Registro novoRegistro)
    {
        _registros.Add(novoRegistro);

    }
    
    public void ExibirTodos()
    {
        foreach (Registro registro in _registros)
        {
            registro.Exibir();
        }
    }

    public void SalvarNoArquivo(string arquivo)
    {
        using (StreamWriter escritor = new StreamWriter(arquivo))
        {
            foreach (Registro  registro in _registros)
            {
                escritor.WriteLine($"{registro._data}~|~{registro._textoPergunta}~|~{registro._textoResposta}");
            }
        }
    }

    public void CarregarDoArquivo(string arquivo)
    {
        if (!File.Exists(arquivo))
        {
            Console.WriteLine($"arquivo {arquivo} não encontrado.");
            return;
        }

        _registros.Clear();

        string [] linhas = File.ReadAllLines(arquivo);

        foreach (string  linha in linhas)
        {
            string[] partes = linha.Split("~|~");
            string data = partes[0];
            string pergunta = partes[1];
            string resposta = partes[2];

            Registro novoRegistro = new Registro();
            novoRegistro._data = data;
            novoRegistro._textoPergunta = pergunta;
            novoRegistro._textoResposta = resposta;

            _registros.Add(novoRegistro);

        }
    

    
    }


}