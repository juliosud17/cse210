using System;

class Program
{
    static void Main(string[] args)
    {
        Endereco endereco1 = new Endereco("E Roosevelt Ave","Salt Lake","Utah","EUA");
        Endereco endereco2 = new Endereco("Almeida Junior","Praia grande","São Paulo","Brasil");

        Cliente cliente1 = new Cliente("Julio", endereco1);
        Cliente cliente2 = new Cliente("Paloma", endereco2);

        Produto produto1 = new Produto("Caneta","A789s", 7.99, 10);
        Produto produto2 = new Produto("Caderno","A542s", 17.99, 3);
        Produto produto3 = new Produto("Bolsa","X548b", 68.80, 2);
        Produto produto4 = new Produto("Pingente","X594b", 3.99, 15);

        Pedido pedido = new Pedido(cliente1);
        Pedido pedido2 = new Pedido(cliente2);     
        pedido.AdicionarProduto(produto1);
        pedido.AdicionarProduto(produto2);

        pedido2.AdicionarProduto(produto3);
        pedido2.AdicionarProduto(produto4);

        Console.WriteLine($"{pedido.ObterEtiquetaEmbalagem()}\n{pedido.ObterEtiquetaEnvio()}");
        Console.WriteLine($"Total do pedido: ${pedido.ObterCustoTotal():F2}");
        Console.WriteLine("--------------------------------");
        Console.WriteLine($"{pedido2.ObterEtiquetaEmbalagem()}\n{pedido2.ObterEtiquetaEnvio()}");
        Console.WriteLine($"Total do pedido: ${pedido2.ObterCustoTotal():F2}");

    }
}