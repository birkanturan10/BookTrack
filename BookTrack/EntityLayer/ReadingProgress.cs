using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityLayer
{
    public class ReadingProgress
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        public int BookId { get; set; }

        [Required]
        public int PagesRead { get; set; }

        public DateTime LastUpdated { get; set; } = DateTime.Now;

        public virtual User? User { get; set; }
        public virtual Book? Book { get; set; }
    }
}
