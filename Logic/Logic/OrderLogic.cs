using Data;
using Entities.Entities;
using Logic.ILogic;
using Resources.FilterModels;
using Resources.RequestModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Logic
{
    public class OrderLogic : BaseContextLogic, IOrderLogic
    {
        public OrderLogic(ServiceContext serviceContext) : base(serviceContext) { }

        public int AddOrder(OrderItem orderItem)
        {
            _serviceContext.Orders.Add(orderItem);
            _serviceContext.SaveChanges();
            return orderItem.Id;
        }

        public void DeactivateOrder(int id)
        {
            var orderToDeactivate = _serviceContext.Set<OrderItem>()
           .Where(i => i.Id == id).First();

            orderToDeactivate.IsActive = false;

            _serviceContext.SaveChanges();
        }

        public List<OrderItem> GetAllOrder()
        {
            return _serviceContext.Set<OrderItem>().ToList();
        }

        public List<OrderItem> GetOrderByCriteria(OrderFilter orderFilter)
        {
            var resultList = _serviceContext.Set<OrderItem>()
                                .Where(p => p.IsActive == true);

            if (orderFilter.OrderDateFrom != null)
            {
                resultList = resultList.Where(p => p.OrderDate > orderFilter.OrderDateFrom);
            }

            if (orderFilter.OrderDateTo != null)
            {
                resultList = resultList.Where(p => p.OrderDate < orderFilter.OrderDateTo);
            }

            return resultList.ToList();
        }

        public void UpdateOrder(OrderItem orderItem)
        {
            _serviceContext.Orders.Update(orderItem);
            _serviceContext.SaveChanges();
        }

    }
}
