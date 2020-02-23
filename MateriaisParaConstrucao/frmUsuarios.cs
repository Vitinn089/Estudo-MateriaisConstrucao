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
    public partial class frmUsuarios : Form
    {
        RegraNegocio.UsuarioRegraNegocio usuarioRN;
        RegraNegocio.NivelRegraNegocio nivelRN;

        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void Listar()
        {
            try
            {
                usuarioRN = new RegraNegocio.UsuarioRegraNegocio();

                dtgUsuarios.DataSource = usuarioRN.Listar();

                Estilo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ListarNiveis()
        {
            try
            {
                nivelRN = new RegraNegocio.NivelRegraNegocio();

                cboNivel.DataSource = nivelRN.Listar();
                cboNivel.DisplayMember = "NOME_NIVEL";
                cboNivel.ValueMember = "ID_NIVEl";

                cboNivel.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Estilo()
        {
            for (int i = 0; i < dtgUsuarios.Rows.Count; i += 2)
            {
                dtgUsuarios.Rows[i].DefaultCellStyle.BackColor = Color.Honeydew;
            }
        }

        private void Limpar()
        {
            txtCodigo.Text = "0";
            dtpDataCadastro.Value = DateTime.Today;
            txtNome.Clear();
            txtLogin.Clear();
            txtSenha.Clear();
            txtSenha2.Clear();
            cboNivel.SelectedIndex = -1;
            cboStatus.SelectedIndex = -1;
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            Listar();
            ListarNiveis();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                usuarioRN = new RegraNegocio.UsuarioRegraNegocio();

                if (txtCodigo.Text == "0")
                {
                    usuarioRN.Salvar(txtNome.Text, dtpDataCadastro.Value.Date, txtLogin.Text, txtSenha.Text, cboStatus.Text, Convert.ToInt32(cboNivel.SelectedValue), txtSenha2.Text);
                    MessageBox.Show("Usuário salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    usuarioRN.Alterar(Convert.ToInt32(txtCodigo.Text), txtNome.Text, txtLogin.Text, txtSenha.Text, txtSenha2.Text, cboStatus.Text, Convert.ToInt32(cboNivel.SelectedValue));
                    MessageBox.Show("Usuário alterado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                Listar();
                Limpar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
        }

        private void btnNiveis_Click(object sender, EventArgs e)
        {
            frmNivel formNivel = new frmNivel(this);
            formNivel.ShowDialog();
        }

        private void dtgUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dtgUsuarios.Columns[e.ColumnIndex].Name == "btnEditar")
                {
                    txtCodigo.Text = dtgUsuarios.Rows[e.RowIndex].Cells["ID_USUARIO"].Value.ToString();
                    txtNome.Text = dtgUsuarios.Rows[e.RowIndex].Cells["NOME_USUARIO"].Value.ToString();
                    txtLogin.Text = dtgUsuarios.Rows[e.RowIndex].Cells["LOGIN_USUARIO"].Value.ToString();
                    txtSenha.Text = dtgUsuarios.Rows[e.RowIndex].Cells["SENHA_USUARIO"].Value.ToString();
                    txtSenha2.Text = dtgUsuarios.Rows[e.RowIndex].Cells["SENHA_USUARIO"].Value.ToString();
                    dtpDataCadastro.Value = Convert.ToDateTime(dtgUsuarios.Rows[e.RowIndex].Cells["DATA_CADASTRO"].Value.ToString());
                    cboNivel.SelectedValue = dtgUsuarios.Rows[e.RowIndex].Cells["ID_NIVEL"].Value.ToString();
                    cboStatus.Text = dtgUsuarios.Rows[e.RowIndex].Cells["STATUS_USUARIO"].Value.ToString();
                }
                else if (dtgUsuarios.Columns[e.ColumnIndex].Name == "btnExcluir" && MessageBox.Show("Você realmente deseja excluir esse usuário?", "Deseja Excluir?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    usuarioRN = new RegraNegocio.UsuarioRegraNegocio();

                    usuarioRN.Excluir(Convert.ToInt32(dtgUsuarios.Rows[e.RowIndex].Cells["ID_USUARIO"].Value.ToString()));
                    MessageBox.Show("Usuário excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Listar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
