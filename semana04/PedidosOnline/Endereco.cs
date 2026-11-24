using System;

public class Endereco
{
    private string _rua;
    private string _cidade;
    private string _estado;
    private string _pais;
    
    public Endereco(string rua, string cidade, string estado, string pais)
    {
        _rua = rua;
        _cidade = cidade;
        _estado = estado;
        _pais = pais;
    }

    public bool NosEua()
    {
        return _pais.ToUpper() == "EUA" || _pais.ToUpper() == "USA";
    }

    public string ObterEnderecoCompleto()
    {
        return $"Rua: {_rua}\nCidade: {_cidade}\nEstado: {_estado}\nPaís: {_pais}";
    }
}

