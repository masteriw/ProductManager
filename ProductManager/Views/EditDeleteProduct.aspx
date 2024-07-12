<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditDeleteProduct.aspx.cs" Inherits="ProductManager.Views.EditDeleteProduct" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Editar/Deletar Produto</title>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
    <script type="text/javascript">
        function updateHiddenField() {
            var txtPrice = document.getElementById("<%= txtPrice.ClientID %>");
            var hiddenField = document.getElementById("<%= hiddenTxtField.ClientID %>");
            hiddenField.value = txtPrice.value;
        }

        function syncHiddenFieldAndSubmit(buttonId) {
            updateHiddenField();
            document.getElementById(buttonId).click();
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Editar/Deletar Produto</h1>
            <asp:Label ID="lblProductId" runat="server" Text="ID do Produto:"></asp:Label>
            <asp:TextBox ID="txtProductId" runat="server"></asp:TextBox>
            <asp:Button ID="btnLoadProduct" runat="server" Text="Carregar Produto" OnClick="btnLoadProduct_Click" />
            <br />
            <asp:Label ID="lblProductName" runat="server" Text="Nome do Produto:"></asp:Label>
            <asp:TextBox ID="txtProductName" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblPrice" runat="server" Text="Preço:"></asp:Label>
            <asp:TextBox ID="txtPrice" runat="server" onchange="updateHiddenField()"></asp:TextBox>
            <asp:HiddenField ID="hiddenTxtField" runat="server" />
            <br />
            <asp:Button ID="btnUpdate" runat="server" Text="Atualizar" OnClick="btnUpdate_Click" Style="display:none;" />
            <input type="button" value="Atualizar" onclick="syncHiddenFieldAndSubmit('btnUpdate')" />
            <asp:Button ID="btnDelete" runat="server" Text="Deletar" OnClick="btnDelete_Click" />
            <br />
            <asp:Label ID="lblResult" runat="server" ForeColor="Green" Visible="false"></asp:Label>
            <br />
            <asp:Button ID="btnHome" runat="server" Text="Home" OnClick="btnHome_Click" />
        </div>
    </form>
</body>
</html>
