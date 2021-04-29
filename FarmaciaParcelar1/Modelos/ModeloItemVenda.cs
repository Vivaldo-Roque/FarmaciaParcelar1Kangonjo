using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaciaParcelar1.Modelos
{
    class ModeloItemVenda
    {
        public int ID { get; set; }
        public int Produto { get; set; }
        public int Quantidade { get; set; }
        public Decimal ValorUnico { get; set; }
        public int Venda { get; set; }
    }
}
