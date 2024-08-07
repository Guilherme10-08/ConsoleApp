using System.Text;
using System.Collections.Generic;
using System.IO;

namespace TribunalVirtual;

public partial class Lesado:IDisposable
{
     public double Preco { get; private set; }

    public void Menu()
    {
        Console.Clear();
        // Console.BackgroundColor = ConsoleColor.DarkYellow;
        // Console.ForegroundColor = ConsoleColor.Black;
        try{
        Console.WriteLine("Lesado!".ToUpper());
        Console.WriteLine("=====================");
        Console.WriteLine("Iniciar o Julgamento:".ToUpper());
        Console.WriteLine("");
        Console.WriteLine("[1] Iniciar");
        Console.WriteLine("[2] Opcões Adicionais");
        Console.WriteLine("[0] Sair");
        Console.WriteLine("---------------------");
        Console.Write("Opção:");
        var opcao = Convert.ToInt16(Console.ReadLine());

       switch(opcao)
       {
        case 1:Punir(); break;
        case 0:System.Environment.Exit(0); break;
        case 2:OpcoesAdicionais(); break;
        default:Menu(); break;
       }
        }
        catch(Exception erro)
        {
            Console.WriteLine("Escolha uma opção válida!\n{0}",erro.Message);
            Console.ReadKey();
            Menu();
        }
       
    }

    public void Punir()
    {
        Console.Clear();
        try{
        Console.Clear();
        Console.WriteLine("Gravidade do caso");
        Console.WriteLine("=================");
        Console.WriteLine("1-Leve");
        Console.WriteLine("2-Médio");
        Console.WriteLine("3-Crítico");
        Console.WriteLine("");
        Console.WriteLine("[0] Voltar");
        Console.WriteLine("-----------------");
        Console.Write("Opção:");
        var gravidade = Convert.ToInt16(Console.ReadLine());
        
       
        switch(gravidade)
        {
            case 0:Menu(); break;
            case 1:
            {
                Console.Clear();
                Console.WriteLine("Valor da multa:{0:c}",Preco=50.000);
                Console.ReadKey();
                Continuar();
                //DadosDoAcusado();
                //Conselho();
                //Menu();
                break;
            }
            case 2:
            {
                Console.Clear();
                Console.WriteLine("Valor da multa:{0:c}",Preco=70.000);
                Console.ReadKey();
                Continuar();
                //DadosDoAcusado();
                //Conselho();
                //Menu(); 
                break;
            }
            case 3:
            {
                Console.Clear();
                Console.WriteLine("Valor da multa:{0:c}",Preco=100.000);
                Console.ReadKey();
                Continuar();
                //DadosDoAcusado();
                //Conselho();
                //Menu(); 
                break;
            }
            
            default:Punir(); break;
        }
        
        }
         catch(Exception erro)
        {
            Console.WriteLine("Escolha uma opção válida!\n{0}",erro.Message);
            Console.ReadKey();
            Punir();
        }

    }

     public void DadosDoAcusado()
    {
        Console.Clear();

        try{
        Console.WriteLine("Dados do Acusado");
        Console.WriteLine("----------------");
        Console.ReadKey();
        //Continuar();
        Console.WriteLine("Nome:");
        var nome = Console.ReadLine();
        Console.Clear();
        
        Console.WriteLine("Data de nascimento");
        var data = Console.ReadLine();
        Console.Clear();
        

        Console.WriteLine("Número do Bilhete de Identidade");
        var numeroBI = Console.ReadLine();

         if(nome == "" || data =="" || numeroBI=="" )
        {
            Thread.Sleep(2500);
            Console.Clear();
            Console.WriteLine("Dados InváLidos!");
            Console.ReadKey();
            DadosDoAcusado();
           
        }
        
        Console.Clear();

        DateTime dta = DateTime.Now;
        Console.WriteLine(dta);
        Console.WriteLine("-----------------------------");
        Console.WriteLine("Nome do Acusado....: {0}",nome);
        Console.WriteLine("Data de Nascimento.: {0}",data);
        Console.WriteLine("Número do BI.......: {0}",numeroBI);
        Console.WriteLine("Valor da Multa.....: {0:c}",Preco);
        Console.ReadKey();
        
       
        

        Console.WriteLine("======================");
        Console.WriteLine("[1] Guardar Dados");
        Console.WriteLine("");
        Console.WriteLine("[0] Cancelar o Julgamento");
        Console.WriteLine("");
        Console.Write("Opção:");
        var opcao = Convert.ToInt16(Console.ReadLine());

         switch(opcao)
         {
            case 1:Guardar(dta,nome,data,numeroBI,Preco);break;
            case 0:Menu(); break;
            default:DadosDoAcusado();break;     
         }

       // Guardar(dta,nome,data,numeroBI,Preco);
    
        }
        catch(Exception erro)
        {
            Console.WriteLine("ERRO:{0}",erro.Message);
        }       
    }

