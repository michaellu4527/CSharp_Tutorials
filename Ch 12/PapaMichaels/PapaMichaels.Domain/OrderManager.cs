using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PapaMichaels.Domain
{
    public class OrderManager
    {
        public static void CreateOrder(DTO.OrderDTO orderDTO)
        {
            //var order = new DTO.OrderDTO();

            //order.OrderId = Guid.NewGuid();
            //order.Size = DTO.Enums.SizeType.Large;
            //order.Crust = DTO.Enums.CrustType.Thick;
            //order.Pepperoni = true;
            //order.Name = "Test";
            //order.Address = "123 Elm";
            //order.Zip = "039384";
            //order.Phone = "938-293-2999";
            //order.PaymentType = DTO.Enums.PaymentType.Credit;
            //order.TotalCost = 16.50M;   // Want a "decimal" data type so we need the M

            Persistence.OrderRepository.CreateOrder(orderDTO);
        }
    }
}
