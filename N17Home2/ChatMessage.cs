using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N17Home2
{
    internal class ChatMessage
    {
        public Guid Id { get; set; }
        public DateTime SentTime { get; set; }
        public DateTime EditTime { get; set; }
        public string Content { get; set; }

        public ChatMessage(string content)
        {
            Id = Guid.NewGuid();
            SentTime = DateTime.Now;
            Content = content;
        }

        public void Copy(ChatMessage message)
        {
            
        }
    }
}
