using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaciaParcelar1.DAL
{
    //Classe responsavel pela string de conexao ao banco de dados
    public class DadosDaConexao
    {
        public static string StringDeConexao
        {
            get { return @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\VivaldoRoque\source\repos\FarmaciaParcelar1\FarmaciaParcelar1\farmacia.accdb"; }
        }
    }
}
