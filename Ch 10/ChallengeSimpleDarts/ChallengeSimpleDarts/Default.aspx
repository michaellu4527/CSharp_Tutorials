<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengeSimpleDarts.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <h1>Simple Darts</h1>
        <h4>&nbsp;Player 1:</h4>
        <asp:Button ID="throwDartButton1" runat="server" Text="Throw Dart!" OnClick="throwDartButton1_Click" />
        <br />
        <h4>Player 2:</h4>
        <br />
        <asp:Button ID="throwDartButton2" runat="server" Text="Throw Dart!" OnClick="throwDartButton2_Click" />
        <br />
        <br />
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
