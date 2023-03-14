namespace Calculadora_001
{
    internal class Program
    {
        static void Main(string[] args)

            
    {       Console.Write("digite o numero desejado de operacoes:");
                                  
            do
            {
                Console.Clear();    
                Console.WriteLine(" Calculadora ");

                Console.WriteLine("digite 1 para adicionar");
                Console.WriteLine("digite 2 para  subtrair ");
                Console.WriteLine("digite 3 para  Multiplicacao ");
                Console.WriteLine("digite 4 para  Divisao ");

                Console.WriteLine("digite S para  sair ");


                string operacao = Console.ReadLine();

                if (operacao =="S" || operacao== "s")
                {
                    break;
                }
                if (operacao != "1" && operacao != "2" && operacao != "3" && operacao != "4" && operacao!= "S" && operacao!= "s")
                {

                    Console.WriteLine("operação invalida, digite novamente ...");
                    Console.ReadLine();
                }

                Console.Write(" Digite o primeiro numero: ");

                
                int primeiroNumero = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(" Digite o segundo numero : ");

                
                int segundoNumero = Convert.ToInt32(Console.ReadLine());

                int resultado = 0;

                bool ehAdicao = operacao == "1";
                bool ehSubtracao = operacao == "2";
                bool ehMultiplicacao = operacao == "3";
                bool ehDivisao = operacao == "4";

                Console.WriteLine("operacao invalida , tente novamente ");
                Console.ReadLine();




                if (ehAdicao)
                {

                     resultado = primeiroNumero + segundoNumero;
                }
                if (ehSubtracao)
                   
                    resultado = primeiroNumero - segundoNumero;

                {
                if (ehMultiplicacao)
                        resultado = primeiroNumero * segundoNumero;
                }
                { 
                if (ehDivisao)

                        while(segundoNumero == 0)
                        { Console.WriteLine("seegundo numero nao pode ser Zero, tende de novo");
                            
                            Console.ReadLine();

                            Console.Write("Digite o segundo nomero : ");

                            segundoNumero = Convert.ToInt32(Console.ReadLine()); 
                        }

                        resultado = primeiroNumero / segundoNumero;
                }
                     
                

                Console.WriteLine("O resultado da operecao eh : " + resultado);
                                
                Console.ReadLine();

                
            } while (true);

            } 
                       
        }
    }
