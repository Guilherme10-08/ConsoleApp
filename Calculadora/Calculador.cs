

namespace Calculadora.cs;

public class Calculador:IDisposable
{
    public void Dispose()
    {
       Console.WriteLine("Fim do Programa!");
    }

    public void Menu()
    {
        Console.Clear();

        Console.WriteLine("Bem vindo a Stalo Calculadora");
         Console.WriteLine("============================");
        Console.WriteLine("1-Soma");
        Console.WriteLine("2-Subtração");
        Console.WriteLine("3-Multiplicação");
        Console.WriteLine("4-Divisão");
        Console.WriteLine("0-Sair");
        Console.WriteLine("----------------------------");
        Console.WriteLine("=============================");
        Console.Write("Escolha uma operação");
        short Escolha = Convert.ToInt16(Console.ReadLine());

        switch(Escolha)
        {
            case 0: System.Environment.Exit(0); break;
            case 1: Soma(); break;
            case 2: Subtracao(); break;
            case 3: Multiplicar(); break;
            case 4: Dividir(); break;
            default: Menu(); break;
        }




    }


    public void Soma()
    {
        try
        {
            Console.Clear();

            int num1 = 0;
            int num2 = 0;
            int res = 0;

             Console.WriteLine("Digite o prieiro valor");
             num1 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor");
            num2 = Convert.ToInt16(Console.ReadLine());

            res = num1 + num2;

            Console.WriteLine("Resultado:{0}",res);
            Console.ReadKey();
            Menu();
        }
        catch
        {
            Console.WriteLine("Digite apenas valores numéricos");
            Console.ReadKey();
            Menu();
        }
       
    }

    public void Subtracao()
    {
        try
        {
            Console.Clear();

             int num1 , num2 , res = 0;

             Console.WriteLine("Digite o primeiro valor");
             num1 = Convert.ToInt16(Console.ReadLine());

             Console.WriteLine("Digite o segundo valor");
             num2 = Convert.ToInt16(Console.ReadLine());

             res = num1 - num2;

             Console.WriteLine("Resultado:{0}",res);  
             Console.ReadKey();
             Menu(); 
        }
        catch
        {
             Console.WriteLine("Digite apenas valores numéricos");
            Console.ReadKey();
            Menu();
        }
             
    }

    public void Multiplicar()
    {
        try
        {
            Console.Clear();

            int num1 , num2 , res = 0;

            Console.WriteLine("Digite o primeiro valor");
            num1 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor");
            num2 = Convert.ToInt16(Console.ReadLine());

            res = num1 * num2;

            Console.WriteLine("Resultado:{0}",res);
            Console.ReadKey();
            Menu(); 
        }
        catch
        {
             Console.WriteLine("Digite apenas valores numéricos");
            Console.ReadKey();
            Menu();
        }
       
    }

    public void Dividir()
    {
        try
        {
            Console.Clear();

             int num1 , num2 , res = 0;

            Console.WriteLine("Digite o primeiro valor");
            num1 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor");
            num2 = Convert.ToInt16(Console.ReadLine());

            res = num1 / num2;

            Console.WriteLine("Resultado:{0}",res);
            Console.ReadKey();
            Menu(); 
        }
        catch
        {
             Console.WriteLine("Digite apenas valores numéricos");
            Console.ReadKey();
            Menu();
        }
       
    }
}

