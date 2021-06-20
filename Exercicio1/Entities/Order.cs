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
        public Client Client { get; set; } = new Client();

        #endregion

        #region Construtores

        public Order() { }

        public Order(Client client)
        {
            Client = client;
        }

        public Order(DateTime moment, OrderStatus orderStatus, List<OrderItem> orderItems, Client client)
        {
            Moment = moment;
            OrderStatus = orderStatus;
            OrderItems = orderItems;
            Client = client;
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
