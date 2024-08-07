namespace ProjetoCafeteira;

public partial class Cafeteira
{
    public string modelo_Cafeteira {get; set;} = string.Empty;
    public string cor_Cafeteira {get; set;} = string.Empty;
    public int litro_Cafeteira {get; set;}
    public bool base_Eletrica {get; set;}

    public Cafeteira()
    {
        modelo_Cafeteira = "Elétrico";
        cor_Cafeteira = "Cinzento";
        litro_Cafeteira = 2;
        base_Eletrica = true;
    }

}
