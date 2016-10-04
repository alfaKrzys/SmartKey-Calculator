using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Smartkey_Calculator.Models
{
    public class KeysModel
    {
        [Required]
        [Display(Name = "Klucz")]
        [StringLength(9, ErrorMessage = "Klucz powinien mieć minimum {2} znaków i maksymalnie {1}.", MinimumLength = 8)]
        public string Key { get; set; }
        [Display(Name = "Licencja")]
        public string Licence { get; set; }
    }
}