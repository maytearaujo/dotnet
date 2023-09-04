int idade;

Console.WriteLine("Informe sua idade");
idade = int.Parse(Console.ReadLine());


if (idade <= 0)
{
    Console.WriteLine("Você é um recem nascido");
}else if(idade > 0 && idade < 12){
    Console.WriteLine("Você é uma criança");
}else if (idade >= 12 && idade <= 18)
{
    Console.WriteLine("Você um adolescente");
}else if (idade > 18 && idade <= 60)
{
    Console.WriteLine("Você é um Adulto");
}
else
{
    Console.WriteLine("Você é um idoso");
}