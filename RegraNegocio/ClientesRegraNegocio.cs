using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegraNegocio
{
    public class ClientesRegraNegocio
    {
        AcessoDados.ClientesAcessoDados novoCliente = new AcessoDados.ClientesAcessoDados();
        DataTable dadosTabela = new DataTable();

        public DataTable Listar()
        {
            try
            {
                return novoCliente.Listar();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable ListarPessoaFisica(int idCliente)
        {
            try
            {
                return novoCliente.ListarPessoaFisica(idCliente);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable ListarPessoaJuridica(int idCliente)
        {
            try
            {
                return novoCliente.ListarPessoaJuridica(idCliente);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Salvar(string nome, string endereco, string bairro, string cep, string cidade, string estado, string telefone1,
                           string telefone2, string email, DateTime dataCadastro, DateTime nascimento, string observacoes)
        {
            try
            {
                novoCliente.Salvar(nome, endereco, bairro, cep, cidade, estado, telefone1, telefone2, email, dataCadastro, nascimento, observacoes);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void SalvarPessoaFisica(int idCliente, string cpf, string rg)
        {
            try
            {
                novoCliente.SalvarPessoaFísica(idCliente, cpf, rg);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void SalvarPessoaJuridica(int idCliente, string cnpj, string ie)
        {
            try
            {
                novoCliente.SalvarPessoaJuridica(idCliente, cnpj, ie);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Alterar(int idCliente, string nome, string endereco, string bairro, string cep, string cidade, string estado, string telefone1, string telefone2,
                            string email, DateTime dataCadastro, DateTime nascimento, string observacoes)
        {
            try
            {
                novoCliente.Alterar(idCliente, nome, endereco, bairro, cep, cidade, estado, telefone1, 
                                    telefone2, email, dataCadastro, nascimento, observacoes);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void AlterarPessoaFisica(int idCliente, string cpf, string rg)
        {
            try
            {
                novoCliente.AlterarPessoaFisica(idCliente, cpf, rg);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void AlterarPessoaJuridica(int idCliente, string cnpj, string ie)
        {
            try
            {
                novoCliente.AlterarPessoaJuridica(idCliente, cnpj, ie);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Excluir(int idCliente)
        {
            try
            {
                novoCliente.Excluir(idCliente);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable PesquisaNome(string nome)
        {
            try
            {
                return novoCliente.PesquisaNome(nome);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable PesquisaCpf(string cpf)
        {
            try
            {
                return novoCliente.PesquisaCpf(cpf);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable PesquisaCnpj(string cnpj)
        {
            try
            {
                return novoCliente.PesquisaCnpj(cnpj);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
