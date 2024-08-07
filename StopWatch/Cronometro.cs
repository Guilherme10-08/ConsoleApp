using System.Collections;
using System.Diagnostics;
using System.IO;

namespace StopWatch;

public class Cronometro
{
      int TempoInicial=0;

    public void Menu()
    {
        Console.WriteLine("Bem Vindo ao Stalo Cronómetro");
        Console.WriteLine("");
        Console.WriteLine("1-Minuto(m)");
        Console.WriteLine("Segundo(s)");
        Console.WriteLine("0-Sair");
        Console.WriteLine("");
        Console.WriteLine("Quanto tempo deseja Calcular ");

        string Digitado=Console.ReadLine().ToLower();
        char UnidadeTempo=char.Parse(Digitado.Substring(Digitado.Length-1,1));
        int TempoDigitado = Convert.ToInt32(Digitado.Substring(0,Digitado.Length-1));

        int Contador=1;

        if(UnidadeTempo=='m')
            Contador=60;

        if(TempoDigitado==0)
            System.Environment.Exit(0);

            Inicio(TempoDigitado*Contador);
            Console.ReadKey();
            Console.Clear();
            Sair();



    }
    public void Inicio(int tempo)
    {
       
        Console.Clear();
        Animacao();
       
        while(TempoInicial!=tempo)
        {
            TempoInicial++;
            Console.Clear();
            Console.WriteLine(TempoInicial);
            Thread.Sleep(1000);
        }

    }

    public void Animacao()
    {
        Console.WriteLine(" ## Preparar o Cronómetro ##");
        Thread.Sleep(2500);
        Console.WriteLine(" !! Quase Pronto !!");
        Thread.Sleep(2500);
        Console.WriteLine(" ## Disparar a Contagem ##");
        Thread.Sleep(2500);
    }

    public void Sair()
    {
        Console.WriteLine($"Fim da Contagem! \nTempo:{TempoInicial}");
        Console.WriteLine("Continuar a Contagem?? \n[s]Sim || [n]Não");
        char cont=char.Parse (Console.ReadLine());

        switch(cont)
        {
            case 's': case 'S':Console.Clear(); Menu(); break;
            default: System.Environment.Exit(0); break;
        }
    }
}

public class MaquinaLavar
{
    //public short tempo;
    public short temporizador=1;

    public void Menu()
    {
        

        Console.WriteLine(" ## Bem vindo a Máquina de Lavar ##");
        Console.WriteLine("");
        Console.WriteLine("Iniciar--------------------------1");
        Console.WriteLine("");
        Console.WriteLine("Sair do Programa-----------------0");
        Console.WriteLine("");
        
        Console.WriteLine("Iniciar a Lavagem ");

        short Iniciar=Convert.ToInt16(Console.ReadLine());

        if(Iniciar==1)
        {
            Console.Clear();
            Inicio();
            Console.ReadKey();
            Console.Clear();
            Ligar();
            Console.ReadKey();
            Console.Clear();
            Temporizador();
            Console.ReadKey();
            Console.Clear();
            Verificar();
            Console.ReadLine();
            Console.Clear();
        }
        else if(Iniciar==0)
        {
            System.Environment.Exit(0);
        }
        else
        {
            Menu();
        }


       
        
       // Console.ReadKey();
       // Console.Clear();
       // Inicio();
       // Ligar();
       // Temporizador();
       // Sair();
    }
    public void Inicio()
    {

        Console.WriteLine("Passo 1 :Abrir o tampão da máquina");
        Thread.Sleep(2500);
        Console.WriteLine("");
       
        Console.WriteLine("Passo 2 :Colocar água ao reservatório da máquina");
        Thread.Sleep(2500);
        Console.WriteLine("");
        
        Console.WriteLine("Passo 3: Adicionar detergente a água colocada no reservaório");
        Thread.Sleep(2500);
        Console.WriteLine("");
       
        
        Console.WriteLine("Passo 4: Recolher toda roupa suja a ser lavada");
        Thread.Sleep(2500);
        Console.WriteLine("");
       
        Console.WriteLine("Passo 5: Selecionar as primeiras peças a serem lavadas");
        Thread.Sleep(2500);
        Console.WriteLine("");
       
        Console.WriteLine("Passo 6: Colocar as peças selecionadas no interior da máquina");
        Thread.Sleep(2500);
        Console.WriteLine("");
       

        Console.WriteLine("Passo 7: Fechar o tampão  da máquina");
        Thread.Sleep(2500);
        Console.WriteLine("");
        Console.ReadKey();
        
        Console.Clear();
        Ligar();
        Temporizador();
    }

