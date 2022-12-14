using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace libongo.Models
{
    public partial class AspNetUsers
    {
        [Key]
        public string Id { get; set; }
        public string UserName {get;set;} 
        public string NormalizedUserName {get;set;} 
        public string Email {get;set;} 
        public string NormalizedEmail {get;set;} 
        public bool EmailConfirmed {get;set;} 
        public string PasswordHash {get;set;} 
        public string SecurityStamp {get;set;} 
        public string ConcurrencyStamp {get;set;} 
        public string PhoneNumber {get;set;} 
        public bool PhoneNumberConfirmed {get;set;} 
        public bool TwoFactorEnabled {get;set;} 
        public String LockoutEnd {get;set;} 
        public bool LockoutEnabled {get;set;} 
        public int AccessFailedCount {get;set;}  
        public string PersonsId {get;set;} 
        [ForeignKey("PersonsId")]
        [InverseProperty("PersonsId")] 
        public virtual Persons Persons {get;set;}
        public virtual AspNetUserRoles AspNetUserRoles {get;set;}
    }
    
}
