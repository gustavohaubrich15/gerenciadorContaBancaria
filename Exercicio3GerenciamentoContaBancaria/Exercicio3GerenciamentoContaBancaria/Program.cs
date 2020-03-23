using System;

namespace Exercicio3GerenciamentoContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria contaBancaria = new ContaBancaria("Gustavo","123456",20.62);
            char digitado = '1';
            while (digitado != '4')
            {
                Console.WriteLine("1) Deposito");
                Console.WriteLine("2) Saque");
                Console.WriteLine("3) Consulta de Transacoes");
                Console.WriteLine("4) Sair");
                digitado = Char.Parse(Console.ReadLine());

                switch (digitado)
                {
                    case '1':
                        Console.Write("Digite um valor: ");
                        double deposito =double.Parse(Console.ReadLine());
                        contaBancaria.Depositar(deposito);
                        break;
                    case '2':
                        Console.Write("Digite um valor: ");
                        double saque = double.Parse(Console.ReadLine());
                        contaBancaria.Sacar(saque);
                        break;
                    case '3':
                        Console.WriteLine("\n     Transacoes      \n");
                        foreach (string historico in contaBancaria.HistoricoTransacoes)
                        {
                            Console.WriteLine(historico);
                        }
                        Console.WriteLine("");
                        break;
                    case '4':
                        Console.WriteLine("Saindo.......");
                        break;
                    default:
                        Console.WriteLine("Opção inválida...");
                        break;
                }
            }
        }
    }
}
