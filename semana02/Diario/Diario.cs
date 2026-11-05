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
        
    }


}