using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityLayer
{
    public class Book
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required, MaxLength(255)]
        public string? Title { get; set; }

        [Required, MaxLength(255)]
        public string? Author { get; set; }

        [MaxLength(100)]
        public string? Genre { get; set; }

        [Required]
        public int TotalPages { get; set; }

        public virtual List<ReadingProgress> ReadingProgresses { get; set; } = new List<ReadingProgress>();
        public virtual List<Review> Reviews { get; set; } = new List<Review>();
    }
}
