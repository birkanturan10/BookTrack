using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityLayer
{
    public class User
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required, MaxLength(50)]
        public string? Username { get; set; }

        [Required, MaxLength(100)]
        public string? Email { get; set; }

        //Düz metin olarak değil, şifrelenmiş olarak kullanıyoruz.
        [Required, MaxLength(255)]
        public string? PasswordHash { get; set; }

        //Bir kullanıcı birden fazla ReadingProgress kaydına sahip olabilir.
        public virtual List<ReadingProgress> ReadingProgresses { get; set; } = new List<ReadingProgress>();
        //Bir kullanıcı birden fazla Review kaydına sahip olabilir.
        public virtual List<Review> Reviews { get; set; } = new List<Review>();
    }
}
