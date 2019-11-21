using System.Collections.Generic;

namespace MyE.Entity
{
    public class MachineReview
    {
        public int Id {get;set;}
        public int EngineerId {get;set;}

        public virtual ICollection<FinalReport> FinalReports { get; set; }
        //public virtual int UserId {get;set;} 
        public virtual int OrderId {get;set;} 

    }
}