<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MultiView.aspx.cs" Inherits="MultiView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>MultiView</h3>
            <hr />
            <asp:MultiView ID="MultiView1" runat="server" ActiveViewIndex="0" OnActiveViewChanged="MultiView1_ActiveViewChanged">
                <asp:View ID="View1" runat="server" OnActivate="View1_Activate">
                    <h3>View 1</h3>
                    <asp:Button ID="Button1" runat="server" Text="上一個" CommandName="PrevView" />
                    <asp:Button ID="Button2" runat="server" Text="下一個" CommandName="NextView" /><br />
                    <br />
                    <asp:Button ID="Button3" runat="server" Text="前往View的ID=View3"
                        CommandName="SwitchViewByID" CommandArgument="View3" /><br />
                    <br />
                    <asp:Button ID="Button4" runat="server" Text="前往View的Index=1"
                        CommandName="SwitchViewByIndex" CommandArgument="1" />
                </asp:View>
                <asp:View ID="View2" runat="server">
                    <h3>View 2</h3>
                    <asp:Button ID="Button5" runat="server" Text="上一個" CommandName="PrevView" />
                    <asp:Button ID="Button6" runat="server" Text="下一個" CommandName="NextView" />
                </asp:View>
                <asp:View ID="View3" runat="server" OnActivate="View3_Activate">
                    <h3>View 3</h3>
                    <asp:Button ID="Button7" runat="server" Text="上一個" CommandName="PrevView" />
                    <asp:Button ID="Button8" runat="server" Text="下一個" CommandName="NextView" />
                </asp:View>
            </asp:MultiView>
            <hr />
            <h3>資料參考來源</h3>
            <asp:HyperLink ID="HyperLink1" runat="server" Target="_blank"
                NavigateUrl="http://www.tutorialspoint.com/asp.net/asp.net_multi_views.htm">
            http://www.tutorialspoint.com/asp.net/asp.net_multi_views.htm</asp:HyperLink>
        </div>
    </form>
</body>
</html>