using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaciaParcelar1.Modelos
{
    class ModeloProduto
    {
        public int ID { get; set;}
        public string Fabricante { get; set; }
        public string Fornecedor { get; set; }
        public string Nome { get; set; }
        public DateTime Data { get; set; }
        public string Descricao { get; set; }
        public int Quantidade { get; set; }
        public decimal ValorFinal { get; set; }
        public int QuantidadeMinima { get; set; }
    }
}
