using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmaciaParcelar1.DAL
{
    //Classe responsavel pela string de conexao ao banco de dados
    public class DadosDaConexao
    {
        static string appPath = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
        public static string StringDeConexao
        {
            get { return $@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={appPath}\farmacia.accdb;Persist Security Info=True;Jet OLEDB:Database Password=gormiti"; }
        }
    }
}
