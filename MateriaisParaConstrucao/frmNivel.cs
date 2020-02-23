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
    public partial class frmNivel : Form
    {

        RegraNegocio.NivelRegraNegocio nivelRN;
        frmUsuarios formUsuarios;

        public frmNivel(frmUsuarios usuarios)
        {
            InitializeComponent();
            formUsuarios = usuarios;
        }

        private void frmNivel_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void Listar()
        {
            try
            {
                nivelRN = new RegraNegocio.NivelRegraNegocio();

                dtgNiveis.DataSource = nivelRN.Listar();
                Estilo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Estilo()
        {
            for (int i = 0; i < dtgNiveis.Rows.Count; i += 2)
            {
                dtgNiveis.Rows[i].DefaultCellStyle.BackColor = Color.Honeydew;
            }
        }

        private void Limpar()
        {
            txtNome.Clear();
            txtCodigo.Text = "0";
            txtDescricao.Clear();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                nivelRN = new RegraNegocio.NivelRegraNegocio();

                if (txtCodigo.Text == "0")
                {
                    nivelRN.Salvar(txtNome.Text, txtDescricao.Text);
                    MessageBox.Show("Nível criado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Listar();
                    Limpar();
                }
                else
                {
                    nivelRN.Alterar(Convert.ToInt32(txtCodigo.Text), txtNome.Text, txtDescricao.Text);
                    MessageBox.Show("Nível alterado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Listar();
                    Limpar();
                }

                formUsuarios.ListarNiveis();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtgNiveis_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dtgNiveis.Columns[e.ColumnIndex].Name == "btnEditar")
                {
                    txtCodigo.Text = dtgNiveis.Rows[e.RowIndex].Cells["ID_NIVEL"].Value.ToString();
                    txtNome.Text = dtgNiveis.Rows[e.RowIndex].Cells["NOME_NIVEL"].Value.ToString();
                    txtDescricao.Text = dtgNiveis.Rows[e.RowIndex].Cells["DESCRICAO_NIVEL"].Value.ToString();
                }
                else if (dtgNiveis.Columns[e.ColumnIndex].Name == "btnExcluir" && MessageBox.Show("Tem certeza que deseja excluir?", "Deseja Excluir?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    nivelRN.Excluir(Convert.ToInt32(dtgNiveis.Rows[e.RowIndex].Cells["ID_NIVEL"].Value.ToString()));
                    MessageBox.Show("Nível excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Listar();
                    formUsuarios.ListarNiveis();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
