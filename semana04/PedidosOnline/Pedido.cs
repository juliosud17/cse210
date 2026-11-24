using System;

public class Pedido
{
    private Cliente _cliente;
    private List<Produto> _produtos = new List<Produto>();

    public Pedido(Cliente cliente)
    {
        _cliente = cliente;
    }

    public void AdicionarProduto(Produto novoProduto)
    {
        _produtos.Add(novoProduto);
    }

    public string ObterEtiquetaEmbalagem()
    {
        string etiquetaEmbalagem = "Etiqueta de embalagem:\n";

        foreach ( Produto produto in _produtos)
        {
            etiquetaEmbalagem += $"Produto: {produto.ObterNome()} | ID: {produto.ObterId()}\n";
        }
        return etiquetaEmbalagem;
    }

    public string ObterEtiquetaEnvio()
    {
        string etiquetaEnvio = "Etiqueta de Envio:\n";

        string nomeCliente = _cliente.ObterNome();
        string enderecoCompleto = _cliente.ObterEnderecoCompleto();

        etiquetaEnvio += $"Nome do cliente: {nomeCliente}\nEndereço: {enderecoCompleto}";

        return etiquetaEnvio;
    }

    public double ObterFrete()
    {
        if (_cliente.MoraNosEua())
        {
            return 5;
        }
        else
        {
            return 35;
        }
    }

    public double ObterCustoTotal()
    {
        double total = 0;

        foreach (Produto produto in _produtos)
        {
            total += produto.ObterCusto();
        }

        total += ObterFrete();

        return total;
    }
}