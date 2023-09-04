// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {

            /* DECLARANDO VARIÁVEIS*/
            //TIPADA
            string nome;
            int idade;

            //SEM TIPO
            var sobrenome="";


            //TIPAGEM DINAMICA ()
            dynamic corFavorita = "Azul";

            corFavorita = 678.98;

            Console.Write("Hello, World!\n");
            Console.WriteLine("Meu Nome é Maytê");

            Console.WriteLine("Digite seu nome");
            nome = Console.ReadLine();
            Console.WriteLine(nome + " Seja bem vindo(a)!");

            //VALORES QUE NAO SERAO ALTERADOS DURANTE EXECUCAO DO PROGRAMA
            const float PI = 3.14159265358979323846f;


        }
    }
}
