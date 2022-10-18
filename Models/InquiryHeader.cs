using NPOI.XSSF.Util;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RockyProject.Models
{
    public class InquiryHeader
    {
        [Key]
        public int Id { get; set; }
       
        public string ApplicationUserId { get; set; }
        //mapping application user table
        [ForeignKey("ApplicationUserId")]
        public ApplicationUser ApplicationUser { get; set; }

        public DateTime InquiryDate { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public string FullName { get; set; }
        [Required]
        public string Email { get; set; }
    }
}
