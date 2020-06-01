using System.Collections.Generic;

namespace TestDriver.Models
{
    public class ListagemVeiculo
    {
        public List<Veiculo> Veiculos { get; set; }

        public ListagemVeiculo()
        {
            this.Veiculos = new List<Veiculo>
            {
                new Veiculo { Nome = "CB 300", Preco = 10000 },
                new Veiculo { Nome = "Classic", Preco = 25000 },
                new Veiculo { Nome = "Prisma", Preco = 40000 },
            };                                                  
        }
    }
}
