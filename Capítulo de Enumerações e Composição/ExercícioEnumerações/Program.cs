using Activity.Entities;
using Activity.Entities.Enums;
using System;
using System.Globalization;
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order()
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };
            Console.WriteLine(order);
            string txt = OrderStatus.PendingPayment.ToString();/* conversão do tipo string para o tipo enum*/
            Console.WriteLine(txt);

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");/*conversão do tipo enum para o tipo string*/
            Console.WriteLine(os);
        }
    }
}