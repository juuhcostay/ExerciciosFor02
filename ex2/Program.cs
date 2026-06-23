Console.WriteLine("Hello, World!");
double saldo;

Console.Write("Digite o valor do aporte inicial: R$ ");
saldo = double.Parse(Console.ReadLine());

for (int mes = 1; mes <= 12; mes++)
{
    // Aplica rendimento de 0,6% ao mês
    saldo = saldo * 1.006;

    // Exibe o saldo atualizado do mês
    Console.WriteLine($"Mês {mes}: Saldo = R$ {saldo:F2}");
}
