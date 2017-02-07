<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengePostalCalculatorHelperMethods.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <h2>Postal Calculator</h2>
        <br />
        Width:&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="widthTextBox" runat="server" AutoPostBack="True" OnTextChanged="handleChange"></asp:TextBox>
        <br />
        Height:&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="heightTextBox" runat="server" AutoPostBack="True" OnTextChanged="handleChange"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
        <br />
        Length:&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="lengthTextBox" runat="server" AutoPostBack="True" OnTextChanged="handleChange"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        <br />
        <asp:RadioButton ID="groundRadioButton" runat="server" AutoPostBack="True" GroupName="Type" OnCheckedChanged="handleChange" Text="Ground" />
        <br />
        <asp:RadioButton ID="airRadioButton" runat="server" AutoPostBack="True" GroupName="Type" OnCheckedChanged="handleChange" Text="Air" />
        <br />
        <asp:RadioButton ID="overnightRadioButton" runat="server" AutoPostBack="True" GroupName="Type" OnCheckedChanged="handleChange" Text="Overnight" />
        <br />
        <br />
        <br />
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
    
    </div>
    </form>
    <p>
        &nbsp;</p>
</body>
</html>
