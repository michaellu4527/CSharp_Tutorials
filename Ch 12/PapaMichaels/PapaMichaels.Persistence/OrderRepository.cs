using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PapaMichaels.Persistence
{
    public class OrderRepository
    {
        public static void CreateOrder()
        {
            var db = new PapaMichaelsDbEntities();
            var order = new Order();

            order.OrderId = Guid.NewGuid();
            order.Size = 1;
            order.Crust = 0;
            order.Pepperoni = true;
            order.Name = "Test";
            order.Address = "123 Elm";
            order.Zip = "039384";
            order.Phone = "938-293-2999";
            order.PaymentType = 0;
            order.TotalCost = 16.50M;   // Want a "decimal" data type so we need the M

            db.Orders.Add(order);
            db.SaveChanges();

        }
    }
}
