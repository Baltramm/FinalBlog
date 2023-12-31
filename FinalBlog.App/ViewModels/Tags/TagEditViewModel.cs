﻿using FinalBlog.App.ViewModels.Tags.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace FinalBlog.App.ViewModels.Tags
{
    public class TagEditViewModel : ITagViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Поле обязательно для заполнения!")]
        [Display(Name = "Имя тега")]
        public string Name { get; set; }
    }
}
