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
    public partial class frmUnidades : Form
    {
        public frmUnidades()
        {
            InitializeComponent();
        }

        Produtos novoProduto;

        private void frmUnidades_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void Estilo()
        {
            for (int i = 0; i < dtgUnidades.Rows.Count; i += 2)
            {
                dtgUnidades.Rows[i].DefaultCellStyle.BackColor = Color.Honeydew;
            }
        }

        private void Listar()
        {
            novoProduto = new Produtos();

            try
            {
                dtgUnidades.DataSource = novoProduto.ListarUnidades();
                Estilo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
        }

        private void Limpar()
        {
            txtCodigo.Text = "0";
            txtNome.Clear();
            txtDescricao.Clear();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            novoProduto = new Produtos();

            try
            {
                if (txtCodigo.Text == "0")
                {
                    novoProduto.SalvarUnidade(txtNome.Text, txtDescricao.Text);
                    MessageBox.Show("Unidade cadastrada com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Listar();
                    Limpar();
                }
                else
                {
                    novoProduto.AlterarUnidade(Convert.ToInt32(txtCodigo.Text), txtNome.Text, txtDescricao.Text);
                    MessageBox.Show("Unidade alterada com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Listar();
                    Limpar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtgUnidades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    if (dtgUnidades.Columns[e.ColumnIndex].Name == "btnEditar")
                    {
                        txtCodigo.Text = dtgUnidades.Rows[e.RowIndex].Cells["ID_UNIDADE_PRODUTOS"].Value.ToString();
                        txtNome.Text = dtgUnidades.Rows[e.RowIndex].Cells["NOME_UNIDADE_PRODUTOS"].Value.ToString();
                        txtDescricao.Text = dtgUnidades.Rows[e.RowIndex].Cells["DESCRICAO_UNIDADE_PRODUTOS"].Value.ToString();
                    }
                    else if (dtgUnidades.Columns[e.ColumnIndex].Name == "btnExcluir")
                    {
                        novoProduto = new Produtos();

                        novoProduto.ExcluirUnidade(Convert.ToInt32(dtgUnidades.Rows[e.RowIndex].Cells["ID_UNIDADE_PRODUTOS"].Value.ToString()));
                        MessageBox.Show("Unidade deletada com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