    public void Ligar()
    {
        Console.WriteLine("Ligar a máquina a Corrente elétrica? [s]Sim || [n]Não");
        char cabo=char.Parse(Console.ReadLine());

        switch(cabo)
        {
            case 's':
                Console.WriteLine("Máquina ligada a Corrente!");
            Thread.Sleep(2500);
            Console.WriteLine("-----");
            break;
           
            default:Console.Clear(); Ligar(); break;
            
          
        }
    }

    public void Temporizador()
    {
        Console.WriteLine("Regular o temporizador de Giro [Máximo]=10m");
        string tempo=Console.ReadLine();
        char UnidadeTempo=char.Parse(tempo.Substring(tempo.Length-1,1));
        int TempoDigitado=Convert.ToInt32(tempo.Substring(0,tempo.Length-1));

        int Contador=1;

        if(UnidadeTempo=='m')
            Contador=60;

            TempoDigitado*=Contador;

        short temporizador=0;
      
        
        do
        {
            temporizador++;
            Console.WriteLine($"Tempo:{temporizador}");
            Thread.Sleep(1000);
            Console.Clear();
        }
        while(temporizador!=TempoDigitado);

         Console.WriteLine("Temporizador Concluido!");
         Console.WriteLine($"Tempo:{tempo}");
         Console.WriteLine("------------");
        Verificar();
    }

    public void Sair()
    {
        Console.WriteLine("Sair do Programa?\n[s]Sim [n]Não");
        char sair = char.Parse(Console.ReadLine());

        if (sair == 's' || sair == 'S')
            System.Environment.Exit(0);

        else
        {
            Console.Clear();
           Menu();
        }
    }

    public void Verificar()
    {
        Console.WriteLine("Verificar se a roupa está Limpa \n[l]Limpa || [s]Suja");

        char EstadoRoupa = char.Parse(Console.ReadLine());

        switch(EstadoRoupa)
        {
            case 'l': case 'L': Console.Clear();
            Console.WriteLine("Roupa Limpa!! \nTirar a Roupa da Máquina.."); 
            Console.WriteLine("------------------------------");
            Console.ReadKey();
            Console.Clear();
            Inicio2(); break;
            default: Console.Clear();Temporizador(); break;
        }

        
    }

    public void Inicio2()
    {
        Console.WriteLine("Selecionar outras peças a serem Lavadas? \n[s]Sim || [n]Não");

        char seletor=char.Parse(Console.ReadLine());

        switch(seletor)
        {
            case 's': case 'S':  
            Console.WriteLine("Passo 1: Colocar as peças selecionadas no interior da máquina");
            Console.ReadKey(); Console.Clear(); Temporizador(); break;

            default: Console.Clear(); Sair(); break;
        }
    }
   
}

public class EditorTexto
{
    public void Menu()
    {
        Console.WriteLine("Bem vindo ao Stalo Editor");
        Console.WriteLine("");
        Console.WriteLine("1-Abrir um arquivo");
        Console.WriteLine("2-Editar um novo Arquivo");
        Console.WriteLine("3-Salvar");
        Console.WriteLine("0-Sair");
        Console.WriteLine("");

        Console.WriteLine("Escolha uma Opção");
        short escolha=Convert.ToInt16(Console.ReadLine());

        switch(escolha)
        {
           case 0:System.Environment.Exit(0);break;
           case 1:Abrir(); break;
           case 2:Editar(); break; 
        }
    }
    public void Abrir(){}

    public void Editar()

    {
        Console.Clear();
       Console.WriteLine("Digite o seu texto");
       Console.WriteLine("");

       var TextoDigitado="";

       do
       {
            TextoDigitado+=Console.ReadLine();
            TextoDigitado+=Environment.NewLine;
       }
        while (Console.ReadKey().Key != ConsoleKey.Escape);

        Salvar(TextoDigitado);

    }

    public void Salvar(string texto)
    {
        Console.Clear();
      Console.WriteLine("Digite o Caminho que pretende salvar o arquivo");
      var caminho=Console.ReadLine();

        using (var arquivo = new StreamWriter(caminho))
      {
        arquivo.Write(texto);
      }
        Console.Clear();
        Console.WriteLine($"Aequivo salvo com sucesso \nCaminho:{caminho}"); 
      
    }
}

