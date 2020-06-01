using System;

namespace ByteBank
{
    public class ContaCorrente : IComparable
    {
        public ContaCorrente(int agencia, int numero)
        {
            Agencia = agencia;
            Numero = numero;

            if (agencia <= 0)
            {
                throw new ArgumentException("Argumento agencia deve ser >= 0.", nameof(agencia));
            }

            TotalDeContasCriadas++;
            TaxaDeOperacao = 30 / TotalDeContasCriadas;           
        }

        public Cliente Titular { get; set; }
        public int Agencia { get; private set; }
        public int Numero { get; private set; }
        public double Saldo { get; set; } = 200;
        public static int TotalDeContasCriadas { get; private set; }
        public static double TaxaDeOperacao { get; private set; }

        public void Sacar(double valor)
        {
            if (this.Saldo < valor)
            {
                throw new SaldoInsuficienteException("Saldo insuficiente para saque no valor de " + valor);
            }

            this.Saldo -= valor;          
        }

        public void Depositar(double valor)
        {
            this.Saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente ContaDestino)
        {
            if (this.Saldo < valor)
            {
                return false;
            }

            this.Saldo -= valor;
            ContaDestino.Depositar(valor);
            return true;
        }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }
    }


}
