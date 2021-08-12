using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TheBlogProject.Enums;

namespace TheBlogProject.Models
{
    public class Comment
    {
        public int Id { get; set; } //PK
        public int PostID { get; set; } //FK
        public string AuthorId { get; set; } //FK
        public string  ModeratorId { get; set; } //FK

        [Required]
        [StringLength(500, ErrorMessage = "The {0} minimum is {2} and no more than {1}", MinimumLength = 10)]
        [Display(Name ="Comment")]
        public string Body { get; set; }

        [DataType(DataType.Date)]
        public DateTime Created { get; set; }
        [DataType(DataType.Date)]
        public DateTime? Updated { get; set; }
        [DataType(DataType.Date)]
        public DateTime? Moderated { get; set; }
        [DataType(DataType.Date)]
        public DateTime? Deleted { get; set; }

        [StringLength(500, ErrorMessage = "The {0} minimum is {2} and no more than {1}", MinimumLength = 10)]
        [Display(Name = "Moderated Comment")]
        public string ModeratedBody { get; set; }

        public ModerationType ModerationType { get; set; }

        //Navigation Properties
        public virtual Post Post { get; set; }
        public virtual BlogUser Author { get; set; }
        public virtual BlogUser Moderator { get; set; }


    }
}
