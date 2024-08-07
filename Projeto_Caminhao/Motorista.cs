namespace Projeto_Caminhao;

public class Motorista
{
    public static string Nome_motorista{get; set;} = String.Empty;
    public static string? Nacionalidade_motorista {get; set;}
    public static DateTime Data_nascimento_motorista {get; set;} = new DateTime(2002,10, 08);
    public static int Telefone_motoriste {get; set;}
    public static string? Numero_carteira_motorista {get; set;}

    public Motorista()
    {
        Nome_motorista ="Gilherme Sebastião";
        Nacionalidade_motorista = "Angolana";
        Data_nascimento_motorista = Data_nascimento_motorista;
        Telefone_motoriste = 945562444;
        Numero_carteira_motorista = Guid.NewGuid().ToString().Substring(0,10); 
    }

    public static void Iniciar()
    {
        Console.Clear();
        Console.WriteLine("Dados do Motorista");
        Console.WriteLine("============================");
        Console.WriteLine("Nome Motorista: {0}",Nome_motorista ="Gilherme Sebastião");
        Console.WriteLine("Nacionalidade: {0}", Nacionalidade_motorista = "Angolana");

        Console.WriteLine("Data Nascimento: {0}", Data_nascimento_motorista.ToShortDateString());
        
        Console.WriteLine("Telefone: {0}",Telefone_motoriste = 945562444);
        Console.WriteLine("Número Carteita: {0}", Numero_carteira_motorista = Guid.NewGuid().ToString().Substring(0,10));

        Console.ReadKey();
        Dirigir();
    
    }
    public static void Dirigir()
    {
        Console.Clear();
        try
        {
             Console.WriteLine("Dirigir...[1]Sim || [0]Cancelar");
             short escolha = Convert.ToInt16(Console.ReadLine());

            switch(escolha)
            {
                case 1:
                {
                    Console.Clear();Console.WriteLine("Dirigindo!");Console.ReadKey();
                    Rota.Primeira_rota();
                    Rota.Segunda_Rota();
                    break;
                }
                case 0: Caminhao.Iniciar();break;

                default:Dirigir();break;
            }
        }
        catch
        {
            Console.WriteLine("Digite apenas números inteiros!");
            Dirigir();
        }
    }
}
