using RNanoHello.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using RNanoHello.Service;
using Microsoft.Practices.Unity;
using Ninject;

namespace RNanoHelloApi.Repositories
{
    public class HelloRepository : IDisposable, IRepository<MessageModel> 
    {
        private readonly INotifyService _notifyService;
        public HelloRepository()
        {
            var standardKernel = new StandardKernel(new NinjectBindings());
            _notifyService = standardKernel.Get<INotifyService>();
        }

        public MessageModel GetNofity()
        {
            return _notifyService.GetNotify();
        }
        public void Insert(MessageModel entity)
        {
            //TODO: persist data to the database
        }
        
        protected void Dispose(bool disposing)
        {
            if (disposing)
            {
               //TODO: Dispose the context here...
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        
    }
}