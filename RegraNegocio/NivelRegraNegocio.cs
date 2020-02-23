using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegraNegocio
{
    public class NivelRegraNegocio
    {
        DataTable dadosTabela = new DataTable();
        AcessoDados.NivelAcessoDados nivelAD = new AcessoDados.NivelAcessoDados();

        public DataTable Listar()
        {
            try
            {
                return nivelAD.Listar();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Validar(string nome)
        {
            if (nome.Trim().Length == 0)
            {
                throw new Exception("O campo 'Nome' deve ser preenchido)");
            }
        }

        public void Salvar(string nome, string descricao)
        {
            try
            {
                Validar(nome);
                dadosTabela = nivelAD.RetornaNivel(nome);

                if (dadosTabela.Rows.Count == 0)
                {
                    AcessoDados.NivelAcessoDados nivelAD = new AcessoDados.NivelAcessoDados();
                    nivelAD.Salvar(nome, descricao); 
                }
                else
                {
                    throw new Exception("Esse nível já foi cadastrado!");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Alterar(int idNivel, string nome, string descricao)
        {
            try
            {
                Validar(nome);
                dadosTabela = nivelAD.RetornaNivel(nome);

                if (dadosTabela.Rows.Count == 0)
                {
                    AcessoDados.NivelAcessoDados nivelAD = new AcessoDados.NivelAcessoDados();
                    nivelAD.Alterar(idNivel, nome, descricao); 
                }
                else if (Convert.ToInt32(dadosTabela.Rows[0]["ID_NIVEL"]) == idNivel)
                {
                    AcessoDados.NivelAcessoDados nivelAD = new AcessoDados.NivelAcessoDados();
                    nivelAD.Alterar(idNivel, nome, descricao);
                }
                else
                {
                    throw new Exception("Esse nível já foi cadastrado!");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Excluir(int idNivel)
        {
            try
            {
                nivelAD.Excluir(idNivel);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
