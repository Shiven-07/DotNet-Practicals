using System.ComponentModel.DataAnnotations;
 namespace ArithmeticMVC.Models {
    public class ArithmeticModel
        {
           [Required]
           [Display(Name = "First Number")] public double Number1 { get; set; }
           [Required]
           [Display(Name = "Second Number")] public double Number2 { get; set; }
           public string Operation { get; set; } = "";
           public double Result { get; set; }
           public string ErrorMessage { get; set; } = "";
       }
   }
