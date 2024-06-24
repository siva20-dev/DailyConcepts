﻿using System.ComponentModel.DataAnnotations;

namespace BookStoreAPI.Model
{
    public class BookModel
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage ="Please Enter Title Property")]
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
