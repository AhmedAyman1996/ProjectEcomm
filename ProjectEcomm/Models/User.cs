using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectEcomm.Models
{
    public class User
    {
        public int UserId { get; set; }


        [Required(ErrorMessage ="You must Enter Your Full Name")]
        [Display(Name ="Full Name")]
        public string FullName { get; set; }


        [Required(ErrorMessage = "You must Enter Your User Name")]
        [Display(Name = "User Name")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "You must Enter Your Password")]
        public string Password { get; set; }

        [Required(ErrorMessage = "You must Enter Your Email")]
        public string Email { get; set; }
        public string Phone { get; set; }

        [Required(ErrorMessage = "You must Enter Card holder name")]
        [Display(Name = "Credit Card Holder Name")]
        public string CardHolderName { get; set; }

        [Required(ErrorMessage = "You must Enter Your Credit Card Number")]
        [Display(Name = "Credit Card Number")]
        public string CardNo { get; set; }
        [Required(ErrorMessage = "You must Enter Your CVV")]
        public string CVV { get; set; }


        [Required(ErrorMessage = "You must Enter Your Expiry Date")]
        [Display(Name = "Card Expiration Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM}", ApplyFormatInEditMode = true)]
        public DateTime ExpirationDate { get; set; }


        public ICollection<Enrollment> CourseList { get; set; }
    }
}


