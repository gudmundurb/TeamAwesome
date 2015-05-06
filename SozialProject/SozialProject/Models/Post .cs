using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace SozialProject.Models
{
    public class Post
    {
        [Key]
        private int id; //the individual posts' id.

        [Key]
        private int userID; // the user that made the comment.

        [Required]
        [Display(Name = "Comment text")]
        public string commentText;

        
    }
}