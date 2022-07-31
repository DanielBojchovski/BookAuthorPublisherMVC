﻿using System.ComponentModel.DataAnnotations;

namespace BookAuthorPublisherMVC.Models
{
    public class Author
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Name must be between 2 and 50 characters.")]
        public string Name { get; set; }

        public List<Author_Book> Authors_Books { get; set; }
    }
}
