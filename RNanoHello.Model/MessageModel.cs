using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RNanoHello.Model
{
    public class MessageModel
    {
        public MessageModel()
        {
            this.Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
        public string Message { get; set; }
    }
}
