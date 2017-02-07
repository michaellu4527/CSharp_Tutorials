<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MegaChallengeCasino.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <h1>Casino Royale</h1>
        
        <asp:Image ID="Image1" runat="server" Height="150px" Width="150px" />
        <asp:Image ID="Image2" runat="server" Height="150px" Width="150px" />
        <asp:Image ID="Image3" runat="server" Height="150px" Width="150px" />
        <br />
        <br />
        Your Bet:
        <asp:TextBox ID="betTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="leverButton" runat="server" OnClick="leverButton_Click" Text="Pull the Lever!" />
        <br />
        <br />
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Label ID="moneyLabel" runat="server"></asp:Label>
        <br />
        <br />
        <h4>Winning Combinations:</h4>
        
        1 Cherry - x2 Your Bet       
        <br />
        2 Cherries - x3 Your Bet<br />
        3 Cherries - x4 Your Bet<br />
        3 &quot;7&quot;s (Jackpot) - x100 Your Bet<br />
        <br />
        HOWEVER... if there&#39;s even 1 BAR, you automatically lose.</div>
    </form>
</body>
</html>
