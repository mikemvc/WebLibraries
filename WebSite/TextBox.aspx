<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TextBox.aspx.cs" Inherits="TextBox" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script src="//ajax.googleapis.com/ajax/libs/jquery/1.9.1/jquery.min.js"></script>
    <script>
        $(function () {
            // JavaScript GetValue
            $('#Button3').click(function () {
                var value = document.getElementById('<%=TextBox1.UniqueID%>').value;
                if (value.length > 0) alert(value);
            });
            // JavaScript SetValue
            $('#Button4').click(function () {
                var txt1 = document.getElementById('<%=TextBox1.UniqueID%>');
                var txt1String = prompt('請輸入TextBox1的文字', '');
                txt1.value = txt1String;
            });
            // JQuery GetValue
            $('#Button5').click(function () {
                var value = $('#<%=TextBox1.UniqueID%>').val();
                if (value.length > 0) alert(value);
            });
            // JQuery SetValue
            $('#Button6').click(function () {
                var txt1String = prompt('請輸入TextBox1的文字', '');
                if (txt1String.length > 0) $('#<%=TextBox1.UniqueID%>').val(txt1String);

            });
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br /><br />
        <asp:Button ID="Button1" runat="server" Text="GetValue" OnClick="Button1_Click" />　　
        <asp:Button ID="Button2" runat="server" Text="SetValue" OnClick="Button2_Click" /><br /><br /><hr />
        JavaScript的方式：<br />
        <asp:Button ID="Button3" runat="server" Text="JS_GetValue" />　　
        <asp:Button ID="Button4" runat="server" Text="JS_SetValue" /><br /><br /><hr />
        JQuery的方式：<br />
        <asp:Button ID="Button5" runat="server" Text="JQ_GetValue" />　　
        <asp:Button ID="Button6" runat="server" Text="JQ_SetValue" /><br /><br />
    </div>
    </form>
</body>
</html>
