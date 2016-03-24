using RNanoHello.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RNanoHello.Service
{
    public interface INotifyService
    {
        MessageModel GetNotify();
    }
}
