<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Empresas.aspx.cs" Inherits="UI.Empresas" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Empresas</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Empresas</h1>
            
            <asp:GridView ID="gridEmpresas" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="CNPJ" HeaderText="CNPJ" />
                    <asp:BoundField DataField="RazaoSocial" HeaderText="Razão Social" />
                    <asp:BoundField DataField="NomeFantasia" HeaderText="Nome Fantasia" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
