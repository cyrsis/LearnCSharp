using System.ComponentModel.DataAnnotations;

namespace Demo
{
    public class AnnotatedPerson
    {
        [Display(Name = "Full Name")]
        public string Name { get; set; }

        [Display(Name = "Age in years")]
        public int Age { get; set; }

        public string HomeTown { get; set; }
        public string Password { get; set; }
    }
}