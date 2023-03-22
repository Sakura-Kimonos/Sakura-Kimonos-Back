using Entities.Entities;
using Resources.FilterModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.ILogic
{
    public interface IOrderLogic
    {
        int AddOrder(OrderItem orderItem);
        List<OrderItem> GetAllOrder();
        List<OrderItem> GetOrderByCriteria(OrderFilter orderFilter);
        void DeactivateOrder(int id);
        void UpdateOrder(OrderItem orderItem);
    }
}
