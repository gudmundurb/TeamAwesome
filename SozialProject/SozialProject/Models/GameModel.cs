﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SozialProject.Models
{
    public class GameModel
    {
        [Key]
        public int GameID { get; set; }

        [Required(ErrorMessage="The game needs a name")]
        [Display(Name = "Game name:")]
        public string nameOfGame { get; set; }

        [Required(ErrorMessage = "Give me a description of this game please")]
        [Display(Name = "About the game:")]
        public string aboutGame { get; set; }

        [Required(ErrorMessage = "There must be a game company for this game")]
        [Display(Name = "Game Company:")]
        public string gameCompany { get; set; }

        public bool isTopTen { get; set; }  //using for testing purposes

        [Display(Name="Game Genre:")]
        public string genre { get; set; }
    }
}