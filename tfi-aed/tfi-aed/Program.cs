﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tfi_aed
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao = 0;
            Arquivo dados = new Arquivo();

            while (opcao != 4)
            {
                Console.WriteLine("Selecione uma das opções abaixo:\n 1- X \n 2- \n 3 - \n 4 - Sair\nDigite a opção selecionada:");
                opcao = int.Parse(Console.ReadLine());

                if (opcao == 1)
                {
                    Console.Clear();

                    Console.WriteLine("Qual a vaga que deseja pesquisar?");
                    string vaga = Console.ReadLine();

                    VagaArvore vagaArvore = dados.LeitorVagas();
                    vagaArvore = dados.LeitorEstacionada(null, vagaArvore);

                    Console.WriteLine("Digite data inicial");
                    string intervaloIni = Console.ReadLine();

                    Console.WriteLine("Digite data final");
                    string intervaloFim = Console.ReadLine();

                    vagaArvore.PrintarEstaciondas(vaga, intervaloIni, intervaloFim);

                    Console.WriteLine("Digite algo para continuar...");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (opcao == 2)
                {
                    Console.Clear();

                    Console.WriteLine("Qual placa do carro deseja pesquisar?");
                    string placa = Console.ReadLine();

                    PlacaArvore placaArvore = dados.LeitorPlacas();
                    placaArvore = dados.LeitorEstacionada(placaArvore, null);

                    placaArvore.PrintarEstaciondas(placa);

                    Console.WriteLine("Digite algo para continuar...");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (opcao == 3)
                {
                    Console.Clear();

                    Console.WriteLine("Digite algo para continuar...");
                    Console.ReadKey();
                    Console.Clear();
                } 
            }
        }
    }
}
    