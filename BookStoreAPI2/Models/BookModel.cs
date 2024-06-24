﻿using System.ComponentModel.DataAnnotations;
namespace BookStoreAPI2.Models
{
    public class BookModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Title is Required")]
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
