using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaciaParcelar1.Modelos
{
    class ModeloCliente
    {
        public int ID { get; set;}
        public string Nome { get; set; }
        public string BI { get; set; }
        public int Genero { get; set; }
        public DateTime Data { get; set; }
        public int EstadoCivil { get; set; }
        public int Telefone { get; set; }
        public string Email { get; set; }
        public DateTime DataRegisto { get; set; }
    }
}
