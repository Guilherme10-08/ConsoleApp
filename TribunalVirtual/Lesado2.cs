using System.Text;

namespace TribunalVirtual;

public partial class Lesado
{
     public void Conselho()
    {
        Console.Clear();
        var conselho = new StringBuilder();
        try{

        conselho.Append("Caro cidadão injusto evitar transbordar dentro da nossa ");
        conselho.Append("Rica e valiosa sociedade atitudes reprováveis   que só causam");
        conselho.Append(" Desordem. Refletir sobre os teus comportamentos e enchergar ");
        conselho.Append("maneiras de melhorar a sua postura e com isso passar ");
        conselho.Append("a respeitar o espaço social de cada cidadão.");  

        Console.WriteLine("Conselho:".ToUpper());
        Console.WriteLine("");
        Console.WriteLine(conselho);
        Console.ReadKey();
        Console.Clear();
        Dispose();
       
        
        }
         catch(Exception erro)
        {
            Console.WriteLine("ERRO:{0}",erro.Message);
            Console.ReadKey();
            Conselho();
        }
    }
     public void Abrir()
    {
        Console.Clear();
        try{
        
        Console.WriteLine("=================");
        Console.WriteLine("[1] Continuar");
        Console.WriteLine("");
        Console.WriteLine("[0] Voltar");
        Console.WriteLine("");
        Console.Write("Opção:");
        var opcao = Convert.ToInt16(Console.ReadLine());

        switch(opcao)
        {
            case 1:
            {
        Console.Clear();
        Console.WriteLine("Caminho para abrir casos guardados");
        var caminho = Console.ReadLine();
        Console.WriteLine();

        using (var guardado = new StreamReader(caminho))
        {
            string arquivo = guardado.ReadToEnd();
            Console.WriteLine(arquivo);
            Console.ReadKey();
            OpcoesAdicionais(); break; 
        }
            }
            case 0: OpcoesAdicionais(); break;
            default: Abrir(); break;
        }
        
       
        }
        catch(Exception erro)
        {
            Console.WriteLine("Caminho inválido!\n{0}",erro.Message);
            Console.ReadKey();
            OpcoesAdicionais();
        }
    }
    public void Dispose()
    {
       Console.WriteLine("Caso Encerrado!".ToUpper());
       Console.ReadKey();
       Menu();
    }
}

