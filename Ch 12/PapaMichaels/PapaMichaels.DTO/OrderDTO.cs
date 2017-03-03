using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PapaMichaels.DTO
{
    public class OrderDTO
    {
        public System.Guid OrderId { get; set; }
        public Nullable<PapaMichaels.DTO.Enums.SizeType> Size { get; set; }
        public Nullable<PapaMichaels.DTO.Enums.CrustType> Crust { get; set; }
        public Nullable<bool> Sausage { get; set; }
        public Nullable<bool> Pepperoni { get; set; }
        public Nullable<bool> Onions { get; set; }
        public Nullable<bool> GreenPeppers { get; set; }
        public decimal TotalCost { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Zip { get; set; }
        public string Phone { get; set; }
        public Nullable<PapaMichaels.DTO.Enums.PaymentType> PaymentType { get; set; }
        public Nullable<bool> Completed { get; set; }
    }
}
