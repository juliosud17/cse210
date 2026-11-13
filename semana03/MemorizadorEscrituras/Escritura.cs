public class Escritura
{
    private Referencia _referencia;
    private List<Palavra> _palavras = new List<Palavra>();

    public Escritura(Referencia referencia, string texto)
    {
        _referencia = referencia;
        string[] partes = texto.Split(' ');

        foreach (string parte in partes)
        {
            Palavra palavra = new Palavra(parte);
            _palavras.Add(palavra);
        }
    }
    
    public string ObterTexto()
    {
        string resultado = _referencia.ObterTexto() + " ";
        foreach ( Palavra palavra in _palavras)
        {
            resultado = resultado + palavra.ObterTexto() + " ";
        }
        return resultado;
    }
    
    public bool EstaCompletamenteOculta()
    {
        foreach (Palavra palavra in _palavras)
        {
            if (palavra.EstaOculta() == false)
            {
                return false;
            }
        }
        return true;
    }
    
    public void OcultarPalavrasAleatorias(int numeroParaOcultar)
    {
        Random aleatorio = new Random();

        for (int i = 0; i < numeroParaOcultar; i++)
        {
            // Criar uma lista apenas com palavras visíveis
            List<Palavra> visiveis = new List<Palavra>();

            foreach (Palavra palavra in _palavras)
            {
                if (palavra.EstaOculta() == false)
                {
                    visiveis.Add(palavra);
                }
            }

            // Encerrar se todas as palavras estiverem ocultas
            if (visiveis.Count == 0)
            {
                return;
            }

            // Sortear apenas entre as palavras visíveis
            int indice = aleatorio.Next(visiveis.Count);

            // Ocultar a palavra sorteada
            visiveis[indice].Ocultar();
        }
    }

}