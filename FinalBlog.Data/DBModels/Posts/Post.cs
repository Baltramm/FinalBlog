﻿using FinalBlog.Data.DBModels.Comments;
using FinalBlog.Data.DBModels.Tags;
using FinalBlog.Data.DBModels.Users;

namespace FinalBlog.Data.DBModels.Posts
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreatedDate { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public List<Tag> Tags { get; set; }
        public List<Comment> Comments { get; set; }

        public Post()
        {
            CreatedDate = DateTime.Now;
        }
    }
}
