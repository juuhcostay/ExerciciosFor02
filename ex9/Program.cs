Console.WriteLine("Hello, World!");
double totalBruto = 0;
double totalDescontos = 0;
double totalFinal = 0;

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"Digite o preço do item {i}: ");
    double preco = double.Parse(Console.ReadLine());

    totalBruto += preco;

    double desconto;
    if (preco > 100.0)
    {
        desconto = preco * 0.10;
    }
    else
    {
        desconto = preco * 0.05;
    }

    totalDescontos += desconto;
}

totalFinal = totalBruto - totalDescontos;

Console.WriteLine("Resumo da compra!");
Console.WriteLine($"Total bruto: R$ {totalBruto}");
Console.WriteLine($"Total de descontos: R$ {totalDescontos}");
Console.WriteLine($"Total final da nota: R$ {totalFinal}");


