using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DojoSurveyWithValidations.Models
{
    public class Survey
    {
        [Required(ErrorMessage = "Name is Required")]
        [MinLength(2, ErrorMessage = "Name must be at least 2 characters long!")]
        public string Name {get; set;}
        [Required]
        [FutureDate]
        public DateTime Birthday {get; set;}
        [Required]
        public string DojoLocation {get; set;}
        [Required]
        public string FavoriteLanguage {get; set;}
        [MinLength(20)]
        public string? Comment {get; set;}

    }
}