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
    using System.Collections.Generic;
    
    public partial class Fan
    {
        public int FanId { get; set; }
        public string SenderId { get; set; }
        public string RequestId { get; set; }
        public short Status { get; set; }
        public Nullable<System.DateTime> FriendShipDate { get; set; }
        public string Message { get; set; }
    }
}
