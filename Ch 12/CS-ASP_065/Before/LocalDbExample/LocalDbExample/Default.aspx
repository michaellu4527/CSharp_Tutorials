

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="LocalDbExample.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
         <h2>Customers</h2>
         <asp:GridView ID="customersGridView" runat="server">
         </asp:GridView>
         <br />
         <br />
         Name: <asp:TextBox ID="nameTextBox" runat="server"></asp:TextBox>
         <br />
         <br />
         Address:
         <asp:TextBox ID="addressTextBox" runat="server"></asp:TextBox>
         <br />
         <br />
         City:
         <asp:TextBox ID="cityTextBox" runat="server"></asp:TextBox>
         <br />
         <br />
         State:
         <asp:TextBox ID="stateTextBox" runat="server"></asp:TextBox>
         <br />
         <br />
         Zip Code:
         <asp:TextBox ID="zipTextBox" runat="server"></asp:TextBox>
         <br />
         <br />
         Notes:
         <asp:TextBox ID="notesTextBox" runat="server"></asp:TextBox>
         <br />
         <br />
         <br />
         <asp:Button ID="saveDataButton" runat="server" Text="Save Data" OnClick="saveDataButton_Click" style="height: 26px" />
         <br />
         <br />
         <asp:Label ID="resultLabel" runat="server"></asp:Label>
    </div>
    </form>
</body>
</html>
