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
            int n1=0, n2=0, n3=0;

            Console.WriteLine("Digite o 1º valor");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o 2º valor");
            n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o 3º valor");
            n3 = int.Parse(Console.ReadLine());

            if ( n1 == n2 )
            {
                Console.WriteLine(n1 + " é igual a " + n2);
            }
            else if ( n1 == n3 ) 
            {
                Console.WriteLine(n1 + " é igual a " + n3);

            }else if ( n2 == n3) {
                Console.WriteLine(n2 + " é igual a " + n3);

            }
            else
            {
                if( (n1 < n2 ) && (n1<n3))
                {
                    Console.WriteLine(n1 + " é o menor");
                }else if( (n2 < n3 ) && (n2 < n1))
                {
                    Console.WriteLine(n2 + " é o menor");

                }
                else
                {
                    Console.WriteLine(n3 + " é o menor");

                }
            }

        }

    }

}