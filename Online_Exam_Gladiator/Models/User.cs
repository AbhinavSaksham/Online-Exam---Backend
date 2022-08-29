using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Online_Exam_Gladiator.Models
{
    public class User
    {
        [Key]
        public int User_Id { get; set; }

        [Required]
        [StringLength(25)]
        public string Firstname { get; set; }

        [Required]
        [StringLength(25)]
        public  string Lastname { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(25)]
        public  string Email { get; set; }

        [Required]
        [StringLength(13)]
        public  string Mobile { get; set; }

        [Required]
        [StringLength(20)]
        public  string City { get; set; }

        [Required]
        [DataType(DataType.Date, ErrorMessage = "Date should be in DD/MM/YYYY")]
        public string Dob { get; set; }

        [Required]
        [StringLength(20)]
        public string State { get; set; }

        [Required]
        public  string Qualification { get; set; }

        [Required]
        public  string Year_of_completion { get; set; }

        [Required]
        [StringLength(50)]
        public string Password { get; set; }

        [Required]
        [StringLength(50)]
        public  string Confirm_password { get; set; }


        public int Security_Id { get; set; }

        public string Security_Answer { get; set; }

    }
}
