using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessagingTest.Messaging
{
    public class StatusActionMessage
    {
        public StatusAction Status { get; set; }

        public StatusActionMessage(StatusAction status)
        {
            Status = status;
        }
    }
}
