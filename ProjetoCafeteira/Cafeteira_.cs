namespace ProjetoCafeteira;

public partial class Cafeteira
{
    public void DescricaoCafeteira()
    {
        Console.Clear();
    
        Console.WriteLine("# Dados da Cafeira #");
        Console.WriteLine("===========================");
        Console.WriteLine($"Modelo: {modelo_Cafeteira}");
        Console.WriteLine($"Cor: {cor_Cafeteira}");
        Console.WriteLine($"Litro: {litro_Cafeteira}");
        Console.WriteLine($"Base Elétrica: {base_Eletrica}");

        Console.ReadKey();
        
        PrepararCha.Preparando_Meu_Cha();
    }   
}
