int numero = 0; int calculo = 0;

Console.WriteLine("Informe um número de 1 a 10");
numero = int.Parse(Console.ReadLine());

    if (numero < 0 || numero > 10)
    {
        Console.WriteLine("Informe um número entre 0 e 10");
    }
    else
    {
        for (int i = 1; i < 11; i++)
        {
            calculo = numero * i;
            Console.WriteLine(i + " X " + numero + " = " + calculo);
        }
    }
