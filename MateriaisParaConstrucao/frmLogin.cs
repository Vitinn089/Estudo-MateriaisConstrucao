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
    public partial class frmLogin : Form
    {
        RegraNegocio.UsuarioRegraNegocio usuarioRN = new RegraNegocio.UsuarioRegraNegocio();

        public int idUsuario;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dadosTabela = new DataTable();
                dadosTabela = usuarioRN.Login(txtLogin.Text, txtSenha.Text);

                if (dadosTabela.Rows.Count == 0)
                {
                    MessageBox.Show("Usuário ou Senha inválidos!", "Entrada não permitida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (dadosTabela.Rows[0]["STATUS_USUARIO"].ToString() == "Inativo")
                {
                    MessageBox.Show("Conta de usuário inativa!", "Conta Inativa!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Olá " + dadosTabela.Rows[0]["NOME_USUARIO"].ToString() + ". \nBem-vindo ao sistema!", "Bem Vindo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    idUsuario = Convert.ToInt32(dadosTabela.Rows[0]["ID_USUARIO"]);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                DataTable dadosTabela = new DataTable();
                dadosTabela = usuarioRN.Login(txtLogin.Text, txtSenha.Text);

                if (dadosTabela.Rows.Count == 0)
                {
                    MessageBox.Show("Usuário ou Senha inválidos!", "Entrada não permitida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (dadosTabela.Rows[0]["STATUS_USUARIO"].ToString() == "Inativo")
                {
                    MessageBox.Show("Conta de usuário inativa!", "Conta Inativa!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Olá " + dadosTabela.Rows[0]["NOME_USUARIO"].ToString() + ". \nBem-vindo ao sistema!", "Bem Vindo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    idUsuario = Convert.ToInt32(dadosTabela.Rows[0]["ID_USUARIO"]);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }
    }
}
