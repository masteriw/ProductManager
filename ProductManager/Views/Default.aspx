<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ProductManager.Views.Default" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Gerenciador de Produtos</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Gerenciador de Produtos</h1>
            <asp:GridView ID="GridViewProducts" runat="server" AutoGenerateColumns="false">
                <Columns>
                    <asp:BoundField DataField="ProductID" HeaderText="ID" />
                    <asp:BoundField DataField="ProductName" HeaderText="Nome do Produto" />
                    <asp:BoundField DataField="Price" HeaderText="Preço" DataFormatString="{0:C}" />
                    <asp:TemplateField HeaderText="Ações">
                        <ItemTemplate>
                            <a href='<%# Eval("ProductID", "EditDeleteProduct/{0}") %>'>Editar</a>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
            <br />
            <asp:Button ID="btnAddProduct" runat="server" Text="Adicionar Produto" OnClick="btnAddProduct_Click" />
            <asp:Button ID="btnEditDeleteProduct" runat="server" Text="Editar/Deletar Produto" OnClick="btnEditDeleteProduct_Click" />
        </div>
    </form>
</body>
</html>
