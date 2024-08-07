namespace Projeto_Caminhao;

public class Rota
{
    public static void Primeira_rota()
    {
        Console.Clear();
        Console.WriteLine("Rota: 01");
        Console.WriteLine("============================");
        Console.WriteLine("Pegar a estrada principal que vai em direção a Avenida Paulista");
        Console.ReadKey();
    }
    public static void Segunda_Rota()
    {
        Console.Clear();
        Console.WriteLine("Rota: 02");
        Console.WriteLine("============================");
        Console.WriteLine("Ao chegar a Avenida Paulista");
        Console.WriteLine("Pegar a rua 10/Rua dos Libertadores");
        Console.WriteLine("Seguir em frente com o asfalto, até o final da rua");
        Console.WriteLine("Parar em frente ao Super Mercado : MultiVariedade");
        Console.ReadKey();
        Descarregamento.DescarregarEncomenda();
    }
}
