<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="exemploCheck.Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    <h1>Exemplo CheckBox</h1>
    <br />
    
    <hr style="margin-bottom: 0px" />
    <h3>Selecione a Disciplina</h3>
        <asp:DropDownList ID="DropDownList1" runat="server" Font-Size="Larger" 
            onselectedindexchanged="DropDownList1_SelectedIndexChanged">
            <asp:ListItem>TPI</asp:ListItem>
            <asp:ListItem>LPOO</asp:ListItem>
            <asp:ListItem>AS</asp:ListItem>
            <asp:ListItem>GSO</asp:ListItem>
            <asp:ListItem>TLBD</asp:ListItem>
        </asp:DropDownList>
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Ok" 
            style="height: 26px" />
        <br />
        <asp:Label ID="lblSelecionado" runat="server"></asp:Label>
        <h3>Cursos Etec:</h3>
        <asp:CheckBox ID="CheckBox1" runat="server" Text="Informática" />
        <br />

        <asp:CheckBox ID="CheckBox2" runat="server" Text="Alimentos" />
        <br />
        <asp:CheckBox ID="CheckBox3" runat="server" Text="AgroIndustria" />
        <br />
        <asp:Button ID="Button2" runat="server" onclick="Button2_Click" Text="Ok" />
        <br />
        <asp:Label ID="Label1" runat="server" Font-Size="Larger"></asp:Label>
        <br />
        <asp:ListBox ID="ListBox1" runat="server" SelectionMode="Multiple">
            <asp:ListItem>TPI</asp:ListItem>
            <asp:ListItem>LPOO</asp:ListItem>
            <asp:ListItem>AS</asp:ListItem>
            <asp:ListItem>GSO</asp:ListItem>
            <asp:ListItem>TLBD</asp:ListItem>
        </asp:ListBox>

    <br />





    </div>
    </form>
</body>
</html>
