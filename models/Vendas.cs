using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace textetion_.models
{
    public class Vendas
    {
        public int Id { get; set; }
        [JsonProperty("Nome_Produto")]
        public string  Produto { get; set; }
        public decimal Preco { get; set; }
        public DateTime  DataVenda { get; set; }

    }
}