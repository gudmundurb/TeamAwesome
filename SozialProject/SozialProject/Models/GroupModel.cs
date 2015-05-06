using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SozialProject.Models
{
    public class GroupModel
    {
        [Key]
        private int groupId;

        [Key]
        private int creatorId;


        [Required]
        [Display(Name = "Group Name")]
        public string groupName;


        [Required]
        [Display(Name = "Group Description")]
        public string groupDescription;
        

    }
}