using RNanoHello.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RNanoHello.Service
{
    public class MockMessageService : IMessageService
    {
        public MessageModel GetMessage()
        {
            //Get Message from the Database, text file, Xml file, or other services.
            var message = new MessageModel();
            message.Message = "Mock: Hello World";

            return message;
        }
    }
}
