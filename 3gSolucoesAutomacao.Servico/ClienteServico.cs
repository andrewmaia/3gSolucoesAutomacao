using _3gSolucoesAutomacao.Dados;
using _3gSolucoesAutomacao.Entidade;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3gSolucoesAutomacao.Servico
{
    public class ClienteServico
    {
        public int Criar(Cliente cliente)
        {
            ClienteDado clienteDados = new ClienteDado();
            return clienteDados.Inserir(cliente);
        }

        public void Alterar(Cliente cliente)
        {
            ClienteDado clienteDados = new ClienteDado();
            clienteDados.Alterar(cliente);
        }

        public DataTable Selecionar(string nome)
        {
            ClienteDado clienteDados = new ClienteDado();
            return clienteDados.Selecionar(nome);
        }

        public DataTable SelecionarTodos()
        {
            ClienteDado clienteDados = new ClienteDado();
            return clienteDados.SelecionarTodos();
        }

        public Cliente SelecionarPorID(int ID)
        {
            ClienteDado clienteDados = new ClienteDado();
            DataTable dt = clienteDados.SelecionarPorID(ID);
            if (dt.Rows.Count == 0)
                throw new Exception("Não encontrou Cliente");



            return new Cliente
            {
                ID = int.Parse(dt.Rows[0]["ID"].ToString()),
                Nome = dt.Rows[0]["Nome"].ToString(),
                Telefone = dt.Rows[0]["Telefone"].ToString(),
                Logradouro = dt.Rows[0]["Logradouro"].ToString(),
                Numero = dt.Rows[0]["Numero"].ToString(),
                CEP = dt.Rows[0]["CEP"].ToString(),
                Cidade = dt.Rows[0]["Cidade"].ToString(),
                UF = dt.Rows[0]["UF"].ToString(),
                DataCadastro = (DateTime)dt.Rows[0]["DataCadastro"]
            };
        }


    }
}
