//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Dbsys.AppData
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tickets
    {
        public int ticketID { get; set; }
        public Nullable<int> showtimeID { get; set; }
        public int sectionNumber { get; set; }
        public int rowNumber { get; set; }
        public int seatNumber { get; set; }
    
        public virtual Showtimes Showtimes { get; set; }
    }
}