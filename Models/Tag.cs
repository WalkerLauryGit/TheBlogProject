using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TheBlogProject.Models
{
    public class Tag
    {
        public int Id { get; set; } //PK
        public int PostId { get; set; } //FK
        public string AuthorId { get; set; } //FK  USE IdentityUser for author virtual nav prop

        [Required]
        [StringLength(25, ErrorMessage = "The {0} must be at least {2} and no more than {1} characters", MinimumLength = 2)]
        public string Text { get; set; }

        public virtual Post Post { get; set; }
        public virtual BlogUser Author { get; set; }



        
    }
}
