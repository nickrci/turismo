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
            int c = 0;
            string listar;





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

                                // Console.Clear();
                                // Console.WriteLine($"Nome:{nome[c]} Destino Origem data");


                                for (c = 0; c < i; c++)
                                {

                                   
                                    Console.WriteLine("Nome: " + nome[c]);
                                    Console.WriteLine("Destino: " + destino[c]);
                                    Console.WriteLine("Origem: " + origem[c]);
                                    Console.WriteLine("Data: " + data[c] + "\n");

                                    // Console.WriteLine("\nAperte enter para listar a outra passagem ou continuar \n");
                                    // listar = Console.ReadLine();

                                    // Console.WriteLine($"{nome[i]} {destino[i]}  {origem[i]} {data[i]}");

                                }
                                condicao = false;

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



