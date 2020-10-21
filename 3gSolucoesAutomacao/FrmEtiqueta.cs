using _3gSolucoesAutomacao.Entidade;
using _3gSolucoesAutomacao.Servico;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3gSolucoesAutomacao
{
    public partial class FrmEtiqueta : Form
    {
        public FrmEtiqueta()
        {
            InitializeComponent();
        }


        public void ExibirRelatorio(int id)
        {
            // Set the processing mode for the ReportViewer to Local  
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            LocalReport localReport = reportViewer1.LocalReport;
            localReport.ReportEmbeddedResource = "_3gSolucoesAutomacao.Etiqueta.rdlc";

            OrdemServicoServico ordemServicoServico = new OrdemServicoServico();
            OrdemServico ordemServico = ordemServicoServico.SelecionarPorID(id);

            ClienteServico clienteServico = new ClienteServico();
            Cliente cliente = clienteServico.SelecionarPorID(ordemServico.IdCliente);

            localReport.SetParameters(
                new ReportParameter[] {
                    new ReportParameter("ID", id.ToString("000000")),
                    new ReportParameter("DescricaoEquipamento", ordemServico.DescricaoEquipamento),
                    new ReportParameter("ClienteNome", cliente.Nome),
                    new ReportParameter("DataEntrada", ordemServico.DataEntrada.ToString("dd/MM/yyyy",new CultureInfo("pt-BR"))) });

            // Refresh the report  
            reportViewer1.RefreshReport();
        }

    }
}
