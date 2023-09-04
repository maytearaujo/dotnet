// See https://aka.ms/new-console-template for more information
int chamado = 0;

Console.WriteLine("Informe a urgência do chamado: ");
chamado = int.Parse(Console.ReadLine());

if (chamado >=0 && chamado <= 3)
{
    Console.WriteLine("BAIXO");
}else if (chamado > 3 && chamado <= 6)
{
    Console.WriteLine("MEDIO");
}else if (chamado > 6 && chamado <= 9)
{
    Console.WriteLine("ALTO");
}
else
{
    Console.WriteLine("GRAVE");

}