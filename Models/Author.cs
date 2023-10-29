using System.ComponentModel.DataAnnotations;

namespace LAB2_gaftone_delia.Models
{
    public class Author
    {
        public int ID { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        [Display(Name = "Full Name")]
        public string FullName => FirstName + " " + LastName;
    }
}
