<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ProductManager.Default" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Gerenciador de Produtos</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Gerenciador de Produtos</h1>
            <asp:GridView ID="GridViewProducts" runat="server" AutoGenerateColumns="true"></asp:GridView>
            <br />
            <asp:Button ID="btnAddProduct" runat="server" Text="Adicionar Produto" OnClick="btnAddProduct_Click" />
        </div>
    </form>
</body>
</html>
