namespace TribunalVirtual;

public partial class Lesado
{
     public void OpcoesAdicionais()
    {
       
       Console.Clear();
       try{
       List<string> opcoes = new List<string>();
        
        opcoes.Add("1-Pesquisar");
        opcoes.Add("2-Histórico de Julgados");
        opcoes.Add("3-Configurações");
        opcoes.Add("4-Temas");
        opcoes.Add("5-Acerca do Aplicativo");
        opcoes.Add("6-Ajuda");
        opcoes.Add("");
        opcoes.Add("[0] Voltar");
        opcoes.Add("-----------------");
        
        Console.WriteLine("Opções Adicionais");
        Console.WriteLine("=================");
        foreach(string op in opcoes )
        {
            Console.WriteLine(op);
        }

        Console.WriteLine();
        
        Console.Write("Opção:");
        var escolha = Convert.ToInt16(Console.ReadLine());
       

        switch(escolha)
        {
            case 0:Menu(); break;
            case 1:
            {
                 Console.Clear(); 
                 Console.WriteLine("Pesquisando!");
                 Console.ReadKey(); OpcoesAdicionais(); break;
            }
            case 2: Historico(); break; 
            case 3: 
            {
                Console.Clear(); Console.WriteLine("Configurando!"); 
                Console.ReadKey(); OpcoesAdicionais(); break;
            }
            case 4: Temas(); break;
            case 5: 
            {
                Console.Clear(); 
                Console.WriteLine("Rápido e Eficiente!");
                Console.ReadKey(); OpcoesAdicionais(); break;
            }
            case 6:
            {
                Console.Clear(); 
                Console.WriteLine("Ajuda Disponível!");
                Console.ReadKey(); OpcoesAdicionais(); break;
            }
            default:OpcoesAdicionais(); break;
        }
        
        Console.ReadKey();
        Menu();

       }
       catch(Exception erro)
       {
        Console.WriteLine("ERRO:{0}",erro.Message);
        Console.ReadKey();
        OpcoesAdicionais();
       }
    }

     public void Temas()
    {
        Console.Clear();
        
        try{
        List<string> temas = new List<string>();
        temas.Add("1-Azul escuro");
        temas.Add("2-Verde escuro");
        temas.Add("3-Preto");
        temas.Add("");
        temas.Add("[0] Voltar");
      
        Console.WriteLine("Temas");
        Console.WriteLine("----------------");
        foreach(string t in temas)
        {
            Console.WriteLine(t);
        }

        Console.WriteLine();

        Console.Write("Opção:");
        var opcao = Convert.ToInt16(Console.ReadLine());
        switch(opcao)
        {
            case 1:
            {
                Console.BackgroundColor = ConsoleColor.DarkBlue; 
                Console.ForegroundColor = ConsoleColor.Black;
                
                break;
            }
            case 2: Console.BackgroundColor = ConsoleColor.DarkGreen; break;
            case 3: Console.BackgroundColor = ConsoleColor.Black; break;
            case 0: OpcoesAdicionais(); break;
            default: Temas(); break;
        }
        
        Console.ReadKey();
        OpcoesAdicionais();

        }
        catch(Exception erro)
        {
            Console.WriteLine("ERRO:{0}",erro.Message);
            Console.ReadKey();
            Temas();
        } 
    }

     public void Historico()
    {
        Console.Clear();
        try{
        List<string> casos = new List<string>();

        Console.WriteLine("Histórico de Julgados");
        Console.WriteLine("---------------------");
        casos.Add("[1] Reabrir Casos");
        casos.Add("CASO 2");
        casos.Add("CASO 3");
        casos.Add("CASO 4");
        casos.Add("");
        casos.Add("[0] Voltar");
        casos.Remove("CASO 2");
        casos.Remove("CASO 3");
        casos.Remove("CASO 4");
        foreach(string c in casos)
        {
            Console.WriteLine(c);
        }
        Console.WriteLine("");
        Console.Write("Opção:");
        var opcao = Convert.ToInt16(Console.ReadLine());

        switch(opcao)
        {
            case 1: Abrir(); break;
            case 0: OpcoesAdicionais(); break;
            default: Historico(); break;

        }

        }
        catch(Exception erro)
        {
            Console.WriteLine("Opção inválida!\n{0}",erro.Message);
            Console.ReadKey();
            Historico();
        }

    }

}
