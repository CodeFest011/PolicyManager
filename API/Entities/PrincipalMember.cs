using System.ComponentModel.DataAnnotations;

namespace API.Entities
{
    public class PrincipalMember : BaseEntity
    {
        [Required]
        [Display(Name = "Policy Number")]
        public string PolicyNo { get; set; }
        [Display(Name = "External Policy Number")]
        public string ExtPolicyNo { get; set; }
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        public string GetFullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
        [Display(Name = "Identity Number")]
        public string IdentityNumber { get; set; }
        public string Passport { get; set; }
        [Required]
        [Display(Name = "Date of Birth")]
        public DateTime Birthdate { get; set; }
    }
}