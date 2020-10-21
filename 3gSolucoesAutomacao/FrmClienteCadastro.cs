using _3gSolucoesAutomacao.Entidade;
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
    public partial class FrmClienteCadastro : Form
    {

        public FrmOrdemServicoCadastro frmOrigem;
        public FrmClienteCadastro()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!Validar())
                return;
                
            Cliente cliente = new Cliente();
            cliente.Nome = txtNome.Text.Trim();
            cliente.Telefone = mskTelefone.Text;

            if (txtLogradouro.Text.Trim() != string.Empty)
                cliente.Logradouro = txtLogradouro.Text.Trim();

            if (txtNumero.Text != string.Empty)
                cliente.Numero = txtNumero.Text;

            if (mskCEP.MaskCompleted)
                cliente.CEP = mskCEP.Text;

            if (txtCidade.Text.Trim() != string.Empty)
                cliente.Cidade = txtCidade.Text.Trim();

            if(cbUF.SelectedItem!=null)
                cliente.UF = cbUF.SelectedItem.ToString();


            ClienteServico clienteServico = new ClienteServico();
            


            if (txtID.Text == string.Empty)
            {
                int id = clienteServico.Criar(cliente);
                txtID.Text =  id.ToString("00000");
                MessageBox.Show("Cliente criado com sucesso!");

                if (frmOrigem != null)
                {
                    frmOrigem.AtualizarCliente(id);
                    this.Close();
                }
            }
            else
            {
                cliente.ID = int.Parse(txtID.Text);
                clienteServico.Alterar(cliente);
                MessageBox.Show("Cliente alterado com sucesso!");
            }
        }

        private bool Validar()
        {
            if(txtNome.Text.Trim()== string.Empty)
            {
                MessageBox.Show("Preencha o nome");
                return false;
            }

            if (!mskTelefone.MaskCompleted)
            {
                MessageBox.Show("Preencha o telefone");
                return false;
            }

            if (!mskCEP.MaskCompleted && mskCEP.Text != "     -")
            {
                MessageBox.Show("Preencha um CEP válido");
                return false;
            }


            return true;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        public void Limpar()
        {
            txtID.Text = string.Empty;
            txtNome.Text = string.Empty;
            mskTelefone.Text = string.Empty;
            txtLogradouro.Text = string.Empty;
            txtNumero.Text = string.Empty;
            mskCEP.Text = string.Empty;
            txtCidade.Text = string.Empty;
            cbUF.SelectedItem = null;
        }

        public void Carregar(int ID)
        {
            ClienteServico clienteServico = new ClienteServico();
            Cliente cliente = clienteServico.SelecionarPorID(ID);
            txtID.Text = cliente.ID.ToString("00000");
            txtNome.Text = cliente.Nome;
            mskTelefone.Text = cliente.Telefone;
            txtLogradouro.Text = cliente.Logradouro;
            txtNumero.Text = cliente.Numero;
            mskCEP.Text = cliente.CEP;
            txtCidade.Text = cliente.Cidade;
            cbUF.SelectedItem = cliente.UF;

        }



        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b')
            {
                e.Handled = !char.IsNumber(e.KeyChar);
            }
        }
    }
}
