<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengeConditionalRadioButton.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <h4>Your Note Taking Preferences</h4>
        <p>
            <asp:RadioButton ID="pencilRadioButton" runat="server" GroupName="Utensils" Text="Pencil" />
        </p>
        <p>
            <asp:RadioButton ID="penRadioButton" runat="server" GroupName="Utensils" Text="Pen" />
        </p>
        <p>
            <asp:RadioButton ID="phoneRadioButton" runat="server" GroupName="Utensils" Text="Phone" />
        </p>
        <p>
            <asp:RadioButton ID="tabletRadioButton" runat="server" GroupName="Utensils" Text="Tablet" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="okButton" runat="server" OnClick="okButton_Click" Text="OK" ViewStateMode="Disabled" />
        </p>
        <p>
            <asp:Image ID="resultImage" runat="server" />
        </p>
        <p>
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
        </p>
    
    </div>
    </form>
</body>
</html>
