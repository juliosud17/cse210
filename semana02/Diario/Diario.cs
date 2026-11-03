using System;

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
        
    }

    public void CarregarDoArquivo(string arquivo)
    {
        
    }


}