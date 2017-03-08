using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PapaMichaels.DTO.Enums;

namespace PapaMichaels.Web
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void orderButton_Click(object sender, EventArgs e)
        {
            var order = buildOrder();
            Domain.OrderManager.CreateOrder(order);
        }

        private DTO.Enums.PaymentType determinePaymentType()
        {
            DTO.Enums.PaymentType paymentType;
            if (cashRadioButton.Checked)
            {
                paymentType = DTO.Enums.PaymentType.Cash;
            }
            else 
            {
                paymentType = DTO.Enums.PaymentType.Credit;
            }

            return paymentType;
        }

        private DTO.Enums.CrustType determineCrust()
        {
            DTO.Enums.CrustType crust;
            if (!Enum.TryParse(crustDropDownList.SelectedValue, out crust))
            {
                throw new Exception("Pizza crust not selected...");
            }
            return crust;
        }

        private DTO.Enums.SizeType determineSize()
        {
            DTO.Enums.SizeType size;
            if (!Enum.TryParse(sizeDropDownList.SelectedValue, out size))
            {
                throw new Exception("Pizza size not selected...");
            }
            return size;
        }

        protected void recalculateTotalCost(object sender, EventArgs e)
        {
            if (sizeDropDownList.SelectedValue == String.Empty)
                return;
            if (crustDropDownList.SelectedValue == String.Empty)
                return;

            var order = buildOrder();
            resultLabel.Text = Domain.PizzaPriceManager.calculateCost(order).ToString("C");
            


        }

        private DTO.OrderDTO buildOrder()
        {
            var order = new DTO.OrderDTO();
            order.Size = determineSize();
            order.Crust = determineCrust();
            order.Sausage = sausageCheckBox.Checked;
            order.Pepperoni = pepperoniCheckBox.Checked;
            order.Onions = onionsCheckBox.Checked;
            order.GreenPeppers = greenPeppersCheckBox.Checked;
            order.Name = nameTextBox.Text;
            order.Zip = zipCodeTextBox.Text;
            order.Address = addressTextBox.Text;
            order.Phone = phoneNumberTextBox.Text;

            order.PaymentType = determinePaymentType();

            return order;
        }
    }
}