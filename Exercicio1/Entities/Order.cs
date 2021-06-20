using System;
using System.Collections.Generic;

using Exercicio1.Entities.Enums;

namespace Exercicio1.Entities
{
    class Order
    {
        #region Propriedades

        public DateTime Moment { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

        #endregion

        #region Construtores

        public Order() { }

        public Order(DateTime moment, OrderStatus orderStatus)
        {
            Moment = moment;
            OrderStatus = orderStatus;
        }

        #endregion

        #region Métodos

        public void AddItem(OrderItem item)
        {
            OrderItems.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            OrderItems.Remove(item);
        }

        public double Total()
        {
            double total = 0;

            foreach(OrderItem item in OrderItems)
            {
                total += item.SubTotal();
            }

            return total;
        }

        #endregion
    }
}
