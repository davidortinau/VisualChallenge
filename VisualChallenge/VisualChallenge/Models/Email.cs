using System;
using System.Collections.Generic;
using System.Text;

namespace VisualChallenge.Models
{
    public class Email
    {
		public string Icon { get; set; }
		public string Name { get; set; }
		public int CountName { get; set; }
		public string Subject { get; set; }
		public string Body { get; set; }
		public string Tag { get; set; }
		public string TagBackgroundColor { get; set; }
		public string TagTextColor { get; set; }
		public string Attachment { get; set; }
		public string AttachmentTextColor { get; set; }
		public string AttachmentIcon { get; set; }
		public string Date { get; set; }
		public bool HasAttachment { get { return !String.IsNullOrEmpty(Attachment); } }
	}
}
