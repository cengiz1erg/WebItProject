using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
using WebItProject.Models.Entities;

namespace WebItProject.Models.Identity
{
    public class ApplicationUser : IdentityUser
    {
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(50)]
        public string Surname { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public virtual List<Address> Addresses { get; set; }
        public virtual List<Subscription> Subscriptions { get; set; }
    }
}