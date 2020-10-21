using _3gSolucoesAutomacao.Servico;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3gSolucoesAutomacao
{
    public partial class FrmClienteConsulta : Form
    {
        public FrmClienteConsulta()
        {
            InitializeComponent();
        }

        private void FrmClienteConsulta_Load(object sender, EventArgs e)
        {
            dgvConsulta.AutoGenerateColumns = false;
            Carregar();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Carregar();
        }

        private void Carregar()
        {
            ClienteServico clienteServico = new ClienteServico();
            dgvConsulta.DataSource = clienteServico.Selecionar(txtNome.Text);
        }

        private void dgvConsulta_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int ID= int.Parse( ((DataRowView)dgvConsulta.CurrentRow.DataBoundItem)["ID"].ToString());
            MdiPrincipal mdi = (MdiPrincipal)this.MdiParent;
            FrmClienteCadastro frmClienteCadastro = (FrmClienteCadastro)mdi.AbrirForm(typeof(FrmClienteCadastro));
            frmClienteCadastro.frmOrigem = null;
            frmClienteCadastro.Carregar(ID);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = string.Empty;
            dgvConsulta.DataSource = null;
        }

        private void FrmClienteConsulta_Activated(object sender, EventArgs e)
        {
            Carregar();
        }
    }
}
