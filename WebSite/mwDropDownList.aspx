<%@ Page Language="C#" AutoEventWireup="true" CodeFile="mwDropDownList.aspx.cs" Inherits="mwDropDownList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem>Select...</asp:ListItem>
                <asp:ListItem>A</asp:ListItem>
                <asp:ListItem>B</asp:ListItem>
            </asp:DropDownList>
        <%--
        HTML:
        <select name="DropDownList1" id="DropDownList1">
            <option value="Select...">Select...</option>
            <option value="A">A</option>
            <option value="B">B</option>
        </select>
        --%>
        </div>
    </form>
</body>
</html>
