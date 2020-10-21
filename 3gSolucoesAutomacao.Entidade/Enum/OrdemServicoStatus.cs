using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3gSolucoesAutomacao.Entidade.Enum
{
    public enum OrdemServicoStatus
    {
        [DescricaoEnumAttribute("Aguardando Orçamento")]
        AguardandoOrcamento = 0,
        [DescricaoEnumAttribute("Aguardando Peça para Orçamento")]
        AguardandoPecaParaOrcamento =1,
        [DescricaoEnumAttribute("Em Aprovação")]
        EmAprovacao =2,
        [DescricaoEnumAttribute("Orçamento Aprovado")]
        OrcamentoAprovado =3,
        [DescricaoEnumAttribute("Orçamento Reprovado")]
        OrcamentoReprovado= 4,
        [DescricaoEnumAttribute("Pronto para Retirada")]
        ProntoParaRetirada =5,
        [DescricaoEnumAttribute("Finalizada")]
        Finalizada = 6,
        [DescricaoEnumAttribute("Cancelada")]
        Cancelada = 7 
    }
    

}

