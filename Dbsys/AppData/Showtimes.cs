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
    
    public partial class Showtimes
    {
        public Showtimes()
        {
            this.Tickets = new HashSet<Tickets>();
        }
    
        public int showtimeID { get; set; }
        public Nullable<int> movieID { get; set; }
        public System.DateTime showDate { get; set; }
        public System.TimeSpan startTime { get; set; }
        public System.TimeSpan endTime { get; set; }
        public int ticketsSold { get; set; }
        public int capacity { get; set; }
    
        public virtual Movie Movie { get; set; }
        public virtual ICollection<Tickets> Tickets { get; set; }
    }
}
