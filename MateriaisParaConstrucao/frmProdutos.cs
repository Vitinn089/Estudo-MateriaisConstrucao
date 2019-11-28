using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MateriaisParaConstrucao
{
    public partial class frmProdutos : Form
    {
        public frmProdutos()
        {
            InitializeComponent();
        }

        Produtos novoProduto;

        private void frmProdutos_Load(object sender, EventArgs e)
        {
            ListarCategoria();
            ListarUnidade();
            Listar();
            cboCategoria.SelectedValue = -1;
            cboUnidade.SelectedValue = -1;
        }

        private void Estilo()
        {
            for (int i = 0; i < dtgListaProdutos.Rows.Count; i += 2)
            {
                dtgListaProdutos.Rows[i].DefaultCellStyle.BackColor = Color.Honeydew;
            }
        }

        private void Listar()
        {
            try
            {
                novoProduto = new Produtos();

                dtgListaProdutos.DataSource = novoProduto.ListarProdutos();
                Estilo();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Limpar()
        {
            txtCodigo.Text = "0";
            txtCodigoBarras.Clear();
            txtNome.Clear();
            dtpCadastro.Value = DateTime.Today;
            cbAtivo.Checked = true;
            txtDescricao.Clear();
            cboCategoria.SelectedIndex = -1;
            txtEstoqueAtual.Clear();
            txtEstoqueMinimo.Clear();
            cboUnidade.SelectedIndex = -1;
            txtCusto.Clear();
            txtMargemLucro.Clear();
            txtVenda.Clear();
            txtAnotacoes.Clear();
        }

        private void ListarCategoria()
        {
            try
            {
                novoProduto = new Produtos();

                cboCategoria.DataSource = novoProduto.ListarCategorias();
                cboCategoria.DisplayMember = "NOME_CATEGORIA_PRODUTOS";
                cboCategoria.ValueMember = "ID_CATEGORIA_PRODUTOS";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListarUnidade()
        {
            try
            {
                novoProduto = new Produtos();

                cboUnidade.DataSource = novoProduto.ListarUnidades();
                cboUnidade.DisplayMember = "NOME_UNIDADE_PRODUTOS";
                cboUnidade.ValueMember = "ID_UNIDADE_PRODUTOS";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            frmCategorias formCategoria = new frmCategorias();
            formCategoria.ShowDialog();
        }

        private void btnUnidade_Click(object sender, EventArgs e)
        {
            frmUnidades formUnidades = new frmUnidades();
            formUnidades.ShowDialog();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                novoProduto = new Produtos();

                if (txtCodigo.Text == "0")
                {
                    novoProduto.SalvarProduto(txtCodigoBarras.Text, txtNome.Text, txtDescricao.Text, Convert.ToInt32(cboUnidade.SelectedValue),
                                              Convert.ToInt32(cboCategoria.SelectedValue), Convert.ToInt32(txtEstoqueMinimo.Text), Convert.ToInt32(txtEstoqueAtual.Text),
                                              Convert.ToDecimal(txtCusto.Text), Convert.ToDecimal(txtVenda.Text), Convert.ToDecimal(txtMargemLucro.Text),
                                              txtAnotacoes.Text, cbAtivo.Checked, dtpCadastro.Value.Date);
                    MessageBox.Show("Produto cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    novoProduto.AlterarProduto(Convert.ToInt32(txtCodigo.Text), txtCodigoBarras.Text, txtNome.Text, txtDescricao.Text, Convert.ToInt32(cboUnidade.SelectedValue),
                                               Convert.ToInt32(cboCategoria.SelectedValue), Convert.ToInt32(txtEstoqueMinimo.Text), Convert.ToInt32(txtEstoqueAtual.Text),
                                               Convert.ToDecimal(txtCusto.Text), Convert.ToDecimal(txtVenda.Text), Convert.ToDecimal(txtMargemLucro.Text),
                                               txtAnotacoes.Text, cbAtivo.Checked, dtpCadastro.Value.Date);
                        MessageBox.Show("Produto alterado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                Limpar();
                Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtgListaProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    if (dtgListaProdutos.Columns[e.ColumnIndex].Name == "btnEditar")
                    {
                        txtCodigo.Text = dtgListaProdutos.Rows[e.RowIndex].Cells["ID_PRODUTO"].Value.ToString();
                        txtCodigoBarras.Text = dtgListaProdutos.Rows[e.RowIndex].Cells["CODIGO_BARRAS_PRODUTO"].Value.ToString();
                        txtNome.Text = dtgListaProdutos.Rows[e.RowIndex].Cells["NOME_PRODUTO"].Value.ToString();
                        txtDescricao.Text = dtgListaProdutos.Rows[e.RowIndex].Cells["DESCRICAO_PRODUTO"].Value.ToString();
                        cboUnidade.SelectedValue = dtgListaProdutos.Rows[e.RowIndex].Cells["ID_UNIDADE"].Value.ToString();
                        cboCategoria.SelectedValue = dtgListaProdutos.Rows[e.RowIndex].Cells["ID_CATEGORIA"].Value.ToString();
                        txtEstoqueMinimo.Text = dtgListaProdutos.Rows[e.RowIndex].Cells["ESTOQUE_MINIMO"].Value.ToString();
                        txtEstoqueAtual.Text = dtgListaProdutos.Rows[e.RowIndex].Cells["ESTOQUE_ATUAL"].Value.ToString();
                        txtCusto.Text = dtgListaProdutos.Rows[e.RowIndex].Cells["VALOR_COMPRA"].Value.ToString();
                        txtVenda.Text = dtgListaProdutos.Rows[e.RowIndex].Cells["VALOR_VENDA"].Value.ToString();
                        txtMargemLucro.Text = dtgListaProdutos.Rows[e.RowIndex].Cells["MARGEM"].Value.ToString();
                        txtAnotacoes.Text = dtgListaProdutos.Rows[e.RowIndex].Cells["ANOTACOES_PRODUTO"].Value.ToString();
                        cbAtivo.Checked = Convert.ToBoolean(dtgListaProdutos.Rows[e.RowIndex].Cells["SITUACAO_PRODUTO"].Value.ToString());
                        dtpCadastro.Value = Convert.ToDateTime(dtgListaProdutos.Rows[e.RowIndex].Cells["DATA_CADASTRO_PRODUTO"].Value.ToString());
                    }
                    else if (dtgListaProdutos.Columns[e.ColumnIndex].Name == "btnExcluir" && MessageBox.Show("Deseja exluir esse produto?", "Deseja excluir?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        novoProduto = new Produtos();

                        novoProduto.ExcluirProduto(Convert.ToInt32(dtgListaProdutos.Rows[e.RowIndex].Cells["ID_PRODUTO"].Value.ToString()));
                        MessageBox.Show("Produto Deletado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Listar();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
