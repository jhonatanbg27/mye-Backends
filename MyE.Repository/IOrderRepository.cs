using MyE.Entity;
using System.Collections.Generic;

namespace MyE.Repository
{
    public interface IOrderRepository:ICrudRepository<Order>
    {
     //    IEnumerable<Order> GetOrderByUser(int userId);
         IEnumerable<Order> GetOrderByMedical(int medicalequipmentId);
    }
}