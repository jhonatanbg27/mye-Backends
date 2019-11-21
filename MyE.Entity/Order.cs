using System;

namespace MyE.Entity
{
    public class Order
    {
        public int OrderId {get;set;}
        public int Priority {get;set;}
        public DateTime Date {get;set;}
        public string description {get;set;}
        public virtual int UserId{get;set;}
        public virtual int MedicalEquipamentId {get;set;}
    }
}