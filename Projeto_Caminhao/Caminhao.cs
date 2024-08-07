namespace Projeto_Caminhao;

public class Caminhao
{
    public static string? Marca {get; set;}
    public static string? Modelo {get; set;}
    public static string? Porte {get; set;}
    public static string? Cor {get; set;}
    public static string Numero_matricula{get; set;} = String.Empty;
    public static string Numero_licenca {get; set;} =String.Empty;
    public static int Numero_pneus {get; set;}

    public Caminhao()
    {
        Marca = "Cat";
        Modelo = "Turbo";
        Porte = "Grande";
        Cor = "Azul";
        Numero_matricula = "LD-10-08-BR";
        Numero_licenca = Guid.NewGuid().ToString().Substring(0,10);
        Numero_pneus = 20;
    }

    public static void Iniciar()
    {
        Console.Clear();
        Console.WriteLine("Dados do Caminhão");
        Console.WriteLine("============================");
        Console.WriteLine("Marca: {0}",Marca = "Cat");
        Console.WriteLine("Modelo: {0}", Modelo = "Turbo");
        Console.WriteLine("Porte: {0}",Porte = "Grande");
        Console.WriteLine("Cor: {0}", Cor = "Azul");
        Console.WriteLine("Número Matrícula: {0}",  Numero_matricula = "LD-10-08-BR");
        Console.WriteLine("Número Licença: {0}", Numero_licenca = Guid.NewGuid().ToString().Substring(0,10));
        Console.WriteLine("Número Pneus: {0}", Numero_pneus = 20);
        
        Console.ReadKey();
        LigarCaminhao();
    }

    public static void LigarCaminhao()
    {
        Console.Clear();
        try
        {
            Console.WriteLine("Ligar o Caminhão [1]Sim [0]Cancelar");
            short escolha = Convert.ToInt16(Console.ReadLine());

            switch(escolha)
            {

                case 1:
                {
                    Console.Clear();
                    Console.WriteLine("Ligado/On");
                    Console.ReadKey();
                    Motorista.Iniciar();break;
                } 
                    case 0:System.Environment.Exit(0); break;
                    default :LigarCaminhao(); break;

            }
        }
        catch
        {
            Console.WriteLine("Digite apenas números inteiros!");
            LigarCaminhao();
        }
       
    }

    //APENAS UM TESTE
    public static void Vender()
    {
        Console.Clear();

        try
        {
            Console.WriteLine("Valor pago");
            double valor_pago = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Valor do produto");
            double valor_produto = Convert.ToDouble(Console.ReadLine());

            if(valor_pago < valor_produto)
            {
                Console.WriteLine("Valor insuficiente para compra!");
                return;
            }
            else
            {
                double Troco = valor_pago - valor_produto;
                Console.WriteLine("Sucesso!");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("Troco: {0:#.000}",Troco); 
            }

        }
        catch
        {
            Console.WriteLine("Digite apenas valores numéricos");
        }
        
    }
}
