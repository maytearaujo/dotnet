

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 0, n2 = 0, n3 = 0;

            Console.WriteLine("Digite o 1º número");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o 1º número");
            n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o 1º número");
            n3 = int.Parse(Console.ReadLine());

            if (n1 == n2 && n2 == n3) {
                Console.WriteLine("Os números são iguais");
            }else if ( n1 == n2) {
                Console.WriteLine("Os dois primeiros números são iguais");
            }else if( n2== n3)
            {
                Console.WriteLine("Os dois últimos números são iguais");
            }else if (n1 == n3) 
            {
                Console.WriteLine("O Primeiro e último número são iguais");
            }
            else
            {
                if(n1 > n2 && n1 > n3)
                {
                    Console.WriteLine(n1 + " É o maior número");
                }else if(n2 > n1 && n2 > n3)
                {
                    Console.WriteLine(n2 + " É o maior número");
                }else
                {
                    Console.WriteLine(n3 + " É o maior número");
                }
            }
        }
    }
}