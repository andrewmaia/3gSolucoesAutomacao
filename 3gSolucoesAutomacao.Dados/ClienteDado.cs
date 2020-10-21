using _3gSolucoesAutomacao.Entidade;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3gSolucoesAutomacao.Dados
{
    public class ClienteDado: BaseData
    {
        public int Inserir(Cliente cliente)
        {
            SqlCommand cmd = (SqlCommand)this.dataBase.GetStoredProcCommand("Cliente_Inserir");
            cmd.Parameters.Add("@Nome", System.Data.SqlDbType.VarChar).Value = cliente.Nome;
            cmd.Parameters.Add("@Telefone", System.Data.SqlDbType.VarChar).Value = cliente.Telefone;
            cmd.Parameters.Add("@Logradouro", System.Data.SqlDbType.VarChar).Value = cliente.Logradouro;
            cmd.Parameters.Add("@Numero", System.Data.SqlDbType.VarChar).Value = cliente.Numero;
            cmd.Parameters.Add("@CEP", System.Data.SqlDbType.VarChar).Value = cliente.CEP;
            cmd.Parameters.Add("@Cidade", System.Data.SqlDbType.VarChar).Value = cliente.Cidade;
            cmd.Parameters.Add("@UF", System.Data.SqlDbType.VarChar).Value = cliente.UF;
            cmd.CommandTimeout = 0;
            return int.Parse(this.dataBase.ExecuteScalar(cmd).ToString());
        }

        public void Alterar(Cliente cliente)
        {
            SqlCommand cmd = (SqlCommand)this.dataBase.GetStoredProcCommand("Cliente_Alterar");
            cmd.Parameters.Add("@ID", System.Data.SqlDbType.Int).Value = cliente.ID;
            cmd.Parameters.Add("@Nome", System.Data.SqlDbType.VarChar).Value = cliente.Nome;
            cmd.Parameters.Add("@Telefone", System.Data.SqlDbType.VarChar).Value = cliente.Telefone;
            cmd.Parameters.Add("@Logradouro", System.Data.SqlDbType.VarChar).Value = cliente.Logradouro;
            cmd.Parameters.Add("@Numero", System.Data.SqlDbType.VarChar).Value = cliente.Numero;
            cmd.Parameters.Add("@CEP", System.Data.SqlDbType.VarChar).Value = cliente.CEP;
            cmd.Parameters.Add("@Cidade", System.Data.SqlDbType.VarChar).Value = cliente.Cidade;
            cmd.Parameters.Add("@UF", System.Data.SqlDbType.VarChar).Value = cliente.UF;
            cmd.CommandTimeout = 0;
            this.dataBase.ExecuteNonQuery(cmd);
        }

        public DataTable Selecionar(string nome)
        {
            SqlCommand cmd = (SqlCommand)this.dataBase.GetStoredProcCommand("Cliente_Selecionar");
            cmd.Parameters.Add("@Nome", System.Data.SqlDbType.VarChar).Value = nome;
            cmd.CommandTimeout = 0;
            return this.dataBase.ExecuteDataSet(cmd).Tables[0];
        }

        public DataTable SelecionarTodos()
        {
            SqlCommand cmd = (SqlCommand)this.dataBase.GetStoredProcCommand("Cliente_SelecionarTodos");
            cmd.CommandTimeout = 0;
            return this.dataBase.ExecuteDataSet(cmd).Tables[0];
        }

        public DataTable SelecionarPorID(int ID)
        {
            SqlCommand cmd = (SqlCommand)this.dataBase.GetStoredProcCommand("Cliente_SelecionarPorID");
            cmd.Parameters.Add("@ID", System.Data.SqlDbType.Int).Value = ID;
            cmd.CommandTimeout = 0;
            return this.dataBase.ExecuteDataSet(cmd).Tables[0];
        }



    }
}
