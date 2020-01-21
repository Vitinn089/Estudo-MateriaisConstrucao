using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegraNegocio
{
    public class FuncionariosRegraNegocio
    {
        AcessoDados.FuncionariosAcessoDados novoFuncionario = new AcessoDados.FuncionariosAcessoDados();
        DataTable dadosTabela = new DataTable();

        public void Validar(string nome, string rg, string cpf, string telefone, string endereco, string bairro, string cep, 
                            string cidade, string email, DateTime nascimento)
        {
            if (nome.Trim().Length == 0)
            {
                throw new Exception("O campo 'Nome' deve ser preenchido!");
            }
            if (rg.Trim().Length == 0)
            {
                throw new Exception("O campo 'RG' deve ser preenchido!");
            }
            if (cpf.Replace("-","").Replace(".","").Replace(" ","").Length == 0)
            {
                throw new Exception("O campo 'CPF' deve ser preenchido!");
            }
            if (telefone.Replace("(","").Replace(")","").Replace("-","").Replace(" ","").Length == 0)
            {
                throw new Exception("O campo 'Telefone 1' deve ser preenchido!");
            }
            if (endereco.Trim().Length == 0)
            {
                throw new Exception("O campo 'Endereço' deve ser preenchido!");
            }
            if (bairro.Trim().Length == 0)
            {
                throw new Exception("O campo 'Bairro' deve ser preenchido!");
            }
            if (cep.Trim().Length == 0)
            {
                throw new Exception("O campo 'CEP' deve ser preenchido!");
            }
            if (cidade.Trim().Length == 0)
            {
                throw new Exception("O campo 'Cidade' deve ser preenchido!");
            }
            if (email.Trim().Length == 0)
            {
                throw new Exception("O campo 'Email' deve ser preenchido!");
            }
            if (nascimento == DateTime.Today.Date)
            {
                throw new Exception("O campo 'Nascimento' não pode ser hoje!");
            }
        }

        public void Salvar(string nome, string endereco, string bairro, string cep, string cidade, string email,
                           DateTime nascimento, string telefone1, string telefone2, string rg, string cpf,
                           string observacoes, DateTime dataCadastro)
        {
            try
            {
                Validar(nome, rg, cpf, telefone1, endereco, bairro, cep, cidade, email, nascimento);
                dadosTabela = PesquisarCpf(cpf);

                if (dadosTabela.Rows.Count == 0)
                {
                    AcessoDados.FuncionariosAcessoDados novoFuncionario = new AcessoDados.FuncionariosAcessoDados();

                    novoFuncionario.Salvar(nome, endereco, bairro, cep, cidade, email, nascimento, telefone1, telefone2,
                                                   rg, cpf, observacoes, dataCadastro); 
                }
                else
                {
                    throw new Exception("Esse CPF já foi cadastrado!");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable Listar()
        {
            try
            {
                return novoFuncionario.Listar();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Alterar(int idFuncionario, string nome, string endereco, string bairro, string cep,
                            string cidade, string email, DateTime nascimento, string telefone1, string telefone2,
                            string rg, string cpf, string observacoes, DateTime dataCadastro)
         {
            try
            {
                Validar(nome, rg, cpf, telefone1, endereco, bairro, cep, cidade, email, nascimento);
                dadosTabela = PesquisarCpf(cpf);

                if(dadosTabela.Rows.Count > 0)
                {
                    if (Convert.ToInt32(dadosTabela.Rows[0]["ID_FUNCIONARIO"]) == idFuncionario)
                    {
                        AcessoDados.FuncionariosAcessoDados novoFuncionario = new AcessoDados.FuncionariosAcessoDados();

                        novoFuncionario.Alterar(idFuncionario, nome, endereco, bairro, cep, cidade, email, nascimento, telefone1,
                                                telefone2, rg, cpf, observacoes, dataCadastro); 
                    }
                    else
                    {
                        throw new Exception("Esse CPF já foi cadastrado!");
                    }
                }
                else
                {
                    AcessoDados.FuncionariosAcessoDados novoFuncionario = new AcessoDados.FuncionariosAcessoDados();

                    novoFuncionario.Alterar(idFuncionario, nome, endereco, bairro, cep, cidade, email, nascimento, telefone1,
                                                                        telefone2, rg, cpf, observacoes, dataCadastro);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Excluir(int idFuncionario)
        {
            try
            {
                novoFuncionario.Excluir(idFuncionario);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable PesquisarNome(string nome)
        {
            try
            {
               return novoFuncionario.PesquisarNome(nome);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable PesquisarCpf(string cpf)
        {
            try
            {
                return novoFuncionario.PesquisarCpf(cpf);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
