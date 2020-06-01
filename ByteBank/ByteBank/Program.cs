using System;
using System.Collections.Generic;
using System.Linq;
using Humanizer;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            var contas = new List<ContaCorrente>()
            {
                new ContaCorrente(31,1),
                new ContaCorrente(12,4),
                null,
                new ContaCorrente(21,3),
                null
            };

            IOrderedEnumerable<ContaCorrente> contaOrdenadas = contas
                .Where(conta => conta != null)
                .OrderBy<ContaCorrente, int>(conta => conta.Agencia);

          
            foreach (var item in contaOrdenadas)
            {
                Console.WriteLine($"Nuemro :  { item.Numero}, Agencia : {item.Agencia}");
            }
            Console.ReadKey();

        }
    }
}
