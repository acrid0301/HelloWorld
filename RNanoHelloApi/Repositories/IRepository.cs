using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RNanoHelloApi.Repositories
{
    public partial interface IRepository<TEntity> where TEntity : class
    {
        TEntity GetNofity();
        void Insert(TEntity entity);
    }
}