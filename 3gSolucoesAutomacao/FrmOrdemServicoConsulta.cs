using _3gSolucoesAutomacao.Entidade.Enum;
using _3gSolucoesAutomacao.Entidade.FiltroPesquisa;
using _3gSolucoesAutomacao.Servico;
using _3gSolucoesAutomacao.Utilitarios;
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
    public partial class FrmOrdemServicoConsulta : Form
    {

        public FrmOrdemServicoConsulta()
        {
            InitializeComponent();
        }
        private void FrmOrdemServicoConsulta_Load(object sender, EventArgs e)
        {

            dgvConsulta.AutoGenerateColumns = false;
            CarregarStatus();
            CarregarClientes();
            Carregar();
        }

        private void FrmOrdemServicoConsulta_Activated(object sender, EventArgs e)
        {
            Carregar();
        }

        private void CarregarStatus()
        {
            cbStatus.Items.Clear();
            IEnumerable<OrdemServicoStatus> statusLista = Enum.GetValues(typeof(OrdemServicoStatus)).Cast<OrdemServicoStatus>();
            foreach (OrdemServicoStatus ordemServicoStatus in statusLista)
            {
                cbStatus.Items.Add(new ComboBoxItem { Text = ordemServicoStatus.ObterDescricao(), Value = (int)ordemServicoStatus });
            }

        }

        private void CarregarClientes()
        {
            cbCliente.Items.Clear();
            ClienteServico clienteServico = new ClienteServico();
            cbCliente.DataSource = clienteServico.SelecionarTodos();
            cbCliente.SelectedItem = null;
        }

        public void CarregarAguardandoOrcamento()
        {
            SetarStatus(OrdemServicoStatus.AguardandoOrcamento);
            Carregar();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Carregar();
        }

        private void Carregar()
        {
            OrdemServicoServico ordemServicoServico = new OrdemServicoServico();
            OrdemServicoFiltro ordemServicoFiltro = ObterFiltro();
            dgvConsulta.DataSource = ordemServicoServico.Selecionar(ordemServicoFiltro);
        }

        private OrdemServicoFiltro ObterFiltro()
        {
            OrdemServicoFiltro filtro = new OrdemServicoFiltro();

            if (txtID.Text.Trim() != string.Empty)
                filtro.ID = int.Parse(txtID.Text);

            if (cbCliente.SelectedItem != null)
                filtro.IdCliente = (int)cbCliente.SelectedValue;

            if (cbStatus.SelectedItem != null)
                filtro.Status = (OrdemServicoStatus)((ComboBoxItem)cbStatus.SelectedItem).Value;

            if (txtDescricaoEquipamento.Text.Trim() != string.Empty)
                filtro.DescricaoEquipamento = txtDescricaoEquipamento.Text;

            if (txtDescricaoProblema.Text.Trim() != string.Empty)
                filtro.DescricaoProblema = txtDescricaoProblema.Text;

            if (dtpDataEntrada.Enabled)
                filtro.DataEntrada = dtpDataEntrada.Value.Date;

            return filtro;
        }


        private void dgvConsulta_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int ID = int.Parse(((DataRowView)dgvConsulta.CurrentRow.DataBoundItem)["ID"].ToString());
            MdiPrincipal mdi = (MdiPrincipal)this.MdiParent;
            FrmOrdemServicoCadastro frmOrdemServicoCadastro = (FrmOrdemServicoCadastro)mdi.AbrirForm(typeof(FrmOrdemServicoCadastro));
            frmOrdemServicoCadastro.Carregar(ID);
        }



        private void chkDataEntrada_CheckedChanged(object sender, EventArgs e)
        {
            dtpDataEntrada.Enabled = chkDataEntrada.Checked;
        }


        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtID.Text = string.Empty;
            cbCliente.SelectedItem = null;
            cbStatus.SelectedItem = null;
            txtDescricaoEquipamento.Text = string.Empty;
            txtDescricaoProblema.Text = string.Empty;
            dtpDataEntrada.Value = DateTime.Today;
            chkDataEntrada.Checked = false;
            dgvConsulta.DataSource = null;

        }


        #region Outros
        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b')
            {
                e.Handled = !char.IsNumber(e.KeyChar);
            }
        }

        private void SetarStatus(OrdemServicoStatus status)
        {
            foreach (ComboBoxItem item in cbStatus.Items)
            {
                if (item.Value == (int)status)
                {
                    cbStatus.SelectedItem = item;
                    break;
                }
            }
        }
        #endregion


    }
}
