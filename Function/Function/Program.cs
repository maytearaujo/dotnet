class Program
{
    static void Main(string[] args)
    {
        string name, surname;
        ExibirMsg();
        Console.WriteLine( FullName("Maytê", "Araújo"));
        
        Console.WriteLine("Tell me your name");
        name = Console.ReadLine();

        Console.WriteLine("Tell me your surname");
        surname = Console.ReadLine();

        Console.WriteLine(FullName(name, surname));

        GerarPreco(250);
        Console.ReadLine();

    }

    static void ExibirMsg()
    {
        Console.WriteLine("Funções são show de bola!");
        Console.WriteLine("Estou usando funções");
        Console.WriteLine("By Maytê Araújo");
    }

    static String FullName(String name, String surname) { 
        return name + " " + surname;
    }

    static void GerarPreco(int preco)
    {
        //CONVERTE NUMERO NEGATIVO EM POSITIVO (MODULO)
        int precoAbs = Math.Abs(preco);
        preco = preco + (preco * 2);
        Console.WriteLine("Novo Preço" + preco);
    }
}