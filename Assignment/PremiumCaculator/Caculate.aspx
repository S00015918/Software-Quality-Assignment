<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Caculate.aspx.cs" Inherits="PremiumCaculator.Caculate" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Caculate your premium !</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        <hr />
        <asp:TextBox ID="txtAge" Text="Age" runat="server"></asp:TextBox>
        <hr />
        <asp:TextBox ID="txtGender" Text="Gender" runat="server"></asp:TextBox>
        <hr />      
         <asp:Button ID="BtnCalculate" runat="server" Text="Calculate" OnClick="BtnCalculate_Click" />
        <br />
        <br />
        
        <asp:Label ID="lblResult" runat="server" Text=""></asp:Label>
         </div>
    </form>
</body>
</html>
