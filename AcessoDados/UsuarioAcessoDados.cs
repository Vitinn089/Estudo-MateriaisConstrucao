using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessoDados
{
    public class UsuarioAcessoDados
    {
        SqlCommand comandoSql = new SqlCommand();
        StringBuilder sql = new StringBuilder();
        DataTable dadosTabela = new DataTable();

        public DataTable Listar()
        {
            try
            {
                using (SqlConnection cnx = new SqlConnection(Conexao.stringConexao))
                {
                    cnx.Open();

                    sql.Append("SELECT Usuarios.*, NOME_NIVEL");
                    sql.Append(" FROM Usuarios INNER JOIN Nivel_Acesso ON Usuarios.ID_NIVEL = Nivel_Acesso.ID_NIVEL");

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = cnx;
                    dadosTabela.Load(comandoSql.ExecuteReader());
                    return dadosTabela;
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método 'Listar'. Caso o erro persista, entre em contato com o Administrador do Sistema.");
            }
        }

        public void Salvar(string nome, DateTime cadastro, string login, string senha, string status, int idNivel)
        {
            try
            {
                using (SqlConnection cnx = new SqlConnection(Conexao.stringConexao))
                {
                    cnx.Open();

                    sql.Append("INSERT INTO Usuarios (NOME_USUARIO, DATA_CADASTRO, LOGIN_USUARIO, SENHA_USUARIO, STATUS_USUARIO, ID_NIVEL)");
                    sql.Append(" VALUES (@nome, @cadastro, @login, @senha, @status, @idNivel)");

                    comandoSql.Parameters.Add(new SqlParameter("@nome", nome));
                    comandoSql.Parameters.Add(new SqlParameter("@cadastro", cadastro));
                    comandoSql.Parameters.Add(new SqlParameter("@login", login));
                    comandoSql.Parameters.Add(new SqlParameter("@senha", senha));
                    comandoSql.Parameters.Add(new SqlParameter("@status", status));
                    comandoSql.Parameters.Add(new SqlParameter("@idNivel", idNivel));

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = cnx;
                    comandoSql.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método 'Salvar'. Caso o erro persista, entre em contato com o Administrador do Sistema.");
            }
        }

        public void Alterar(int idUsuario, string nome, string login, string senha, string status, int idNivel)
        {
            try
            {
                using (SqlConnection cnx = new SqlConnection(Conexao.stringConexao))
                {
                    cnx.Open();

                    sql.Append("UPDATE Usuarios SET NOME_USUARIO = @nome, LOGIN_USUARIO = @login, SENHA_USUARIO = @senha,");
                    sql.Append(" STATUS_USUARIO = @status, ID_NIVEL = @idNivel ");
                    sql.Append("WHERE ID_USUARIO = @idUsuario");

                    comandoSql.Parameters.Add(new SqlParameter("@idUsuario", idUsuario));
                    comandoSql.Parameters.Add(new SqlParameter("@nome", nome));
                    comandoSql.Parameters.Add(new SqlParameter("@login", login));
                    comandoSql.Parameters.Add(new SqlParameter("@senha", senha));
                    comandoSql.Parameters.Add(new SqlParameter("@status", status));
                    comandoSql.Parameters.Add(new SqlParameter("@idNivel", idNivel));

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = cnx;
                    comandoSql.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {

                throw new Exception("Ocorreu um erro no método 'Alterar'. Caso o erro persista, entre em contato com o Administrador do Sistema.");
            }
        }
        
        public void Excluir(int idUsuario)
        {
            try
            {
                using (SqlConnection cnx = new SqlConnection(Conexao.stringConexao))
                {
                    cnx.Open();

                    sql.Append("DELETE FROM Usuarios ");
                    sql.Append("WHERE ID_USUARIO = @idUsuario");

                    comandoSql.Parameters.Add(new SqlParameter("@idUsuario", idUsuario));

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = cnx;
                    comandoSql.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método 'Excluir'. Caso o erro persista, entre em contato com o Administrador do Sistema.");
            }
        }

        public DataTable Login(string login, string senha)
        {
            try
            {
                using (SqlConnection cnx = new SqlConnection(Conexao.stringConexao))
                {
                    cnx.Open();

                    sql.Append("SELECT * FROM Usuarios ");
                    sql.Append("WHERE LOGIN_USUARIO = @login AND SENHA_USUARIO = @senha");

                    comandoSql.Parameters.Add(new SqlParameter("@login", login));
                    comandoSql.Parameters.Add(new SqlParameter("@senha", senha));

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = cnx;
                    dadosTabela.Load(comandoSql.ExecuteReader());
                    return dadosTabela;
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método 'Login'. Caso o erro persista, entre em contato com o Administrador do Sistema.");
            }
        }

        public DataTable RetornarLogin(string login)
        {
            try
            {
                using (SqlConnection cnx = new SqlConnection(Conexao.stringConexao))
                {
                    cnx.Open();

                    sql.Append("SELECT * FROM Usuarios ");
                    sql.Append("WHERE LOGIN_USUARIO = @login ORDER BY ID_USUARIO ASC");

                    comandoSql.Parameters.Add(new SqlParameter("@login", login));

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = cnx;
                    dadosTabela.Load(comandoSql.ExecuteReader());
                    return dadosTabela;
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método 'RetornarLogin', caso o erro persista, entre em contato com o Administrador do Sistema.");
            }
        }

        public DataTable RetornarUsuario(int idUsuario)
        {
            try
            {
                using (SqlConnection cnx = new SqlConnection(Conexao.stringConexao))
                {
                    cnx.Open();

                    sql.Append("SELECT Usuarios.*, NOME_NIVEL FROM Usuarios INNER JOIN Nivel_Acesso ON Usuarios.ID_NIVEL = Nivel_Acesso.ID_NIVEL ");
                    sql.Append("WHERE ID_USUARIO = @idUsuario");

                    comandoSql.Parameters.Add(new SqlParameter("@idUsuario", idUsuario));

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = cnx;
                    dadosTabela.Load(comandoSql.ExecuteReader());
                    return dadosTabela;
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método 'RetornaUsuario'. Caso o erro persista, entre em contato com o Administrador do Sistema.");
            }
        }
    }
}
