using System;

using EnumeracoesComposicao.Entities;
using EnumeracoesComposicao.Entities.Enums;

namespace EnumeracoesComposicao
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order.ToString());
        }
    }
}
