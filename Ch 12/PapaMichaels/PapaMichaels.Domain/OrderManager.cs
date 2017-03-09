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
            // Validation
            if (orderDTO.Name.Trim().Length == 0)
                throw new Exception("Name is required.");

            orderDTO.OrderId = Guid.NewGuid();
            orderDTO.TotalCost = PizzaPriceManager.calculateCost(orderDTO);

            Persistence.OrderRepository.CreateOrder(orderDTO);
        }
    }
}
