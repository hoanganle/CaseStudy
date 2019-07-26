using Microsoft.AspNetCore.Identity;
namespace CaseStudy.Models
{
    // extends IdentityUser class with your own fields
    public class ApplicationUser : IdentityUser
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string City { get; set; }
        public string Address1 { get; set; }
    }
}
