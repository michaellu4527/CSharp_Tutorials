<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengeFirstPapaBobsWebsite.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-family: Arial, Helvetica, sans-serif;
        }
        .auto-style2 {
            width: 200px;
            height: 200px;
        }
        .auto-style3 {
            color: #FF6600;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    &nbsp;
        <h2>&nbsp;<img alt="" class="auto-style2" src="PapaBob.png" /> <span class="auto-style1">Papa Bob&#39;s Pizza and Software</span></h2>
        <p>
            <asp:RadioButton ID="babySizeRadioButton" runat="server" Text="Baby Bob Size (10&quot;) - $10" GroupName="Size" />
            <br />
            <asp:RadioButton ID="mamaSizeRadioButton" runat="server" Text="Mama Bob Size (13&quot;) - $13" GroupName="Size" />
            <br />
            <asp:RadioButton ID="papaSizeRadioButton" runat="server" Text="Baby Bob Size (16&quot;) - $16" GroupName="Size" />
        </p>
        <p>
            <asp:RadioButton ID="thinCrustRadioButton" runat="server" GroupName="Style" Text="Thin Crust" />
            <br />
            <asp:RadioButton ID="deepDishRadioButton" runat="server" GroupName="Style" Text="Deep Dish (+$2)" />
        </p>
        <p>
            <asp:CheckBox ID="pepperoniCheckBox" runat="server" Text="Pepperoni (+$1.50)" />
            <br />
            <asp:CheckBox ID="onionsCheckBox" runat="server" Text="Onions (+$0.75)" />
            <br />
            <asp:CheckBox ID="greenPeppersCheckBox" runat="server" Text="Green Peppers (+$0.50)" />
            <br />
            <asp:CheckBox ID="redPeppersCheckBox" runat="server" Text="Red Peppers (+$0.75)" />
            <br />
            <asp:CheckBox ID="anchoviesCheckBox" runat="server" Text="Anchovies (+$2)" />
        </p>
        <h3>
            <span class="auto-style1">Papa Bob&#39;s <span class="auto-style3">Special Deal</span></span></h3>
        <p>
            Save $2.00 when you add Pepperoni, Green Peppers, and Anchovies OR Pepperoni, Red Peppers and Onions to your pizza.</p>
        <p>
            <asp:Button ID="purchaseButton" runat="server" Text="Purchase" OnClick="purchaseButton_Click" />
        </p>
        <p>
            Total: $<asp:Label ID="totalLabel" runat="server"></asp:Label>
        </p>
        <p>
            Sorry, at this time you can only order one pizza online, and pick-up only... we&#39;re working on making a better website!<br />
        </p>
        
    
    </div>
    </form>
</body>
</html>
