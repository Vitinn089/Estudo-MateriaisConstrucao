using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessoDados
{
    public class Conexao
    {
        //Atributo que é a String de Conexão
        private static string conexao = @"Data Source=Vitinn-PC\SQLEXPRESS;Initial Catalog=Construcao;Integrated Security=True; User ID=Vitinn; Password=2101089vl2";

        //Método acessor de leitura da String de Conexão
        public static string stringConexao
        {
            get { return conexao; }
        }
    }
}
