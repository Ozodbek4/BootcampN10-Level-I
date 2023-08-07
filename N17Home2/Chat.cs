using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace N17Home2
{
    internal class Chat
    {
        List<ChatMessage> Messages = new List<ChatMessage>();

        public void Add(string content)
        {
            if 
                (content == null) throw new ArgumentNullException("content");
            else
                Messages.Add(new ChatMessage(content)
                {
                    Id = Guid.NewGuid(),
                    SentTime = DateTime.Now,
                    Content = content
                });
        }

        public void Update(Guid id, string content)
        {
            foreach (ChatMessage message in Messages)
            {
                if (message.Id == id)
                {
                    if (message.Content != null)
                    {
                        string a = message.Content;
                        Messages.Add(new ChatMessage(content)
                        {
                            Id = message.Id,
                            Content = a,
                            EditTime = DateTime.Now
                        });
                    }
                }
            }
        }
    }
}
// Davom ettirib qo'yaman.