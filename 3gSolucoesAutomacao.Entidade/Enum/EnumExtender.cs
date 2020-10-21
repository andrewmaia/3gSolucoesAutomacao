using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3gSolucoesAutomacao.Entidade.Enum
{
    public static class EnumExtender
    {
        public static string ObterDescricao(this System.Enum value)
        {

            // Get the type
            Type type = value.GetType();

            // Get fieldinfo for this type
            FieldInfo fieldInfo = type.GetField(value.ToString());

            if (fieldInfo == null)
                return String.Empty;

            // Get the stringvalue attributes
            DescricaoEnumAttribute[] attribs = fieldInfo.GetCustomAttributes(
                typeof(DescricaoEnumAttribute), false) as DescricaoEnumAttribute[];

            if (attribs == null || attribs.Length == 0)
                return String.Empty;

            DescricaoEnumAttribute esteAtributo = attribs.FirstOrDefault();
            if (esteAtributo == null)
                return String.Empty;

            return esteAtributo.Descricao;
        }

    }
}
