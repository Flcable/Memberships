using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Memberships.Entities
{
    [Table("UserSubscription")]
    public class UserSubscription
    {
        [Required]
        [Key, Column(Order = 1)]
        public int SubscriptionId { get; set; }

        
        [Key, Column(Order = 2)]
        [MaxLength(128)]
        [Required]
        public string UserID { get; set; }


       public DateTime? StartDate { get; set; }
        public DateTime? EndtDate { get; set; }


    }
}