using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio3GerenciamentoContaBancaria
{
    class ContaBancaria
    {
        private const string Format = "C";

        public string Titular { get; set; }
        public string CodigoConta { get; set; }
        private double Saldo { get; set; }
        public List<string> HistoricoTransacoes { get; private set; }

        public ContaBancaria(string titular, string codigoConta, double saldoInicial)
        {
            Titular = titular;
            CodigoConta = codigoConta;
            Saldo = saldoInicial;
            HistoricoTransacoes = new List<string> { String.Format("Titular - {0} \tCodigo da Conta - {1}", titular, codigoConta), "Saldo Inicial = " + saldoInicial.ToString(Format) };

        }

        public void Depositar(double valor)
        {
            Saldo += valor;
            HistoricoTransacoes.Add("Deposito = " + valor.ToString(Format));
            HistoricoTransacoes.Add("Saldo = " + Saldo.ToString(Format));
        }

        public void Sacar(double valor)
        {
            if (Saldo >= valor)
            {
                Saldo -= valor;
                HistoricoTransacoes.Add("Saque = " + valor.ToString(Format));
                HistoricoTransacoes.Add("Saldo = " + Saldo.ToString(Format));
            }
        }

    }
}
