using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PapaMichaels.Persistence
{
    public class PizzaPriceRespository
    {
        public static DTO.PizzaPriceDTO GetPizzaPrices()
        {
            var db = new PapaMichaelsDbEntities();
            var prices = db.PizzaPrices.First();
            var dto = convertToDTO(prices);
            return dto;
        }

        private static DTO.PizzaPriceDTO convertToDTO(PizzaPrice pizzaPrice)
        {
            var dto = new DTO.PizzaPriceDTO();

            dto.SmallSizeCost = pizzaPrice.SmallSizeCost;
            dto.MediumSizeCost = pizzaPrice.MediumSizeCost;
            dto.LargeSizeCost = pizzaPrice.LargeSizeCost;
            dto.ThickCrustCost = pizzaPrice.ThickCrustCost;
            dto.ThinCrustCost = pizzaPrice.ThinCrustCost;
            dto.RegularCrustCost = pizzaPrice.RegularCrustCost;
            dto.PepperoniCost = pizzaPrice.PepperoniCost;
            dto.GreenPeppersCost = pizzaPrice.GreenPeppersCost;
            dto.SausageCost = pizzaPrice.SausageCost;
            dto.OnionsCost = pizzaPrice.OnionsCost;

            return dto;
        }
 
    }
}
