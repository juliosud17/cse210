// Criatividade / além dos requisitos:
// Melhorei o sorteio das palavras para que apenas as que ainda
// estão visíveis possam ser escolhidas. Para isso, criei uma
// lista temporária com as palavras não ocultas.
// Assim, cada vez que o usuário pressiona Enter, novas palavras
// são escondidas, evitando repetir palavras já ocultas.
// Isso torna o programa mais eficiente para memorizar escrituras.

using System;

class Program
{
    static void Main(string[] args)
    {
        Referencia referencia = new Referencia("Provérbios", 3, 5, 6);

        string texto = "Confia no Senhor de todo o teu coração e não te estribes no teu próprio entendimento. Reconhece-o em todos os teus caminhos, e ele endireitará as tuas veredas.";
        
        Escritura escritura = new Escritura(referencia, texto);

        while (true)
        {
            Console.Clear();

            Console.WriteLine(escritura.ObterTexto());
            Console.WriteLine();

            if (escritura.EstaCompletamenteOculta())
            {
                break;
            }

            Console.WriteLine("Pressione Enter para continuar ou digite 'sair' para terminar:");
            string resposta = Console.ReadLine() ?? "";

            if (resposta.ToLower() == "sair")
            {
                break;
            }

            escritura.OcultarPalavrasAleatorias(3);
        }

    }
}