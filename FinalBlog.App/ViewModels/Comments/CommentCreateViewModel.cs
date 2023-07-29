using System.ComponentModel.DataAnnotations;

namespace FinalBlog.App.ViewModels.Comments
{
    public class CommentCreateViewModel
    {
        public int UserId { get; set; }
        public int PostId { get; set; }

        [Required(ErrorMessage = "Добавьте текст комментария!")]
        [Display(Name = "Комментарий")]
        public string Text { get; set; }
    }
}
