using _3gSolucoesAutomacao.Entidade;
using _3gSolucoesAutomacao.Entidade.FiltroPesquisa;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3gSolucoesAutomacao.Dados
{
    public class OrdemServicoDado : BaseData
    {
        public int Inserir(OrdemServico ordemServico)
        {
            SqlCommand cmd = (SqlCommand)this.dataBase.GetStoredProcCommand("OrdemServico_Inserir");
            cmd.Parameters.Add("@IdCliente", System.Data.SqlDbType.Int).Value = ordemServico.IdCliente;
            cmd.Parameters.Add("@DataEntrada", System.Data.SqlDbType.SmallDateTime).Value = ordemServico.DataEntrada;
            cmd.Parameters.Add("@DescricaoEquipamento", System.Data.SqlDbType.VarChar).Value = ordemServico.DescricaoEquipamento;
            cmd.Parameters.Add("@DescricaoProblema", System.Data.SqlDbType.VarChar).Value = ordemServico.DescricaoProblema;
            cmd.Parameters.Add("@Status", System.Data.SqlDbType.TinyInt).Value = ordemServico.Status;
            cmd.Parameters.Add("@DataRetirada", System.Data.SqlDbType.SmallDateTime).Value = ordemServico.DataRetirada;
            cmd.CommandTimeout = 0;
            return int.Parse(this.dataBase.ExecuteScalar(cmd).ToString());
        }


        public void Alterar(OrdemServico ordemServico)
        {
            SqlCommand cmd = (SqlCommand)this.dataBase.GetStoredProcCommand("OrdemServico_Alterar");
            cmd.Parameters.Add("@ID", System.Data.SqlDbType.Int).Value = ordemServico.ID;
            cmd.Parameters.Add("@IdCliente", System.Data.SqlDbType.Int).Value = ordemServico.IdCliente;
            cmd.Parameters.Add("@DataEntrada", System.Data.SqlDbType.SmallDateTime).Value = ordemServico.DataEntrada;
            cmd.Parameters.Add("@DescricaoEquipamento", System.Data.SqlDbType.VarChar).Value = ordemServico.DescricaoEquipamento;
            cmd.Parameters.Add("@DescricaoProblema", System.Data.SqlDbType.VarChar).Value = ordemServico.DescricaoProblema;
            cmd.Parameters.Add("@Status", System.Data.SqlDbType.TinyInt).Value = ordemServico.Status;
            cmd.Parameters.Add("@DataRetirada", System.Data.SqlDbType.SmallDateTime).Value = ordemServico.DataRetirada;
            cmd.CommandTimeout = 0;
            this.dataBase.ExecuteNonQuery(cmd);
        }

        public DataTable Selecionar(OrdemServicoFiltro filtro)
        {
            SqlCommand cmd = (SqlCommand)this.dataBase.GetStoredProcCommand("OrdemServico_Selecionar");
            cmd.Parameters.Add("@ID", System.Data.SqlDbType.Int).Value = filtro.ID;
            cmd.Parameters.Add("@IdCliente", System.Data.SqlDbType.Int).Value = filtro.IdCliente;
            cmd.Parameters.Add("@DataEntrada", System.Data.SqlDbType.SmallDateTime).Value = filtro.DataEntrada;
            cmd.Parameters.Add("@DescricaoEquipamento", System.Data.SqlDbType.VarChar).Value = filtro.DescricaoEquipamento;
            cmd.Parameters.Add("@DescricaoProblema", System.Data.SqlDbType.VarChar).Value = filtro.DescricaoProblema;
            cmd.Parameters.Add("@Status", System.Data.SqlDbType.TinyInt).Value = filtro.Status;
            cmd.CommandTimeout = 0;
            return this.dataBase.ExecuteDataSet(cmd).Tables[0];
        }

        public DataTable SelecionarPorID(int ID)
        {
            SqlCommand cmd = (SqlCommand)this.dataBase.GetStoredProcCommand("OrdemServico_SelecionarPorID");
            cmd.Parameters.Add("@ID", System.Data.SqlDbType.Int).Value = ID;
            cmd.CommandTimeout = 0;
            return this.dataBase.ExecuteDataSet(cmd).Tables[0];
        }

        public void MarcarComoEtiquetaImpressa(int ID)
        {
            SqlCommand cmd = (SqlCommand)this.dataBase.GetStoredProcCommand("OrdemServico_MarcarComoEtiquetaImpressa");
            cmd.Parameters.Add("@ID", System.Data.SqlDbType.Int).Value = ID;
            cmd.CommandTimeout = 0;
            this.dataBase.ExecuteNonQuery(cmd);
        }
    }
}
