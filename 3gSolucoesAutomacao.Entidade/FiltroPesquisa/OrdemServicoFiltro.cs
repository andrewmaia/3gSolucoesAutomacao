using _3gSolucoesAutomacao.Entidade.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3gSolucoesAutomacao.Entidade.FiltroPesquisa
{
    public class OrdemServicoFiltro
    {
        public int? ID
        {
            get;
            set;
        }

        public int? IdCliente
        {
            get;
            set;
        }

        public DateTime? DataEntrada
        {
            get;
            set;
        }

        public string DescricaoEquipamento
        {
            get;
            set;
        }

        public string DescricaoProblema
        {
            get;
            set;
        }

        public OrdemServicoStatus? Status
        {
            get;
            set;
        }
    }
}
