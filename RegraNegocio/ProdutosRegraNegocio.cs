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

        public void SalvarProduto(string codigoBarras, string nome, string descricao, int idUnidade, int idCategoria, int estoqueMinimo,
                                  int estoqueAtual, decimal valorCompra, decimal valorVenda, decimal margemLucro, string anotacoes,
                                  Boolean situacao, DateTime cadastro)
        {
            try
            {
                novoProduto.SalvarProduto(codigoBarras, nome, descricao, idUnidade, idCategoria, estoqueMinimo, estoqueAtual, valorCompra,
                                          valorVenda,margemLucro, anotacoes, situacao, cadastro);
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
                novoProduto.AlterarProduto(codigo, codigoBarras, nome, descricao, idUnidade, idCategoria, estoqueMinimo, estoqueAtual, 
                                           valorCompra, valorVenda, margemLucro, anotacoes, situacao, cadastro);
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
