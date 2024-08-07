namespace Exercicios;

public class Exercicio_01
{
    public short opcao;
    public void Sms()
    {
        Console.Clear();
        Console.BackgroundColor = ConsoleColor.Green;
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Tudo está dando Certo....Everthing's gonna be Allright!");
        Console.ReadKey();
    }

    public void Famrmacia()
    {
        try
        {
            Console.Clear();
            Console.WriteLine("Bem vindo a Stalo Farmácia");
            Console.WriteLine("==========================");
            Console.WriteLine("1-Paracetamol");
            Console.WriteLine("2-Relieff");
            Console.WriteLine("3-Zibu Pluss");
            Console.WriteLine("0-Sair");
            Console.WriteLine("__________________________");
            Console.Write("Opção:");
            opcao = Convert.ToInt16(Console.ReadLine());
            

        switch(opcao)
        {
            case 0: Environment.Exit(0); break;
            case 1:
            {
                Console.Clear();
                Console.WriteLine("Paracetamol : 300 kz");
                Console.WriteLine("====================");              
                Decisao();
                break;
            }
            case 2:
            {
                Console.Clear();
                Console.WriteLine("Relieff : 350 kz");
                Console.WriteLine("====================");                
                Decisao();
                break;
            }
            case 3:
            {
                Console.Clear();
                Console.WriteLine("Zibu Pluss : 500 kz"); 
                Console.WriteLine("====================");                
                Decisao();
                break;
            }

            default: Famrmacia(); break;
        }

        }
        catch
        {
            Console.WriteLine("Digite apenas valores numéricos");
            Console.ReadKey();
            Famrmacia();
        }
       
        
    }
    public void Decisao()
    {
        try
        {          
            Console.WriteLine("1-Comprar");
            Console.WriteLine("0-Descartar");
            Console.Write("Escolha:");
            int escolha = Convert.ToInt16(Console.ReadLine());

        switch(escolha)
        {
            case 1:
            {
                Escolha_Comprimido();
                break;
            }
            // case 1:
            // {
            //     Console.Clear();
            //     Console.WriteLine("Valor pago");
            //     double valor_pago = Convert.ToDouble(Console.ReadLine());

            //     Console.WriteLine("valor do comprimido");
            //     double valor_comprimido = Convert.ToDouble(Console.ReadLine());

            //     double Troco = valor_pago - valor_comprimido;

            //     if(valor_pago < valor_comprimido)
            //     {
            //         Console.Clear();
            //         Console.WriteLine("Ups...Valor insuficiente para compra!");
            //         Console.WriteLine("=====================================");  
            //         Console.WriteLine("Valor pago:{0:c}",valor_pago);
            //         Console.WriteLine("Valor do Comprimido:{0:c}",valor_comprimido);
            //         Console.ReadKey();
            //         Famrmacia();

            //     }

            //     Console.WriteLine("Compra efeituada com sucesso!");
            //     Console.ReadKey();
            //     Console.Clear();

            //     Console.WriteLine("Troco:{0:c}",Troco);
            //     Console.ReadKey();
            //     Famrmacia();

            //     break;
            //}

            case 0: Famrmacia(); break;

            default: Famrmacia(); break;
        }


        }
        catch
        {
            Console.WriteLine("Digite apenas valores numéricos");
            Console.ReadKey();
            Famrmacia();
        }
       
    }

    public void Escolha_Comprimido()
    {
        switch(opcao)
        {
            case 1:
            {
                Console.Clear();
                Console.WriteLine("Paracetamol : 300 kz");
                Console.WriteLine("====================");

                Console.WriteLine("Valor pago");
                double valor_pago = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("valor do comprimido");
                double valor_comprimido = Convert.ToDouble(Console.ReadLine());

                double Troco = valor_pago - valor_comprimido;

                if(valor_pago < valor_comprimido)
                {
                    Console.Clear();
                    Console.WriteLine("Ups...Valor insuficiente para compra!");
                    Console.WriteLine("=====================================");  
                    Console.WriteLine("Valor pago:{0:c}",valor_pago);
                    Console.WriteLine("Valor do Comprimido:{0:c}",valor_comprimido);
                    Console.ReadKey();
                    Famrmacia();

                }

                Console.WriteLine("Compra efeituada com sucesso!");
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("Troco:{0:c}",Troco);
                Console.ReadKey();
                Famrmacia();

                break;
            }

            case 2:
            {
                Console.Clear();
                Console.WriteLine("Relieff : 350 kz");
                Console.WriteLine("====================");       

                Console.WriteLine("Valor pago");
                double valor_pago = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("valor do comprimido");
                double valor_comprimido = Convert.ToDouble(Console.ReadLine());

                double Troco = valor_pago - valor_comprimido;

                if(valor_pago < valor_comprimido)
                {
                    Console.Clear();
                    Console.WriteLine("Ups...Valor insuficiente para compra!");
                    Console.WriteLine("=====================================");  
                    Console.WriteLine("Valor pago:{0:c}",valor_pago);
                    Console.WriteLine("Valor do Comprimido:{0:c}",valor_comprimido);
                    Console.ReadKey();
                    Famrmacia();

                }

                Console.WriteLine("Compra efeituada com sucesso!");
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("Troco:{0:c}",Troco);
                Console.ReadKey();
                Famrmacia();

                break;
            }

            case 3:
            {               
                Console.Clear();
                Console.WriteLine("Zibu Pluss : 500 kz");
                Console.WriteLine("====================");

                Console.WriteLine("Valor pago");
                double valor_pago = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("valor do comprimido");
                double valor_comprimido = Convert.ToDouble(Console.ReadLine());

                double Troco = valor_pago - valor_comprimido;

                if(valor_pago < valor_comprimido)
                {
                    Console.Clear();
                    Console.WriteLine("Ups...Valor insuficiente para compra!");
                    Console.WriteLine("=====================================");  
                    Console.WriteLine("Valor pago:{0:c}",valor_pago);
                    Console.WriteLine("Valor do Comprimido:{0:c}",valor_comprimido);
                    Console.ReadKey();
                    Famrmacia();

                }

                Console.WriteLine("Compra efeituada com sucesso!");
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("Troco:{0:c}",Troco);
                Console.ReadKey();
                Famrmacia();

                break;       
            }

           

            
        }
    }
}
