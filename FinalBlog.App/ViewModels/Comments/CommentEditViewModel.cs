﻿using System.ComponentModel.DataAnnotations;

namespace FinalBlog.App.ViewModels.Comments
{
    public class CommentEditViewModel
    {
        public int UserId { get; set; }
        public int Id { get; set; }

        [Required(ErrorMessage = "Добавьте текст комментария!")]
        [Display(Name = "Комментарий")]
        public string Text { get; set; }
    }
}
