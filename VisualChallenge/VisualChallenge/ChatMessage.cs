using System;
using System.Collections.Generic;
using System.Text;

namespace VisualChallenge
{
    public class ChatMessage
    {
        public string ProfileIcon { get; set; }

        public string ProfileName { get; set; }

        public string Date { get; set; }

        public string Message { get; set; }

        public string Tag { get; set; }

        public ChatMessage Attachment { get; set; }

        public bool HasAttachments => Attachment != null;

        public override string ToString()
        {
            return Tag;
        }
    }
}
