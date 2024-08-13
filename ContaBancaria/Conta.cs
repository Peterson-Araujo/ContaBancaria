using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ContaBancaria
{
    public class Conta
    {
        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public Conta(int numeroDaConta, string nomeTitular)
        {
            Numero = numeroDaConta;
            Titular = nomeTitular;
        }

        public Conta(int numeroDaConta, string nomeTitular, double depositoInicial) : this(numeroDaConta, nomeTitular)
        {
            Depositar(depositoInicial);
        }

        public double Depositar(double deposito)
        {
            return Saldo += deposito;
        }

        public double Sacar(double deposito)
        {
            return Saldo -= deposito + 5.0;
        }

        public override string ToString()
        {
            return "Dados da conta: \n"
                    + "Conta: "
                    + Numero
                    + ", titular: "
                    + Titular
                    + ", saldo: $ "
                    + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
