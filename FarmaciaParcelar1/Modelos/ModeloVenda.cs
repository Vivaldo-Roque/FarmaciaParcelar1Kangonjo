using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaciaParcelar1.Modelos
{
    class ModeloVenda
    {
        public int ID { get; set; }
        public int Cliente { get; set; }
        public int Funcionario { get; set; }
        public decimal ValorBruto { get; set; }
        public decimal ValorLiquido { get; set; }
        public decimal Imposto { get; set; }
        public decimal Desconto { get; set; }
        public DateTime Data { get; set; }
        public DateTime DataPagamento { get; set; }
        public DateTime Hora { get; set; }
        public int NumeroFatura { get; set; }
    }
}
