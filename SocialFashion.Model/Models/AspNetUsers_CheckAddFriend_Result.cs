//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SocialFashion.Model.Models
{
    using System;
    
    public partial class AspNetUsers_CheckAddFriend_Result
    {
        public string Id { get; set; }
        public string Hometown { get; set; }
        public string Email { get; set; }
        public bool EmailConfirmed { get; set; }
        public string PasswordHash { get; set; }
        public string SecurityStamp { get; set; }
        public string PhoneNumber { get; set; }
        public bool PhoneNumberConfirmed { get; set; }
        public bool TwoFactorEnabled { get; set; }
        public Nullable<System.DateTime> LockoutEndDateUtc { get; set; }
        public bool LockoutEnabled { get; set; }
        public int AccessFailedCount { get; set; }
        public string UserName { get; set; }
        public string Name { get; set; }
        public Nullable<System.DateTime> Birthdate { get; set; }
        public string Aboutme { get; set; }
        public string Website { get; set; }
        public Nullable<bool> Gender { get; set; }
        public string ConnectionId { get; set; }
        public Nullable<bool> IsOnline { get; set; }
    }
}
