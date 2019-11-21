namespace MyE.Entity
{
    public class MachineReview
    {
        public int Id {get;set;}
        public int EngineerId {get;set;}
        public virtual int OrderId{get;set;}
        public virtual int UserId {get;set;} 
    }
}