using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace textetion_.models
{
    public class Venda
    {
        public Venda(int Id, string Produto, decimal Preco)
        {
            Id = Id;
            Produto = Produto;
            Preco = Preco;
        }
        public int Id { get; set; }
        public string  Produto { get; set; }
        public decimal Preco { get; set; }
    }
}