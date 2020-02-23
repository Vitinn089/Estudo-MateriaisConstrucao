using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegraNegocio
{
    public class UsuarioRegraNegocio
    {
        DataTable dadosTabela = new DataTable();
        AcessoDados.UsuarioAcessoDados usuarioAD = new AcessoDados.UsuarioAcessoDados();

        public DataTable Listar()
        {
            try
            {
                return usuarioAD.Listar();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Validar(string nome, string login, string senha, string redigite, string status, int idNivel)
        {
            if (nome.Trim().Length == 0)
            {
                throw new Exception("O campo 'Nome' deve ser preenchido!");
            }
            if (login.Trim().Length == 0)
            {
                throw new Exception("O campo 'Login' deve ser preenchido!");
            }
            if (senha.Trim().Length == 0)
            {
                throw new Exception("O campo 'Senha' deve ser preenchido!");
            }
            if (redigite.Trim().Length == 0)
            {
                throw new Exception("O campo 'Redigite' deve ser preenchido!");
            }
            if (status.Trim().Length == 0)
            {
                throw new Exception("O box 'Status' deve ser preenchido!");
            }
            if (idNivel == 0)
            {
                throw new Exception("O box 'Nível' deve ser preenchido!");
            }
            if (senha != redigite)
            {
                throw new Exception("Os campos 'Senha' e 'Redigite' não coincidem!");
            }
        }

        public void Salvar(string nome, DateTime cadastro, string login, string senha, string status, int idNivel, string redigite)
        {
            try
            {
                Validar(nome, login, senha, redigite, status, idNivel);
                dadosTabela = usuarioAD.RetornarLogin(login);

                if (dadosTabela.Rows.Count == 0)
                {
                    AcessoDados.UsuarioAcessoDados usuarioAD = new AcessoDados.UsuarioAcessoDados();
                    usuarioAD.Salvar(nome, cadastro, login, senha, status, idNivel);
                }
                else
                {
                    throw new Exception("Esse login ja existe!");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Alterar(int idUsuario, string nome, string login, string senha, string redigite, string status, int idNivel)
        {
            try
            {
                Validar(nome, login, senha, redigite, status, idNivel);
                dadosTabela = usuarioAD.RetornarLogin(login);

                if (dadosTabela.Rows.Count == 0)
                {
                    AcessoDados.UsuarioAcessoDados usuarioAD = new AcessoDados.UsuarioAcessoDados();
                    usuarioAD.Alterar(idUsuario, nome, login, senha, status, idNivel);
                }
                else if (Convert.ToInt32(dadosTabela.Rows[0]["ID_USUARIO"]) == idUsuario)
                {
                    AcessoDados.UsuarioAcessoDados usuarioAD = new AcessoDados.UsuarioAcessoDados();
                    usuarioAD.Alterar(idUsuario, nome, login, senha, status, idNivel);
                }
                else
                {
                    throw new Exception("Esse login ja existe!");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Excluir(int idUsuario)
        {
            try
            {
                usuarioAD.Excluir(idUsuario);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable Login(string login, string senha)
        {
            try
            {
                return usuarioAD.Login(login, senha);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable RetornaUsuario(int idUsuario)
        {
            try
            {
                return usuarioAD.RetornarUsuario(idUsuario);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
