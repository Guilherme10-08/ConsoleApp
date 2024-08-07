namespace Projeto_Calculadora;

public class Menu_Calculadora
{
    private readonly ICalculadora calculadora;
    
    public Menu_Calculadora(ICalculadora calculadora)
    {
        this.calculadora = calculadora;
    }
    public static void Menu()
    {
        try
        {
            Console.Clear();
            Console.WriteLine("===========================");
            Console.WriteLine("---------------------------");
            Console.WriteLine("1-Soma");
            Console.WriteLine("2-Subtrção");
            Console.WriteLine("3-Multiplicação");
            Console.WriteLine("4-Divisão");
            Console.WriteLine("0-Sair");
            Console.WriteLine("===========================");
            Console.Write("Escolha:");
            Propriedade.Escolha = Convert.ToInt16(Console.ReadLine());
        }
        catch
        {
            Console.WriteLine("Digite Apenas valores numéricos!");
        }

        switch(Propriedade.Escolha)
        {
            case 1:{Calculadora.Soma();Menu(); break;}
            case 2:{Calculadora.Subtracao(); Menu(); break;}
            case 3:{Calculadora.Multiplicacao(); Menu(); break;}
            case 4:{Calculadora.Divisao(); Menu(); break;}
            case 0:{System.Environment.Exit(0); break;}
            default:{Menu(); break;}
        
        }
        
    }
}
