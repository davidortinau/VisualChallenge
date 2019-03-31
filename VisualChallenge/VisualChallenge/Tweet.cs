using System;
using System.Collections.Generic;
using System.Text;

namespace VisualChallenge
{
    public class Tweet
    {
        public string FullUserName { get; set; }

        public string User { get; set; }

        public bool IsRetweet { get; set; }

        public string RetweetedBy { get; set; }

        public string Content { get; set; }

        public int LikeCount { get; set; }

        public int FavCount { get; set; }

        public int ReplyCount { get; set; }

        public bool HasImage { get; set; }
    }
}
