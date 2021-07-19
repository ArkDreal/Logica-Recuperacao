using System;
using System.Collections.Generic;

namespace Lógica_ArkDreal
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<string> inscritos = new List<string>();
           
            
            // FUNÇÕES CHAMADAS //
            CadastrarParticipantes (inscritos);
            ListaParticipantes(inscritos);
           
            // ----------------------- //
         }

        public static void CadastrarParticipantes(List<string> inscritos){
            string respostaCadastrar;
            string acompanhadoValidar = "sim";
            
            do
            {
            Console.WriteLine("Qual é o seu nome?");
            string nome = Console.ReadLine();

            Console.WriteLine("Qual é a sua idade?");
            int idadePessoa = int.Parse(Console.ReadLine()); 

            if (idadePessoa <= 16)
            {
                Console.WriteLine("Você está acompanhado com seus pais? (sim/nao)");
                acompanhadoValidar = Console.ReadLine();
            }

            if (idadePessoa >= 16 || acompanhadoValidar == "sim" )
            {
                Console.WriteLine("Você pode entrar no evento!");
                inscritos.Add(nome);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Você foi cadastrado com sucesso!");
                Console.ResetColor();

            }

            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Você não tem permissão para entrar no evento! Não pode ser cadastrado!");
                Console.ResetColor();
            } 

            Console.WriteLine("Você deseja cadastrar mais uma pessoa? (sim/nao)");
            respostaCadastrar = Console.ReadLine();


            } while (respostaCadastrar == "sim");
            
        }

        public static void  ListaParticipantes(List<string> inscritos){ 
            foreach (var nome in inscritos)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(nome);
                Console.ResetColor();
            }
        }
    }
}
