using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MateriaisParaConstrucao
{
    public class Produtos
    {
        SqlCommand comandoSql = new SqlCommand();
        StringBuilder sql = new StringBuilder();
        DataTable dadosTabela = new DataTable();

        public DataTable ListarCategorias()
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();

                    sql.Append("SELECT * FROM Categoria_produtos ");

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    dadosTabela.Load(comandoSql.ExecuteReader());
                    return dadosTabela;
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método 'ListarCategorias'. Caso o erro persista, entre em contato com o Administrador do Sistema.");
            }
        }

        public void SalvarCategoria(string nome, string descricao)
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();

                    sql.Append("INSERT INTO Categoria_produtos(NOME_CATEGORIA_PRODUTOS, DESCRICAO_CATEGORIA_PRODUTOS) ");
                    sql.Append("VALUES (@nome, @descricao)");

                    comandoSql.Parameters.Add(new SqlParameter("@nome", nome));
                    comandoSql.Parameters.Add(new SqlParameter("@descricao", descricao));

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    comandoSql.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método 'SalvarCategoria'. Caso o erro persista, entre em contato com o Administrador do Sistema.");
            }
        }

        public void AlterarCategoria(int idCategoria, string nome, string descricao)
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();

                    sql.Append("UPDATE Categoria_produtos ");
                    sql.Append("SET NOME_CATEGORIA_PRODUTOS = @nome, DESCRICAO_CATEGORIA_PRODUTOS = @descricao ");
                    sql.Append("WHERE ID_CATEGORIA_PRODUTOS = @idCategoria");


                    comandoSql.Parameters.Add(new SqlParameter("@idCategoria", idCategoria));
                    comandoSql.Parameters.Add(new SqlParameter("@nome", nome));
                    comandoSql.Parameters.Add(new SqlParameter("@descricao", descricao));


                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    comandoSql.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método 'AlterarCategoria'. Caso o erro persista, entre em contato com o Administrador do Sistema.");
            }
        }

        public void ExcluirCategoria(int idCategoria)
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();

                    sql.Append("DELETE FROM Categoria_produtos ");
                    sql.Append("WHERE ID_CATEGORIA_PRODUTOS = @idCategoria");

                    comandoSql.Parameters.Add(new SqlParameter("@idCategoria", idCategoria));

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    comandoSql.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método 'ExcluirCategoria'. Caso o erro persista, entre em contato com o Administrador do Sistema.");
            }
        }
    }
}