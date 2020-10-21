using _3gSolucoesAutomacao.Entidade;
using _3gSolucoesAutomacao.Entidade.Enum;
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
    public partial class FrmOrdemServicoCadastro : Form
    {
        public FrmOrdemServicoCadastro()
        {
            InitializeComponent();
        }

        private void FrmOrdemServicoCadastro_Load(object sender, EventArgs e)
        {
            dtpDataEntrada.Value = DateTime.Today;
            dtpDataRetirada.Value = DateTime.Today;
            CarregarStatus();
            CarregarClientes();
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
            ClienteServico clienteServico = new ClienteServico();
            cbCliente.DataSource = clienteServico.SelecionarTodos();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!Validar())
                return;

            OrdemServico ordemServico = new OrdemServico();
            ordemServico.IdCliente = (int) cbCliente.SelectedValue;
            ordemServico.DataEntrada = dtpDataEntrada.Value.Date;
            ordemServico.DescricaoEquipamento = txtEquipamento.Text.Trim();
            ordemServico.DescricaoProblema = txtDescricaoProblema.Text.Trim();
            ordemServico.Status = (OrdemServicoStatus)((ComboBoxItem)cbStatus.SelectedItem).Value;
            if (dtpDataRetirada.Enabled)
                ordemServico.DataRetirada = dtpDataRetirada.Value;
            OrdemServicoServico ordemServicoServico = new OrdemServicoServico();

            if (txtID.Text == string.Empty)
            {
                txtID.Text = ordemServicoServico.Criar(ordemServico).ToString("000000");
                MessageBox.Show("Ordem de Serviço criada com sucesso!");

            }
            else
            {
                ordemServico.ID = int.Parse(txtID.Text);
                ordemServicoServico.Alterar(ordemServico);
                MessageBox.Show("Ordem de Serviço alterada com sucesso!");
            }

            btnImprimir.Enabled = true;
        }


        private bool Validar()
        {
            if (cbCliente.SelectedItem==null)
            {
                MessageBox.Show("Selecione um Cliente");
                return false;
            }

            if (cbStatus.SelectedItem == null)
            {
                MessageBox.Show("Selecione um Status");
                return false;
            }

            if (txtEquipamento.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Preencha o equipamento");
                return false;
            }

            if (txtDescricaoProblema.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Preencha a descrição do problema");
                return false;
            }

            return true;
        }


        public void Carregar(int ID)
        {
            OrdemServicoServico ordemServicoServico = new OrdemServicoServico();
            OrdemServico ordemServico = ordemServicoServico.SelecionarPorID(ID);
            txtID.Text = ordemServico.ID.ToString("000000");
            dtpDataEntrada.Value= ordemServico.DataEntrada;
            txtEquipamento.Text = ordemServico.DescricaoEquipamento;
            txtDescricaoProblema.Text = ordemServico.DescricaoProblema;
            SetarStatus(ordemServico.Status);
            SetarCliente(ordemServico.IdCliente);
            dtpDataRetirada.Enabled = ordemServico.DataRetirada.HasValue;
            if (ordemServico.DataRetirada.HasValue)
                dtpDataRetirada.Value = ordemServico.DataRetirada.Value;
            HabilitarCamposEtiqueta(!ordemServico.EtiquetaImpressa);
            btnImprimir.Enabled = true;
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

        private void SetarCliente(int idCliente)
        {
            foreach (DataRowView item in cbCliente.Items)
            {
                if ( int.Parse(item["ID"].ToString()) == idCliente)
                {
                    cbCliente.SelectedItem = item;
                    break;
                }
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        public void Limpar()
        {
            txtID.Text = string.Empty;
            cbCliente.SelectedItem = null;
            cbStatus.SelectedItem = null;
            txtDescricaoProblema.Text = string.Empty;
            txtEquipamento.Text = string.Empty;
            dtpDataEntrada.Value = DateTime.Today;
            btnImprimir.Enabled = false;
            dtpDataRetirada.Enabled = false;
            dtpDataRetirada.Value = DateTime.Today;
            HabilitarCamposEtiqueta(true);
        }

        private void btnAdicionarCliente_Click(object sender, EventArgs e)
        {

            MdiPrincipal mdi = (MdiPrincipal)this.MdiParent;
            FrmClienteCadastro frmClienteCadastro = (FrmClienteCadastro)mdi.AbrirForm(typeof(FrmClienteCadastro));
            frmClienteCadastro.Limpar();
            frmClienteCadastro.frmOrigem = this;
        }

        public void AtualizarCliente(int idCliente)
        {
            CarregarClientes();
            SetarCliente(idCliente);
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(txtID.Text);
            OrdemServicoServico ordemServicoServico = new OrdemServicoServico();
            OrdemServico ordemServico = ordemServicoServico.SelecionarPorID(ID);

            bool podeImprimir = false;

            if (ordemServico.EtiquetaImpressa)
                podeImprimir = true;
            else
            {
                DialogResult dialogResult = MessageBox.Show("Deseja Realmente Imprimir a Etiqueta? Após a impressão não será possíveis alterar os dados impressos na etiqueta.", "Impressão da Etiqueta", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                    (new OrdemServicoServico()).MarcarComoEtiquetaImpressa(ID);
                    HabilitarCamposEtiqueta(false);
                    podeImprimir = true;
                }
            }

            if(podeImprimir)
            {
                MdiPrincipal mdi = (MdiPrincipal)this.MdiParent;
                FrmEtiqueta frmEtiqueta = (FrmEtiqueta)mdi.AbrirForm(typeof(FrmEtiqueta));
                frmEtiqueta.ExibirRelatorio(ID);
            }

        }

        private void HabilitarCamposEtiqueta(bool b)
        {
            txtEquipamento.Enabled = b;
            dtpDataEntrada.Enabled = b;
            cbCliente.Enabled = b;
            btnAdicionarCliente.Enabled = b;
        }

        private void cbStatus_SelectedValueChanged(object sender, EventArgs e)
        {
            if(cbStatus.SelectedItem==null)
            {
                dtpDataRetirada.Enabled = false;
                return;
            }
            OrdemServicoStatus status = (OrdemServicoStatus)((ComboBoxItem)cbStatus.SelectedItem).Value;
            dtpDataRetirada.Enabled = (status == OrdemServicoStatus.Finalizada);
        }


    }
}
