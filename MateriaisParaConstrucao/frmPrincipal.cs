using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MateriaisParaConstrucao
{
    public partial class frmPrincipal : Form
    {
        RegraNegocio.UsuarioRegraNegocio usuarioRN = new RegraNegocio.UsuarioRegraNegocio();

        string nomeUsuario, nivelUsuario;
        int idUsuario;

        public frmPrincipal(int idUsuario)
        {
            InitializeComponent();
            this.idUsuario = idUsuario;
        }

        private void CarregaDadosUsuario()
        {
            try
            {
                DataTable dadosTabela = new DataTable();
                dadosTabela = usuarioRN.RetornaUsuario(idUsuario);

                nomeUsuario = dadosTabela.Rows[0]["NOME_USUARIO"].ToString();
                nivelUsuario = dadosTabela.Rows[0]["NOME_NIVEL"].ToString();

                lblUsuario.Text = nomeUsuario;
                lblNivel.Text = nivelUsuario;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void VerificaNivelUsuario()
        {
            switch (nivelUsuario)
            {
                case "Chefão":
                    btnClientes.Enabled = true;
                    btnProdutos.Enabled = true;
                    btnFuncionarios.Enabled = true;
                    btnUsuarios.Enabled = true;
                    btnOrcamentos.Enabled = true;
                    btnVendas.Enabled = true;
                    btnRelatorio.Enabled = true;
                    break;

                case "Administrador":
                    btnClientes.Enabled = true;
                    btnProdutos.Enabled = true;
                    btnFuncionarios.Enabled = true;
                    btnUsuarios.Enabled = true;
                    btnOrcamentos.Enabled = true;
                    btnVendas.Enabled = true;
                    btnRelatorio.Enabled = true;
                    break;

                case "Gerente":
                    btnClientes.Enabled = true;
                    btnProdutos.Enabled = true;
                    btnFuncionarios.Enabled = true;
                    btnUsuarios.Enabled = false;
                    btnOrcamentos.Enabled = true;
                    btnVendas.Enabled = true;
                    btnRelatorio.Enabled = true;
                    break;

                case "Vendedor":
                    btnClientes.Enabled = false;
                    btnProdutos.Enabled = false;
                    btnFuncionarios.Enabled = false;
                    btnUsuarios.Enabled = false;
                    btnOrcamentos.Enabled = true;
                    btnVendas.Enabled = true;
                    btnRelatorio.Enabled = false;
                    break;

                case "Conferente":
                    btnClientes.Enabled = false;
                    btnProdutos.Enabled = true;
                    btnFuncionarios.Enabled = false;
                    btnUsuarios.Enabled = false;
                    btnOrcamentos.Enabled = false;
                    btnVendas.Enabled = false;
                    btnRelatorio.Enabled = false;
                    break;

                default:
                    btnClientes.Enabled = true;
                    btnProdutos.Enabled = true;
                    btnFuncionarios.Enabled = true;
                    btnUsuarios.Enabled = true;
                    btnOrcamentos.Enabled = true;
                    btnVendas.Enabled = true;
                    btnRelatorio.Enabled = true;
                    break;
            }
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            CarregaDadosUsuario();
            VerificaNivelUsuario();
        }

        private void relogio_Tick(object sender, EventArgs e)
        {
            lblData.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnFuncionarios_Click(object sender, EventArgs e)
        {
            //evento Click do btnFuncionarios onde o formulário frmFuncionarios é instanciado e exibido
            frmFuncionarios formFuncionarios = new frmFuncionarios();
            formFuncionarios.ShowDialog();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            //evento Click do btnClientes onde o formulário frmClientes é instanciado e exibido
            frmClientes formClientes = new frmClientes();
            formClientes.ShowDialog();
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            //evento Click do btnProdutos onde o formulário frmProdutos é instanciado e exibido
            frmProdutos formProdutos = new frmProdutos();
            formProdutos.ShowDialog();
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            frmRelatorio formRelatorio = new frmRelatorio();
            formRelatorio.ShowDialog();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            frmUsuarios formUsuraios = new frmUsuarios();
            formUsuraios.ShowDialog();
        }
    }
}
