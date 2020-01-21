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

        public void Validar(string nome, string endereco, string bairro, string cep, string cidade, string estado, string telefone, string email,
                             DateTime nascimento)
        {
            if (nome.Trim().Length == 0)
            {
                throw new Exception("O campo 'Nome' deve ser preenchido!");
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
            if (estado.Trim().Length == 0)
            {
                throw new Exception("O campo 'Estado' deve ser preenchido!");
            }
            if (telefone.Replace("(","").Replace(")","").Replace("-","").Replace(" ","").Length == 0)
            {
                throw new Exception("O campo 'Telefone1' deve ser preenchido!");
            }
            if (email.Trim().Length == 0)
            {
                throw new Exception("O campo 'Email' deve ser preenchido!");
            }
            if (nascimento == DateTime.Today.Date)
            {
                throw new Exception("O campo 'Endereço' deve ser preenchido!");
            }
        }

        public void Salvar(string nome, string endereco, string bairro, string cep, string cidade, string estado, string telefone1,
                           string telefone2, string email, DateTime dataCadastro, DateTime nascimento, string observacoes, string cpf,
                           string cnpj, Boolean pF)
        {
            try
            {
                Validar(nome, endereco, bairro, cep, cidade, estado, telefone1, email, nascimento);

                if (pF == true)
                {
                    dadosTabela = PesquisaCpf(cpf);

                    if (dadosTabela.Rows.Count == 0)
                    {
                        AcessoDados.ClientesAcessoDados novoCliente = new AcessoDados.ClientesAcessoDados();

                        novoCliente.Salvar(nome, endereco, bairro, cep, cidade, estado, telefone1, telefone2, email, dataCadastro, nascimento, observacoes);  
                    }
                    else
                    {
                        throw new Exception("Esse CPF já foi cadastrado!");
                    }
                }
                else
                {
                    dadosTabela = PesquisaCnpj(cnpj);

                    if (dadosTabela.Rows.Count == 0)
                    {
                        AcessoDados.ClientesAcessoDados novoCliente = new AcessoDados.ClientesAcessoDados();

                        novoCliente.Salvar(nome, endereco, bairro, cep, cidade, estado, telefone1, telefone2, email, dataCadastro, nascimento, observacoes);
                    }
                    else
                    {
                        throw new Exception("Esse CNPJ já foi cadastrado!");
                    }
                }
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
                if (cpf.Replace(".","").Replace("-","").Replace(" ","").Length != 0 && rg.Trim().Length != 0)
                {
                    novoCliente.SalvarPessoaFísica(idCliente, cpf, rg); 
                }
                else
                {
                    throw new Exception("Os campos 'CPF' e 'RG' devem ser preenchidos!");
                }
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
                if (cnpj.Replace(".","").Replace("-","").Replace("/","").Replace(" ","").Length != 0 && ie.Trim().Length != 0)
                {
                    novoCliente.SalvarPessoaJuridica(idCliente, cnpj, ie); 
                }
                else
                {
                    throw new Exception("Os campos 'IE' e 'CNPJ' devem ser preenchidos!");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Alterar(int idCliente, string nome, string endereco, string bairro, string cep, string cidade, string estado, string telefone1, string telefone2,
                            string email, DateTime dataCadastro, DateTime nascimento, string observacoes, string cpf, string cnpj, Boolean pF)
        {
            try
            {
                Validar(nome, endereco, bairro, cep, cidade, estado, telefone1, email, nascimento);

                if (pF == true)
                {
                    dadosTabela = PesquisaCpf(cpf);

                    if (dadosTabela.Rows.Count > 0)
                    {
                        if (idCliente == Convert.ToInt32(dadosTabela.Rows[0]["ID_CLIENTE"]))
                        {
                            AcessoDados.ClientesAcessoDados novoCliente = new AcessoDados.ClientesAcessoDados();

                            novoCliente.Alterar(idCliente, nome, endereco, bairro, cep, cidade, estado, telefone1,
                                                telefone2, email, dataCadastro, nascimento, observacoes); 
                        }
                        else
                        {
                            throw new Exception("Esse CPF já foi cadastrado!");
                        }
                    }
                    else
                    {
                        AcessoDados.ClientesAcessoDados novoCliente = new AcessoDados.ClientesAcessoDados();

                        novoCliente.Alterar(idCliente, nome, endereco, bairro, cep, cidade, estado, telefone1,
                                            telefone2, email, dataCadastro, nascimento, observacoes);
                    }
                }
                else
                {
                    dadosTabela = PesquisaCnpj(cnpj);

                    if (dadosTabela.Rows.Count > 0)
                    {
                        if (Convert.ToInt32(dadosTabela.Rows[0]["ID_CLIENTE"]) == idCliente)
                        {
                            AcessoDados.ClientesAcessoDados novoCliente = new AcessoDados.ClientesAcessoDados();

                            novoCliente.Alterar(idCliente, nome, endereco, bairro, cep, cidade, estado, telefone1,
                                                telefone2, email, dataCadastro, nascimento, observacoes);
                        }
                        else
                        {
                            throw new Exception("Esse CNPJ já foi cadastrado!");
                        }
                    }
                    else
                    {
                        AcessoDados.ClientesAcessoDados novoCliente = new AcessoDados.ClientesAcessoDados();

                        novoCliente.Alterar(idCliente, nome, endereco, bairro, cep, cidade, estado, telefone1,
                                            telefone2, email, dataCadastro, nascimento, observacoes);
                    }
                }
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
