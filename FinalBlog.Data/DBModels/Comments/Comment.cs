using FinalBlog.Data.DBModels.Users;
using FinalBlog.Data.DBModels.Posts;

namespace FinalBlog.Data.DBModels.Comments
{
    public class Comment
    {
        public int Id { get; set; }
        public string Text { get; set; }        
        public DateTime CreatedDate { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public int PostId { get; set; }
        public Post Post { get; set; }

        public Comment()
        {
            CreatedDate = DateTime.Now;
        }
    }
}
