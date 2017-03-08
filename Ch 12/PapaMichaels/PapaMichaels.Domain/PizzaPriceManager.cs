using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PapaMichaels.DTO;

namespace PapaMichaels.Domain
{
    public class PizzaPriceManager
    {
        public static decimal calculateCost(DTO.OrderDTO order)
        {
            decimal cost = 0.0M;
            var prices = getPizzaPrices();


            cost += calculateSizeCost(order, prices);
            cost += calculateCrustCost(order, prices);
            cost += calculateToppings(order, prices);

            return cost;
        }

        private static decimal calculateToppings(DTO.OrderDTO order, DTO.PizzaPriceDTO prices)
        {
            decimal cost = 0.0M;

            if (order.Sausage)
                cost += prices.SausageCost;
            else
                cost += 0M;

            if (order.Pepperoni) 
                cost += prices.PepperoniCost;
            else
                cost += 0M;

            if (order.GreenPeppers)
                cost += prices.GreenPeppersCost;
            else
                cost += 0M;

            if (order.Onions)
                cost += prices.OnionsCost;
            else
                cost += 0M;

            return cost;
        }

        private static decimal calculateCrustCost(DTO.OrderDTO order, DTO.PizzaPriceDTO prices)
        {
            decimal cost = 0.0M;

            switch (order.Crust)
            {
                case PapaMichaels.DTO.Enums.CrustType.Regular:
                    cost = prices.RegularCrustCost;
                    break;
                case PapaMichaels.DTO.Enums.CrustType.Thin:
                    cost = prices.ThinCrustCost;
                    break;
                case PapaMichaels.DTO.Enums.CrustType.Thick:
                    cost = prices.ThickCrustCost;
                    break;
                default:
                    break;
            }

            return cost;
        }

        private static decimal calculateSizeCost(DTO.OrderDTO order, DTO.PizzaPriceDTO prices)
        {
            decimal cost = 0.0M;

            switch (order.Size)
            {
                case PapaMichaels.DTO.Enums.SizeType.Small:
                    cost = prices.SmallSizeCost;
                    break;
                case PapaMichaels.DTO.Enums.SizeType.Medium:
                    break;
                case PapaMichaels.DTO.Enums.SizeType.Large:
                    break;
                default:
                    break;
            }

            return cost;
        }

        public static DTO.PizzaPriceDTO getPizzaPrices()
        {
            var prices = Persistence.PizzaPriceRespository.GetPizzaPrices();
            return prices;
        }
    }
}
