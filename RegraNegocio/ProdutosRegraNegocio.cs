using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegraNegocio
{
    public class ProdutosRegraNegocio
    {
        AcessoDados.ProdutosAcessoDados novoProduto = new AcessoDados.ProdutosAcessoDados();
        DataTable dadosTabela = new DataTable();

        //Formulário de Cadastro de Categorias.
        public DataTable ListarCategorias()
        {
            try
            {
                return novoProduto.ListarCategorias();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void SalvarCategoria(string nome, string descricao)
        {
            try
            {
                novoProduto.SalvarCategoria(nome, descricao);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void AlterarCategoria(int idCategoria, string nome, string descricao)
        {
            try
            {
                novoProduto.AlterarCategoria(idCategoria, nome, descricao);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void ExcluirCategoria(int idCategoria)
        {
            try
            {
                novoProduto.ExcluirCategoria(idCategoria);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Formulário de Cadastro de Unidades.
        public DataTable ListarUnidades()
        {
            try
            {
                return novoProduto.ListarUnidades();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void SalvarUnidade(string nome, string descricao)
        {
            try
            {
                novoProduto.SalvarUnidade(nome, descricao);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void AlterarUnidade(int idUnidade, string nome, string descricao)
        {
            try
            {
                novoProduto.AlterarUnidade(idUnidade, nome, descricao);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void ExcluirUnidade(int idUnidade)
        {
            try
            {
                novoProduto.ExcluirUnidade(idUnidade);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Formulário de Cadastro de Produtos.
        public DataTable ListarProdutos()
        {
            try
            {
                return novoProduto.ListarProdutos();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Validar(string codigoBarras, string nome, string descricao, int idUnidade, int idCategoria, int estoqueMinimo,
                            int estoqueAtual, decimal valorCompra, decimal valorVenda, decimal margemLucro)
        {
            if (codigoBarras.Trim().Length == 0)
            {
                throw new Exception("O campo Código de Barras deve ser preenchido!");
            }
            if (nome.Trim().Length == 0)
            {
                throw new Exception("O campo Nome deve ser preenchido!");
            }
            if (descricao.Trim().Length == 0)
            {
                throw new Exception("O campo Descrição deve ser preenchido!");
            }
            if (idCategoria == 0)
            {
                throw new Exception("O produto deve possuir uma Categoria!");
            }
            if (estoqueMinimo == 0)
            {
                throw new Exception("O campo Estoque Mínimo não pode estar vazio!");
            }
            if (estoqueAtual == 0)
            {
                throw new Exception("O campo Estoque Atual não pode estar vazio!");
            }
            if (idUnidade == 0)
            {
                throw new Exception("O produto deve possuir uma Unidade!");
            }
            if (valorCompra == 0)
            {
                throw new Exception("O campo Custo não pode estar vazio!");
            }
            if (margemLucro == 0)
            {
                throw new Exception("O campo Margem de Lucro não pode estar vazio!");
            }
            if (valorVenda == 0)
            {
                throw new Exception("O campo Venda não pode estar vazio!");
            }
        }

        public void SalvarProduto(string codigoBarras, string nome, string descricao, int idUnidade, int idCategoria, int estoqueMinimo,
                                  int estoqueAtual, decimal valorCompra, decimal valorVenda, decimal margemLucro, string anotacoes,
                                  Boolean situacao, DateTime cadastro)
        {
            try
            {
                Validar(codigoBarras, nome, descricao, idUnidade, idCategoria, estoqueMinimo, estoqueAtual, valorCompra, valorVenda, margemLucro);

                dadosTabela = novoProduto.PesquisarCodigoBarras(codigoBarras);
                if (dadosTabela.Rows.Count > 0)
                {
                    throw new Exception("O produto '" + dadosTabela.Rows[0]["NOME_PRODUTO"] + "' já foi cadastrado com esse código de barras!");
                }
                else
                {
                    AcessoDados.ProdutosAcessoDados novoProduto = new AcessoDados.ProdutosAcessoDados();

                    novoProduto.SalvarProduto(codigoBarras, nome, descricao, idUnidade, idCategoria, estoqueMinimo, estoqueAtual, valorCompra,
                                              valorVenda, margemLucro, anotacoes, situacao, cadastro); 
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void AlterarProduto(int codigo, string codigoBarras, string nome, string descricao, int idUnidade, int idCategoria,
                                   int estoqueMinimo, int estoqueAtual, decimal valorCompra, decimal valorVenda, decimal margemLucro,
                                   string anotacoes, Boolean situacao, DateTime cadastro)
        {
            try
            {
                Validar(codigoBarras, nome, descricao, idUnidade, idCategoria, estoqueMinimo, estoqueAtual, valorCompra, valorVenda, margemLucro);

                dadosTabela = novoProduto.PesquisarCodigoBarras(codigoBarras);
                if (dadosTabela.Rows.Count > 0)
                {
                    if (codigo == Convert.ToInt32(dadosTabela.Rows[0]["ID_PRODUTO"]))
                    {
                        AcessoDados.ProdutosAcessoDados novoProduto = new AcessoDados.ProdutosAcessoDados();

                        novoProduto.AlterarProduto(codigo, codigoBarras, nome, descricao, idUnidade, idCategoria, estoqueMinimo, estoqueAtual,
                                              valorCompra, valorVenda, margemLucro, anotacoes, situacao, cadastro);
                    }
                    else
                    {
                        throw new Exception("O produto '" + dadosTabela.Rows[0]["NOME_PRODUTO"] + "' já foi cadastrado com esse código de barras!");
                    }
                }
                else
                {
                    AcessoDados.ProdutosAcessoDados novoProduto = new AcessoDados.ProdutosAcessoDados();

                    novoProduto.AlterarProduto(codigo, codigoBarras, nome, descricao, idUnidade, idCategoria, estoqueMinimo, estoqueAtual,
                                          valorCompra, valorVenda, margemLucro, anotacoes, situacao, cadastro);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void ExcluirProduto(int codigo)
        {
            try
            {
                novoProduto.ExcluirProduto(codigo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
