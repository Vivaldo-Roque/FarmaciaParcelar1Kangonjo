using FarmaciaParcelar1.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaciaParcelar1.BLL
{
    class BllEstoque
    {
        private readonly DalConexao conexao;
        public BllEstoque(DalConexao conexao)
        {
            this.conexao = conexao;
        }

        public DataTable CarregarDataGridView()
        {
            DalEstoque dalEstoque = new DalEstoque(conexao);
            return dalEstoque.CarregarDataGridView();
        }
    }
}
