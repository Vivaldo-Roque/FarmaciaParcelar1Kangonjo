using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaciaParcelar1.Classes
{
    class LogadoNoSistema
    {
        private static int id;
        private static string nome;
        private static string nomeDeUsuario;
        private static int acesso;
        public static int Acesso
        {
            get { return acesso; }
            set { acesso = value; }
        }
        public static int ID
        {
            get { return id; }
            set { id = value; }
        }
        public static string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public static string NomeDeUsuario
        {
            get { return nomeDeUsuario; }
            set { nomeDeUsuario = value; }
        }

    }
}
