using RNanoHello.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RNanoHello.Service
{
    public class NotifyService : INotifyService
    {
        private readonly IMessageService _messageService;

        public NotifyService(IMessageService messageService)
        {
            _messageService = messageService;
        }

        public MessageModel GetNotify()
        {
            var service = _messageService.GetMessage();
            return service;
        }
    }
}
