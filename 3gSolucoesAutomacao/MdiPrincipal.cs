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
    public partial class MdiPrincipal : Form
    {
        public MdiPrincipal()
        {
            InitializeComponent();
        }

        private void MdiPrincipal_Load(object sender, EventArgs e)
        {
            FrmOrdemServicoConsulta frm = (FrmOrdemServicoConsulta)AbrirForm(typeof(FrmOrdemServicoConsulta));
            frm.CarregarAguardandoOrcamento();
        }

        public Form AbrirForm(Type type)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == type)
                {
                    form.Activate();
                    return form;
                }
            }

            Form novoForm = (Form)Activator.CreateInstance(type);
            novoForm.MdiParent = this;
            novoForm.Show();
            return novoForm;
        }

        #region Menus
        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmClienteCadastro frm = (FrmClienteCadastro) AbrirForm(typeof(FrmClienteCadastro));
            frm.frmOrigem = null;
            frm.Limpar();
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirForm(typeof(FrmClienteConsulta));
        }

        private void novoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmOrdemServicoCadastro frm = (FrmOrdemServicoCadastro)AbrirForm(typeof(FrmOrdemServicoCadastro));
            frm.Limpar();
        }

        private void consultaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AbrirForm(typeof(FrmOrdemServicoConsulta));
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirForm(typeof(FrmSobre));
        }

        #endregion
    }
   
}
