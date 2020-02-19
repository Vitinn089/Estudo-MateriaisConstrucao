using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessoDados
{
    public class NivelAcessoDados
    {
        SqlCommand comandoSql = new SqlCommand();
        StringBuilder sql = new StringBuilder();
        DataTable dadosTabela = new DataTable();

        public DataTable Listar()
        {
            using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
            {
                try
                {
                    conexao.Open();

                    sql.Append("SELECT * FROM Nivel_Acesso");
                    sql.Append(" ORDER BY ID_NIVEL ASC");

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    dadosTabela.Load(comandoSql.ExecuteReader());
                    return dadosTabela;
                }
                catch (Exception)
                {
                    throw new Exception("Ocorreu um erro no método 'Listar'. Caso o erro persista, entre em contato com o Administrador do Sistema.");
                }
            }
        }

        public void Salvar(string nome, string descricao)
        {
            using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
            {
                conexao.Open();

                try
                {
                    sql.Append("INSERT INTO Nivel_Acesso(NOME_NIVEL, DESCRICAO_NIVEL");
                    sql.Append(" VALUES(@nome, @descricao)");

                    comandoSql.Parameters.Add(new SqlParameter("@nome", nome));
                    comandoSql.Parameters.Add(new SqlParameter("@descricao", descricao));

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    comandoSql.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    throw new Exception("Ocorreu um erro no método 'Salvar'. Caso o erro persista, entre em contato com o Administrador do Sistema.");
                }
            }
        }

        public void Alterar(int idNivel, string nome, string descricao)
        {
            using (SqlConnection cnx = new SqlConnection(Conexao.stringConexao))
            {
                cnx.Open();

                sql.Append("UPDATE Nivel_Acesso");
                sql.Append(" SET NOME_NIVEL = @nome, DESCRICAO_NIVEL = @descricao ");
                sql.Append("WHERE ID_NIVEL = @idNivel");

                comandoSql.Parameters.Add(new SqlParameter("@nome", nome));
                comandoSql.Parameters.Add(new SqlParameter("@descricao", descricao));
                comandoSql.Parameters.Add(new SqlParameter("@idNivel", idNivel));

                comandoSql.CommandText = sql.ToString();
                comandoSql.Connection = cnx;
                comandoSql.ExecuteNonQuery();
            }
        }

        public void Excluir(int idNivel)
        {
            using (SqlConnection cnx = new SqlConnection(Conexao.stringConexao))
            {
                cnx.Open();

                sql.Append("DELETE FROM Nivel_Acesso ");
                sql.Append("WHERE ID_NIVEL = @idNivel");

                comandoSql.Parameters.Add(new SqlParameter("@idNivel", idNivel));

                comandoSql.CommandText = sql.ToString();
                comandoSql.Connection = cnx;
                comandoSql.ExecuteNonQuery();
            }
        }
    }
}
