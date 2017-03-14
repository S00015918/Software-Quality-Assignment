<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CaculatePremium._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Caculate your premium !</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <hr />
       Age: <asp:TextBox ID="TextBoxAge" runat="server"></asp:TextBox>
        <hr />
       Gender: <asp:TextBox ID="TextBoxGender" runat="server"></asp:TextBox>
        <hr />      
         <asp:Button ID="BtnCalculate" runat="server" Text="Calculate" OnClick="BtnCalculate_Click" />
        <br />
        <br />
        
        <asp:Label ID="LabelResult" runat="server" Text=""></asp:Label>
         </div>
    </form>
</body>
</html>


</asp:Content>
