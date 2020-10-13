using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SubscriptionTracker.Models
{
    [Table("tblUsers")]
    public class User
    {
        [Key]
        [Required]
        public string EmailId { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string PhoneNo { get; set; }
        [Required]
        public string Password { get; set; }
        //[NotMapped]
        //[Required]
        //[Compare("Password")]
        //public string ConfirmPassword { get; set; }
    }
}