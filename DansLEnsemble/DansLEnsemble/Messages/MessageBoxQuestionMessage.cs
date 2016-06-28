using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DansLEnsemble.Messages
{
    class MessageBoxQuestionMessage
    {
        public string Content { get; set; }
        public string Response { get; set; }
        public Action<string> ActionOnResponse { get; set; }
    }
}
