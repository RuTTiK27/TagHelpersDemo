using System.ComponentModel.DataAnnotations;

namespace TagHelpersDemo.Models
{
    public class Employee
    {
        [Required (ErrorMessage = "Name is Required")]
        [StringLength (15, MinimumLength=3,ErrorMessage ="Name must be within 3 to 15 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Age is Required")]
        [Range (18,50,ErrorMessage ="Age must be within 18 to 50")]
        public int? Age { get; set; }

        [Required(ErrorMessage = "Email Is Required")]
        //[EmailAddress]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$",ErrorMessage ="Invalid Email")]
        [MinLength(10,ErrorMessage ="Minimum Length Must be 10 characters")]
        [MaxLength(30,ErrorMessage ="Maximum Length is 30 characters")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password Is Required")]
        [RegularExpression(@"(?=^.{8,}$)((?=.*\d)|(?=.*\W+))(?![.\n])(?=.*[A-Z])(?=.*[a-z]).*$",ErrorMessage ="Uppercase, Lowercase, Numbers, Symbols, Min 8 Chars")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Confirm Password Is Required")]
        [Compare("Password",ErrorMessage ="Not Mathcing With Password")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage ="Website URL Is Required")]
        [Url(ErrorMessage ="Invalid URL")]
        [Display(Name= "Enter WebsiteURL:")]
        public string WebsiteURL { get; set; }

        public decimal? Salary { get; set; }
        public Gender Gender { get; set; }
        public string Married { get; set; }
        public string Description { get; set; }
    }
    public enum Gender
    {
        Male,Female
    }
}
