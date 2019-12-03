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
    public partial class frmCategorias : Form
    {
        RegraNegocio.ProdutosRegraNegocio novoProduto;

        public frmCategorias()
        {
            InitializeComponent();
        }

        private void frmCategorias_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void Estilo()
        {
            for (int i = 0; i < dtgCategorias.RowCount; i += 2)
            {
                dtgCategorias.Rows[i].DefaultCellStyle.BackColor = Color.Honeydew;
            }
        }

        private void Listar()
        {
            novoProduto = new RegraNegocio.ProdutosRegraNegocio();

            try
            {
                dtgCategorias.DataSource = novoProduto.ListarCategorias();
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
            txtDescricao.Clear();
            txtNome.Clear();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void btnSalvar_Click(object sender, EventArgs e) //Salva ou altera uma categoria
        {
            novoProduto = new RegraNegocio.ProdutosRegraNegocio();

            try
            {
                if (txtCodigo.Text == "0") // Se o conteudo do txtCodigo for 0...
                {
                    novoProduto.SalvarCategoria(txtNome.Text, txtDescricao.Text); //Salvar uma nova categoria.

                    MessageBox.Show("Categoria cadastrada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    novoProduto.AlterarCategoria(Convert.ToInt32(txtCodigo.Text), txtNome.Text, txtDescricao.Text); //Se não, alterar a categoria.

                    MessageBox.Show("Categoria alterada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                Listar();
                Limpar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtgCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    if (dtgCategorias.Columns[e.ColumnIndex].Name == "btnEditar")
                    {
                        txtCodigo.Text = dtgCategorias.Rows[e.RowIndex].Cells["ID_CATEGORIA_PRODUTOS"].Value.ToString();
                        txtNome.Text = dtgCategorias.Rows[e.RowIndex].Cells["NOME_CATEGORIA_PRODUTOS"].Value.ToString();
                        txtDescricao.Text = dtgCategorias.Rows[e.RowIndex].Cells["DESCRICAO_CATEGORIA_PRODUTOS"].Value.ToString();
                    }
                    else if (dtgCategorias.Columns[e.ColumnIndex].Name == "btnExcluir" && MessageBox.Show("Você deseja excluir essa categoria?", "Deseja excluir?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        novoProduto = new RegraNegocio.ProdutosRegraNegocio();

                        novoProduto.ExcluirCategoria(Convert.ToInt32(dtgCategorias.Rows[e.RowIndex].Cells["ID_CATEGORIA_PRODUTOS"].Value.ToString()));

                        MessageBox.Show("Categoria excluída com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

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