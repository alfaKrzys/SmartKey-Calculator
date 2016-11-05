using System;
using System.ComponentModel.DataAnnotations;
using Smartkey_Calculator.ValidationAttributes;
namespace Smartkey_Calculator.Models
{
    public class KeysModel
    {
        [Required]
        public int ID { get; set; }
        [Required]
        [Display(Name = "Klucz")]
        [StringLength(9, ErrorMessage = "Klucz powinien mieć minimum {2} znaków i maksymalnie {1}.", MinimumLength = 8)]
        [ValidZeroInKey(ErrorMessage = "Nieprawidłowy format klucza")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Klucz może zawierać tylko cyfry")]
        public string Key { get; set; }
        [Display(Name = "Licencja")]
        public string Licence { get; set; }
        [Display(Name = "Data obliczenia")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        public DateTime CalcDate { get; set; }
    }
}