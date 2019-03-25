namespace VisualChallenge
{
    // Quick and direct structure to support CollectionView visuals
    public class PostData
    {
        public string Username { get; set; }
        public string PostTitle { get; set; }
        public string PostDetail { get; set; }
        public string PostImage { get; set; }
        public string LikeCountText { get; set; }
        public string CommentCountText { get; set; }
        public string TimestampText { get; set; }
        public string UserImage => $"{Username}.jpg";
        public string PostImageUrl => $"{PostImage}.jpg";
    }
}