
namespace Projeto_Calculadora;

public class Calculadora
{
    public static void Soma()
    {
                 
        Console.Clear();       
        Console.WriteLine("Primeiro valor:");
        Propriedade.Valor_1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Segundo valor:");
        Propriedade.Valor_2 = Convert.ToInt32(Console.ReadLine());

        try
        {  
            Propriedade.Resultado = Propriedade.Valor_1 + Propriedade.Valor_2;

            Console.WriteLine("Resultado: {0}",Propriedade.Resultado);

            Console.ReadKey();
            Menu_Calculadora.Menu();
        }
        catch
        {
            Console.WriteLine("Digite apenas valores numéricos!");
            Console.ReadKey();
            Soma();
        }
        
    }
     public static void Subtracao()
    {
        
        Console.Clear();
        Console.WriteLine("Primeiro valor:");
        Propriedade.Valor_1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Segundo valor:");
        Propriedade.Valor_2 = Convert.ToInt32(Console.ReadLine());
        
        try
        {
            Propriedade.Resultado = Propriedade.Valor_1 - Propriedade.Valor_2;

            Console.WriteLine("Resultado: {0}",Propriedade.Resultado);
            Console.ReadKey();
            Menu_Calculadora.Menu();
        }
        catch
        {
            Console.WriteLine("Digite apenas valores numéricos!");
            Console.ReadKey();
            Subtracao();
        }
        
    }
    public static void Multiplicacao()
    {
        
        Console.Clear();
        Console.WriteLine("Primeiro valor:");
        Propriedade.Valor_1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Segundo valor:");
        Propriedade.Valor_2 = Convert.ToInt32(Console.ReadLine());

        try
        {
            Propriedade.Resultado = Propriedade.Valor_1 * Propriedade.Valor_2;

            Console.WriteLine("Resultado: {0}",Propriedade.Resultado);
            Console.ReadKey();
            Menu_Calculadora.Menu();
        }
        catch
        {
            Console.WriteLine("Digite apenas valores numéricos!");
            Console.ReadKey();
            Multiplicacao();
        }
        
    }
    public static void Divisao()
    {
       
        Console.Clear();
        Console.WriteLine("Primeiro valor:");
        Propriedade.Valor_1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Segundo valor:");
        Propriedade.Valor_2 = Convert.ToInt32(Console.ReadLine());

        try
        {
            Propriedade.Resultado = Math.Round(Propriedade.Valor_1 / Propriedade.Valor_2,3);
            
            double resto = Propriedade.Valor_1 % Propriedade.Valor_2;

            Console.WriteLine("Resultado: {0}",Propriedade.Resultado);
            Console.WriteLine("Resto: {0}",resto);
            Console.ReadKey();
            Menu_Calculadora.Menu();
        }
        catch
        {
            Console.WriteLine("Digite apenas valores numéricos!");
            Console.ReadKey();
            Divisao();           
        }
        
    }
}