<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PapaMichaels.Web.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div class="container">
        <h1>Papa Michael's Pizza</h1>
        <h4>Pizza to Code By</h4>

        <hr />
        <div class="form-group">
            <h5><strong>Size:</strong></h5>
            <asp:DropDownList ID="sizeDropDownList" runat="server" CssClass="form-control" AutoPostBack="true" OnSelectedIndexChanged="recalculateTotalCost">
                <asp:ListItem Text="Choose One..." Value="" Selected="True"/>
                <asp:ListItem Text="Small (12 inch - $12)" Value="Small" />
                <asp:ListItem Text="Medium (14 inch - $14)" Value="Medium" />
                <asp:ListItem Text="Large (16 inch - $16)" Value="Large" />
            </asp:DropDownList>
        </div>

        <br />

        <div class="form-group">
            <h5><strong>Crust: </strong></h5>
            <asp:DropDownList ID="crustDropDownList" runat="server" CssClass="form-control" AutoPostBack="true" OnSelectedIndexChanged="recalculateTotalCost">
                <asp:ListItem Text="Choose One..." Value="" Selected="True"/>
                <asp:ListItem Text="Regular" Value="Regular" />
                <asp:ListItem Text="Thin" Value="Thin" />
                <asp:ListItem Text="Thick (+ $2)" Value="Thick" />
            </asp:DropDownList>
        </div>
        
        <br />

        <div class="checkbox"><label><asp:CheckBox ID="sausageCheckBox" runat="server" AutoPostBack="true" OnCheckedChanged="recalculateTotalCost"/> Sausage (+ $2)</label></div>
        <div class="checkbox"><label><asp:CheckBox ID="pepperoniCheckBox" runat="server" AutoPostBack="true" OnCheckedChanged="recalculateTotalCost"/> Pepperoni (+ $1.50)</label></div>
        <div class="checkbox"><label><asp:CheckBox ID="onionsCheckBox" runat="server" AutoPostBack="true" OnCheckedChanged="recalculateTotalCost"/> Onions (+ $1)</label></div>
        <div class="checkbox"><label><asp:CheckBox ID="greenPeppersCheckBox" runat="server" AutoPostBack="true" OnCheckedChanged="recalculateTotalCost"/> Green Peppers (+ $1)</label></div>

        <br />

        <h2>Deliver to: </h2>

        <div class="form-group">
            <h5><strong>Name:</strong></h5>
            <asp:TextBox ID="nameTextBox" runat="server" CssClass="form-control"></asp:TextBox>
        </div>

        <div class="form-group">
            <h5><strong>Address:</strong></h5>
            <asp:TextBox ID="addressTextBox" runat="server" CssClass="form-control"></asp:TextBox>
        </div>

        <div class="form-group">
            <h5><strong>Zip Code:</strong></h5>
            <asp:TextBox ID="zipCodeTextBox" runat="server" CssClass="form-control"></asp:TextBox>
        </div>

        <div class="form-group">
            <h5><strong>Phone Number:</strong></h5>
            <asp:TextBox ID="phoneNumberTextBox" runat="server" CssClass="form-control"></asp:TextBox>
        </div>

        <br />

        <h2>Payment:</h2>
        <!-- Text field -->

        <!-- Radio buttons -->
        <div class="radio"><label><asp:RadioButton ID="cashRadioButton" runat="server" /> Cash</label></div>
        <div class="radio"><label><asp:RadioButton ID="creditRadioButton" runat="server" /> Credit</label></div>

        <br />
        <br />

        <!-- Order button, info Bootstrap styled-->
        <asp:Button ID="orderButton" runat="server" Text="Order" CssClass="btn btn-lg btn-info" OnClick="orderButton_Click" />
        <br />
        <br />
        <p><asp:Label ID="validationLabel" runat="server" Text="" CssClass="bg-danger" Visible="false"></asp:Label></p>

        <br />
        <br />

        <h2>Total Cost:
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
        </h2>

    </div>
    </form>
    <script src="Scripts/jquery-1.9.1.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
</body>
</html>
