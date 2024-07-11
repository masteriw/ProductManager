<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddProduct.aspx.cs" Inherits="ProductManager.AddProduct" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Adicionar Produto</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Adicionar Produto</h1>
            <asp:Label ID="lblProductName" runat="server" Text="Nome do Produto:"></asp:Label>
            <asp:TextBox ID="txtProductName" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblPrice" runat="server" Text="Preço:"></asp:Label>
            <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="btnSave" runat="server" Text="Salvar" OnClick="btnSave_Click" />
            <br />
            <asp:Label ID="lblResult" runat="server" ForeColor="Green" Visible="false"></asp:Label>
            <br />
            <asp:Button ID="btnHome" runat="server" Text="Home" OnClick="btnHome_Click" />
        </div>
    </form>
</body>
</html>
