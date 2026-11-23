using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Aprendendo C#", "Julio", 600);

        Comentario comentario1 = new Comentario("Pablo", "Parabéns pelo video, aprendi muito hoje.");
        Comentario comentario2 = new Comentario("Marina", "A parte de classes ficou muito mais clara agora.");
        Comentario comentario3 = new Comentario("Diego", "Poderia fazer um vídeo sobre listas?");
        Comentario comentario4 = new Comentario("Ana", "Didática excelente, já me inscrevi.");

        Video video2 = new Video("Receita de pão caseiro fácil", "Cozinha da Lu", 845);

        Comentario comentario5 = new Comentario("Roberto", "Fiz hoje e ficou ótimo!");
        Comentario comentario6 = new Comentario("Camila", "Posso usar fermento seco no lugar do fresco?");
        Comentario comentario7 = new Comentario("Sérgio", "Minha massa não cresceu, o que pode ter sido?");

        Video video3 = new Video("Trilha no Pico da Bandeira", "Aventuras do Leo", 1230);

        Comentario comentario8 = new Comentario("Fernanda", "Que vista incrível!");
        Comentario comentario9 = new Comentario("Tiago", "Qual é a melhor época do ano para ir?");
        Comentario comentario10 = new Comentario("Juliana", "Fui no ano passado, vale cada passo.");
        Comentario comentario11 = new Comentario("Carlos", "Quanto tempo leva a subida?");

        Video video4 = new Video("Como organizar suas finanças", "Dinheiro Simples", 720);

        Comentario comentario12 = new Comentario("Paula", "Comecei a anotar meus gastos depois desse vídeo.");
        Comentario comentario13 = new Comentario("Marcos", "Faltou falar sobre reserva de emergência.");
        Comentario comentario14 = new Comentario("Bianca", "Conteúdo muito útil, obrigada!");
    
        video1.AdicionarComentario(comentario1);
        video1.AdicionarComentario(comentario2);
        video1.AdicionarComentario(comentario3);
        video1.AdicionarComentario(comentario4);

        video2.AdicionarComentario(comentario5);
        video2.AdicionarComentario(comentario6);
        video2.AdicionarComentario(comentario7);

        video3.AdicionarComentario(comentario8);
        video3.AdicionarComentario(comentario9);
        video3.AdicionarComentario(comentario10);
        video3.AdicionarComentario(comentario11);

        video4.AdicionarComentario(comentario12);
        video4.AdicionarComentario(comentario13);
        video4.AdicionarComentario(comentario14);

        List<Video> videos = new List<Video>();
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        videos.Add(video4);

        foreach (Video video in videos)
        {
            video.ExibirVideo();
            Console.WriteLine("--------------------------------");
            Console.WriteLine();
        }       
    }
}