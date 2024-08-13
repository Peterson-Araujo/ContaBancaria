using ContaBancaria;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        Conta conta;
        int numeroConta;
        double depositoInicial;
        char resp;
        string nome;

        Console.Write("Entre com o número da conta: ");
        numeroConta = int.Parse(Console.ReadLine());

        Console.Write("Entre com o titular da conta: ");
        nome = Console.ReadLine();

        Console.Write("Haverá depósito? (s/n): ");
        resp = char.Parse(Console.ReadLine());
        if (resp == 's' ||  resp == 'S')
        {
            Console.Write("Entre com o valor inicial de depósito: ");
            depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta = new Conta(numeroConta, nome, depositoInicial);
        }
        else
        {
             conta = new Conta(numeroConta, nome);
        }

        Console.WriteLine();
        Console.WriteLine(conta);
        Console.WriteLine();

        Console.Write("Entre com um valor para depósito: ");
        conta.Depositar(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

        Console.WriteLine();
        Console.WriteLine(conta);
        Console.WriteLine();

        Console.Write("Entre com um valor para saque: ");
        conta.Sacar(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

        Console.WriteLine();
        Console.WriteLine(conta);
        Console.WriteLine();
    }
}