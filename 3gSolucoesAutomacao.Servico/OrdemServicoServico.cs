using _3gSolucoesAutomacao.Dados;
using _3gSolucoesAutomacao.Entidade;
using _3gSolucoesAutomacao.Entidade.Enum;
using _3gSolucoesAutomacao.Entidade.FiltroPesquisa;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3gSolucoesAutomacao.Servico
{
    public class OrdemServicoServico
    {
        public int Criar(OrdemServico ordemServico)
        {
            OrdemServicoDado ordemServicoDados = new OrdemServicoDado();
            return ordemServicoDados.Inserir(ordemServico);
        }

        public void Alterar(OrdemServico ordemServico)
        {
            OrdemServicoDado ordemServicoDados = new OrdemServicoDado();
            ordemServicoDados.Alterar(ordemServico);
        }

        public DataTable Selecionar(OrdemServicoFiltro filtro)
        {
            OrdemServicoDado ordemServicoDados = new OrdemServicoDado();
            return ordemServicoDados.Selecionar(filtro);
        }

        public OrdemServico SelecionarPorID(int ID)
        {
            OrdemServicoDado ordemServicoDados = new OrdemServicoDado();
            DataTable dt = ordemServicoDados.SelecionarPorID(ID);
            if (dt.Rows.Count == 0)
                throw new Exception("Não encontrou Ordem de Serviço");

            OrdemServico ordemServico = new OrdemServico();
            ordemServico.ID = int.Parse(dt.Rows[0]["ID"].ToString());
            ordemServico.IdCliente = int.Parse(dt.Rows[0]["IdCliente"].ToString());
            ordemServico.DataEntrada = (DateTime)dt.Rows[0]["DataEntrada"];
            ordemServico.DescricaoEquipamento = dt.Rows[0]["DescricaoEquipamento"].ToString();
            ordemServico.DescricaoProblema = dt.Rows[0]["DescricaoProblema"].ToString();
            ordemServico.Status = (OrdemServicoStatus)int.Parse(dt.Rows[0]["Status"].ToString());
            ordemServico.EtiquetaImpressa = bool.Parse(dt.Rows[0]["EtiquetaImpressa"].ToString());
            if(dt.Rows[0]["DataRetirada"].ToString()!=string.Empty)
                ordemServico.DataRetirada = (DateTime)dt.Rows[0]["DataRetirada"];
            ordemServico.DataCadastro = (DateTime)dt.Rows[0]["DataCadastro"];

            return ordemServico;
        }

        public void MarcarComoEtiquetaImpressa(int ID)
        {
            OrdemServicoDado ordemServicoDados = new OrdemServicoDado();
            ordemServicoDados.MarcarComoEtiquetaImpressa(ID);
        }
    }
}
