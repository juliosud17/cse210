using System;

class Program
{
    static void Main(string[] args)
    {
        Diario diario = new Diario();

        GeradorDePerguntas gerador = new GeradorDePerguntas();          

        int escolha =0;

        while (escolha != 5)
        {
            Console.WriteLine("Por favor, escolha uma das seguintes opções:");
            Console.WriteLine("1. Escrever");
            Console.WriteLine("2. Exibir");
            Console.WriteLine("3. Carregar");
            Console.WriteLine("4. Salvar");
            Console.WriteLine("5. Sair");
            Console.Write("O que você gostaria de fazer? ");

            string resposta = Console.ReadLine();
            escolha = int.Parse(resposta);

            if (escolha == 1)
            {
                string pergunta  = gerador.ObterPerguntaAleatoria();
                Console.WriteLine($"{pergunta}");  
                Console.Write("> ");

                string textoResposta = Console.ReadLine();

                DateTime agora = DateTime.Now;
                string dataTexto = agora.ToShortDateString();

                Registro novoRegistro = new Registro();
                novoRegistro._data = dataTexto;
                novoRegistro._textoPergunta = pergunta;
                novoRegistro._textoResposta = textoResposta;

                diario.AdicionarRegistro(novoRegistro);
            }
            else if (escolha ==2)
            {
               diario.ExibirTodos();
            }
            else if (escolha ==3)
            {
                Console.Write("Qual o nome do arquivo? ");
                string nomeArquivo = Console.ReadLine();
                diario.CarregarDoArquivo(nomeArquivo);

            }
            else if (escolha ==4)
            {
               
                Console.Write("Nome do arquivo: ");
                string nomeArquivo = Console.ReadLine();
                diario.SalvarNoArquivo(nomeArquivo);
            }
            else if (escolha ==5)
            {
                Console.WriteLine("Até logo!");
            }

        }
    }
}
