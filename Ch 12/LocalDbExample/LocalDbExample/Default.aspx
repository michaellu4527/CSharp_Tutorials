﻿

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="LocalDbExample.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        
        <br />
        <asp:GridView ID="customersGridView" runat="server">
        </asp:GridView>
        <br />
        <br />
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
        
        <br />
        <br />
        <br />
        
    </div>
    </form>
</body>
</html>
