using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.EnterpriseLibrary.Data;


namespace _3gSolucoesAutomacao.Dados
{
    public class BaseData : IDisposable
    {
        #region :: Constructors ::
        protected Database dataBase;

        public BaseData()
        {
            DatabaseFactory.SetDatabaseProviderFactory(new DatabaseProviderFactory(),false);
            this.dataBase = DatabaseFactory.CreateDatabase("BD");
        }
        #endregion

        #region :: Dispose ::
        public void Dispose()
        {
            if (this.dataBase != null)
            {
                this.dataBase = null;
            }
        }
        #endregion
    }
}
