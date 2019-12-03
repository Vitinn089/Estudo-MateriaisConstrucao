using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessoDados
{
    public class ProdutosAcessoDados
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
                    sql.Append("ORDER BY NOME_CATEGORIA_PRODUTOS ASC");

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

        public DataTable ListarUnidades()
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();

                    sql.Append("SELECT * FROM Unidade_produtos ");
                    sql.Append("ORDER BY NOME_UNIDADE_PRODUTOS ASC");

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    dadosTabela.Load(comandoSql.ExecuteReader());
                    return dadosTabela;
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método 'ListarUnidades'. Caso o erro persista, entre em contato com o Administrador do Sistema.");
            }
        }

        public void SalvarUnidade(string nome, string descricao)
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();

                    sql.Append("INSERT INTO Unidade_produtos(NOME_UNIDADE_PRODUTOS, DESCRICAO_UNIDADE_PRODUTOS) ");
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
                throw new Exception("Ocorreu um erro no método 'SalvarUnidade'. Caso o erro persista, entre em contato com o Administrador do Sistema.");
            }
        }

        public void AlterarUnidade(int idUnidade, string nome, string descricao)
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();

                    sql.Append("UPDATE Unidade_produtos ");
                    sql.Append("SET NOME_UNIDADE_PRODUTOS = @nome, DESCRICAO_UNIDADE_PRODUTOS = @descricao ");
                    sql.Append("WHERE ID_UNIDADE_PRODUTOS = @idUnidade");

                    comandoSql.Parameters.Add(new SqlParameter("@idUnidade", idUnidade));
                    comandoSql.Parameters.Add(new SqlParameter("@nome", nome));
                    comandoSql.Parameters.Add(new SqlParameter("@descricao", descricao));

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    comandoSql.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método 'AlterarUnidade'. Caso o erro persista, entre em contato com o Administrador do Sistema.");
            }
        }

        public void ExcluirUnidade(int idUnidade)
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();

                    sql.Append("DELETE FROM Unidade_produtos ");
                    sql.Append("WHERE ID_UNIDADE_PRODUTOS = @idUnidade");

                    comandoSql.Parameters.Add(new SqlParameter("@idUnidade", idUnidade));

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    comandoSql.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método 'ExcluirUnidade'. Caso o erro persista, entre em contato com o Administrador do Sistema.");
            }
        }

        public DataTable ListarProdutos()
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();

                    sql.Append("SELECT Produtos.ID_PRODUTO, Produtos.CODIGO_BARRAS_PRODUTO, Produtos.NOME_PRODUTO, Produtos.DESCRICAO_PRODUTO,");
                    sql.Append(" Produtos.ID_UNIDADE, Unidade_produtos.NOME_UNIDADE_PRODUTOS, Produtos.ID_CATEGORIA, Produtos.ESTOQUE_MINIMO, Produtos.ESTOQUE_ATUAL,");
                    sql.Append(" Produtos.VALOR_COMPRA, Produtos.VALOR_VENDA, Produtos.MARGEM, Produtos.ANOTACOES_PRODUTO, Produtos.SITUACAO_PRODUTO, Produtos.DATA_CADASTRO_PRODUTO");
                    sql.Append(" FROM (Produtos INNER JOIN Unidade_produtos ON Produtos.ID_UNIDADE = Unidade_produtos.ID_UNIDADE_PRODUTOS)");
                    sql.Append(" ORDER BY Produtos.NOME_PRODUTO ASC");

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    dadosTabela.Load(comandoSql.ExecuteReader());
                    return dadosTabela;
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método 'ListarProdutos'. Caso o erro persista, entre em contato com o Administrador do Sistema.");
            }
        }

        public void SalvarProduto(string codigoBarras, string nome, string descricao, int idUnidade, int idCategoria, int estoqueMinimo, 
                                  int estoqueAtual, decimal valorCompra, decimal valorVenda, decimal margemLucro, string anotacoes, 
                                  Boolean situacao, DateTime cadastro)
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();

                    sql.Append("INSERT INTO Produtos(CODIGO_BARRAS_PRODUTO, NOME_PRODUTO, DESCRICAO_PRODUTO, ID_UNIDADE, ID_CATEGORIA,");
                    sql.Append(" ESTOQUE_MINIMO, ESTOQUE_ATUAL, VALOR_COMPRA, VALOR_VENDA, MARGEM, ANOTACOES_PRODUTO, SITUACAO_PRODUTO, DATA_CADASTRO_PRODUTO) ");
                    sql.Append("VALUES (@codigoBarras, @nome, @descricao, @idUnidade, @idCategoria, @estoqueMinimo, @estoqueAtual, @valorCompra, @valorVenda, @margemLucro, @anotacoes, @situacao, @cadastro)");

                    comandoSql.Parameters.Add(new SqlParameter("@codigoBarras", codigoBarras));
                    comandoSql.Parameters.Add(new SqlParameter("@nome", nome));
                    comandoSql.Parameters.Add(new SqlParameter("@descricao", descricao));
                    comandoSql.Parameters.Add(new SqlParameter("@idUnidade", idUnidade));
                    comandoSql.Parameters.Add(new SqlParameter("@idCategoria", idCategoria));
                    comandoSql.Parameters.Add(new SqlParameter("@estoqueMinimo", estoqueMinimo));
                    comandoSql.Parameters.Add(new SqlParameter("@estoqueAtual", estoqueAtual));
                    comandoSql.Parameters.Add(new SqlParameter("@valorCompra",valorCompra));
                    comandoSql.Parameters.Add(new SqlParameter("@valorVenda", valorVenda));
                    comandoSql.Parameters.Add(new SqlParameter("@margemLucro", margemLucro));
                    comandoSql.Parameters.Add(new SqlParameter("@anotacoes", anotacoes));
                    comandoSql.Parameters.Add(new SqlParameter("@situacao", situacao));
                    comandoSql.Parameters.Add(new SqlParameter("@cadastro", cadastro));

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    comandoSql.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método 'SalvarProduto'. Caso o erro persista, entre em contato com o Administrador do Sistema.");
            }
        }

        public void AlterarProduto(int codigo, string codigoBarras, string nome, string descricao, int idUnidade, int idCategoria, int estoqueMinimo,
                                   int estoqueAtual, decimal valorCompra, decimal valorVenda, decimal margemLucro, string anotacoes,
                                   Boolean situacao, DateTime cadastro)
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();

                    sql.Append("UPDATE Produtos SET CODIGO_BARRAS_PRODUTO = @codigoBarras, NOME_PRODUTO = @nome, DESCRICAO_PRODUTO = @descricao, ID_UNIDADE = @idUnidade,");
                    sql.Append(" ID_CATEGORIA = @idCategoria, ESTOQUE_MINIMO = @estoqueMinimo, ESTOQUE_ATUAL = @estoqueAtual, VALOR_COMPRA = @valorCompra, VALOR_VENDA = @valorVenda,");
                    sql.Append(" MARGEM = @margemLucro, ANOTACOES_PRODUTO = @anotacoes, SITUACAO_PRODUTO = @situacao, DATA_CADASTRO_PRODUTO = @cadastro ");
                    sql.Append("WHERE ID_PRODUTO = @codigo");

                    comandoSql.Parameters.Add(new SqlParameter("@codigo", codigo));
                    comandoSql.Parameters.Add(new SqlParameter("@codigoBarras", codigoBarras));
                    comandoSql.Parameters.Add(new SqlParameter("@nome", nome));
                    comandoSql.Parameters.Add(new SqlParameter("@descricao", descricao));
                    comandoSql.Parameters.Add(new SqlParameter("@idUnidade", idUnidade));
                    comandoSql.Parameters.Add(new SqlParameter("@idCategoria", idCategoria));
                    comandoSql.Parameters.Add(new SqlParameter("@estoqueMinimo", estoqueMinimo));
                    comandoSql.Parameters.Add(new SqlParameter("@estoqueAtual", estoqueAtual));
                    comandoSql.Parameters.Add(new SqlParameter("@valorCompra", valorCompra));
                    comandoSql.Parameters.Add(new SqlParameter("@valorVenda", valorVenda));
                    comandoSql.Parameters.Add(new SqlParameter("@margemLucro", margemLucro));
                    comandoSql.Parameters.Add(new SqlParameter("@anotacoes", anotacoes));
                    comandoSql.Parameters.Add(new SqlParameter("@situacao", situacao));
                    comandoSql.Parameters.Add(new SqlParameter("@cadastro", cadastro));

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    comandoSql.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método 'AlterarProduto'. Caso o erro persista, entre em contato com o Administrador do Sistema.");
            }
        }

        public void ExcluirProduto(int codigo)
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();

                    sql.Append("DELETE FROM Produtos ");
                    sql.Append("WHERE ID_PRODUTO = @codigo");

                    comandoSql.Parameters.Add(new SqlParameter("@codigo", codigo));

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    comandoSql.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método 'ExcluirProduto'. Caso o erro persista entre em contato com o Administrador do Sistema.");
            }
        }

        public DataTable PesquisarCodigoBarras(string codigoBarras)
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();

                    sql.Append("SELECT Produtos.ID_PRODUTO, Produtos.CODIGO_BARRAS_PRODUTO, Produtos.NOME_PRODUTO, Produtos.DESCRICAO_PRODUTO,");
                    sql.Append(" Produtos.ID_UNIDADE, Unidade_produtos.NOME_UNIDADE_PRODUTOS, Produtos.ID_CATEGORIA, Produtos.ESTOQUE_MINIMO,");
                    sql.Append(" Produtos.ESTOQUE_ATUAL, Produtos.VALOR_COMPRA, Produtos.VALOR_VENDA, Produtos.MARGEM, Produtos.ANOTACOES_PRODUTO,");
                    sql.Append(" Produtos.SITUACAO_PRODUTO, Produtos.DATA_CADASTRO_PRODUTO ");
                    sql.Append("FROM Produtos INNER JOIN Unidade_produtos ON Produtos.ID_UNIDADE = Unidade_produtos.ID_UNIDADE_PRODUTOS ");
                    sql.Append("WHERE Produtos.CODIGO_BARRAS_PRODUTO LIKE '%'+@codigoBarras+'%' ");
                    sql.Append("ORDER BY Produtos.NOME_PRODUTO");

                    comandoSql.Parameters.Add(new SqlParameter("@codigoBarras", codigoBarras));

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    dadosTabela.Load(comandoSql.ExecuteReader());
                    return dadosTabela;
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método 'PesquisarCodigoBarras'. Caso o erro persista, entre em contato com o Administrador do Sistema.");
            }
        }
    }
}