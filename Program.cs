using System;

namespace Turismo
{
    class Program
    {
        static void Main(string[] args)
        {
            int tamanhoA = 5;
            string[] nome = new string[tamanhoA];
            string[] origem = new string[tamanhoA];
            string[] destino = new string[tamanhoA];
            string[] data = new string[tamanhoA];
            // int[] quantidadePassagens =  null;
            int i = 0;
            string senha;
            string senhaCorreta;
            string resposta;
            bool respostaCorreta = false;
            bool condicao = false;





            do
            {
                Console.Write("\nInsira sua senha: ");
                senha = Console.ReadLine();

                senhaCorreta = "123456";


                if (senha == senhaCorreta)
                {

                    Console.WriteLine("senha correta");

                    respostaCorreta = true;
                    // Console.WriteLine("Fim da execução\n");
                }

                if (senha == senhaCorreta)
                {

                    do
                    {
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine(@"
|==========================================|
|  Selecione uma das opcções do menu:      |
|                                          |
|    1 - Cadastrar passagens               |
|    2 - Listar passagens                  |
|    0 - Sair                              |
|==========================================|   
         ");

                        Console.ForegroundColor = ConsoleColor.White;

                        string sistema = Console.ReadLine();

                        switch (sistema)
                        {
                            case "1":
                                
                                    do
                                    {

                                        Console.Write("\nDigite o nome do passageiro: ");
                                        nome[i] = Console.ReadLine();

                                        Console.Write("Digite qual o lugar é a saída: ");
                                        origem[i] = Console.ReadLine();

                                        Console.Write("Digite o destino: ");
                                        destino[i] = Console.ReadLine();

                                        Console.Write("Digite a data da viagem ex: xx/xx/xxxx: ");
                                        data[i] = Console.ReadLine();

                                        Console.Write("Você deseja cadastrar mais uma passagem? (s/n) \n");
                                        resposta = Console.ReadLine();

                                        i++;

                                    } while (resposta == "s");

                                
                                break;


                            case "2":

                                Console.Clear();
                                Console.WriteLine("Nome           Destino           Origem         data");

                                for (var c = 0; c < tamanhoA; c++)
                                {

                                    // Console.WriteLine(nome[c], destino[c], origem[c], data[c]);

                                    Console.WriteLine($"{nome[c]} {destino[c]}  {origem[c]} {data[c]}");

                                }

                                break;

                            case "0":

                            Console.WriteLine("\nObrigado por acessar!!");
                            condicao = true;
                                break;


                            default:
                                break;
                        }


                    } while (!condicao);
                }

                else
                {
                    Console.WriteLine("senha incorreta, insira outra senha ");

                }
            } while (senha != senhaCorreta);



        }

    }
}



