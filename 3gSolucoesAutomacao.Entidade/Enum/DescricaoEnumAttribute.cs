using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3gSolucoesAutomacao.Entidade.Enum
{
    [Serializable]
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = true)]
    public class DescricaoEnumAttribute : Attribute
    {
        public string Descricao
        {
            get;
            protected set;
        }

        public DescricaoEnumAttribute(string descricao)
        {
            this.Descricao = descricao;
        }
    }
}
