using System.ComponentModel; //This was added to support the Readonly Annotation
using System.ComponentModel.DataAnnotations;

namespace CIS174_TestCoreApp.Models
{
    public class CreatePersonViewModel
    {
        [Required]
        [StringLength(25)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [StringLength(25)]
        [Display(Name = "Middle Name")]
        public string MiddleName { get; set; }
        [Required]
        [StringLength(25)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required]
        [Range(1, 120)]
        public int Age { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [Compare("Email")]
        [Display(Name = "Confirm Email")]
        public string ConfirmEmail { get; set; }
        [Url]
        [MinLength(7)]
        public string Website { get; set; }
        //[EditableAttribute(false)]
        //[ReadOnly(true)] //This did not stop me from editing the field, the field info was changed but it DID NOT change on reload
        [Editable(false)] //This did not stop me from editing the field, it did make the field info disappear on reload
        public string School { get; set; }
    }
}