    public void Guardar(DateTime dia, string? nome, string? data, string? bi, double vm)
    {
        Console.Clear();
        try{
        Console.WriteLine("Caminho para guardar os dados do acusado: ");
        var caminho = Console.ReadLine();
        

        using (StreamWriter dados = new StreamWriter(caminho))
        {
        
         dados.Write("Dia:{0}\n\n",dia);
         dados.Write("Nome:{0}\nData de Nascimento:{1}\nNúmero do BI:{2}\nValor da Multa:{3:c}"
         ,nome,data,bi,vm);
        }
        Console.WriteLine("Dados guardados");
        Console.ReadKey();
        Conselho();
        }
        catch(Exception erro)
        {
            Console.WriteLine("ERRO:{0}",erro.Message);
            Console.ReadKey();
            Guardar(dia,nome,data,bi,Preco);
        }
    }
    
    public void Continuar()
    {
       
         try{
         Console.WriteLine("");
         Console.WriteLine("[1] Continuar");
         Console.WriteLine("");
         Console.WriteLine("[0] Voltar");
         Console.WriteLine("");
         Console.Write("Opção:");
         var opcao = Convert.ToInt16(Console.ReadLine());

         switch(opcao)
         {
            case 1: DadosDoAcusado();break;
            case 0:Punir(); break;
            default:Continuar(); break;
         }

         }
         catch(Exception erro)
         {
            Console.WriteLine("Opção inválida!\n{0}",erro.Message);
            Console.ReadKey();
            Continuar();
         }
                
    }

    
}

public class Dados
{
    public void Menu()
    {
        Console.Clear();
        try{
        var txt ="";
        Console.WriteLine();
        Console.WriteLine("1-Digitar novo Arquivo");
        Console.WriteLine("2-Salvar");
        Console.WriteLine("3-Abrir");
        Console.WriteLine("0-Sair");
        Console.WriteLine();
        Console.Write("Opção:");
        var opcao = Convert.ToInt16(Console.ReadLine());

        switch(opcao)
        {
            case 1: Escrever(); break;
            case 2: Guardar(txt); break;
            case 3: Abrir(); break;
            case 0: System.Environment.Exit(0); break;
        }
        }
        catch(Exception erro)
        {
            Console.WriteLine("ERRO:{0}",erro);
            Console.ReadKey();
            Menu();
        }
    }
    public void Escrever()
    {
        Console.Clear();
        try{
        Console.WriteLine("Digite");

        string txt = "";

        do
        {
            txt += Console.ReadLine();
            txt += Environment.NewLine;
        }
        while(Console.ReadKey().Key != ConsoleKey.Escape);

        Guardar(txt);
        }
        catch(Exception erro)
        {
            Console.WriteLine("ERRO:{0}",erro);
            Console.ReadKey();
            Escrever();
        }
    }

    public void Guardar(string txt)
    {
        Console.Clear();
        try{
        Console.WriteLine("Caminho para salvar o arquivo");
        var caminho = Console.ReadLine();

        using (var arquivo = new StreamWriter(caminho))
        {
            arquivo.Write(txt);
        }
        Console.WriteLine("Arquivo salvo com sucesso! \nCaminho:{0}",caminho);
        Console.ReadKey();
        Abrir();
        }
        catch(Exception erro)
        {
            Console.WriteLine("ERRO:{0}",erro);
            Console.ReadKey();
            Guardar(txt);
        }
    }

    public void Abrir()
    {
        Console.Clear();
        try{
        Console.WriteLine("Caminho para Abrir o arquivo");
        var caminho = Console.ReadLine();

        using(StreamReader arquivo = new StreamReader(caminho))
        {
            string txt = arquivo.ReadToEnd();
            Console.Clear();
            Console.WriteLine(txt);
            Console.ReadKey();

        }
        }
        catch(Exception erro)
        {
            Console.WriteLine("ERRO:{0}",erro);
            Console.ReadKey();
            Abrir();
        }

    }
}

