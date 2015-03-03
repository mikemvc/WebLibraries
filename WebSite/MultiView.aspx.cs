using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MultiView : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    // 載入View控制項事件
    protected void View1_Activate(object sender, EventArgs e)
    {
        Response.Write("=== View1_Activate ===<br />");
    }
    // 載入View控制項事件
    protected void View3_Activate(object sender, EventArgs e)
    {
        Response.Write("=== View3_Activate ===<br />");
    }
    // 變更View控制項事件
    protected void MultiView1_ActiveViewChanged(object sender, EventArgs e)
    {
        Response.Write("=== MultiView1_ActiveViewChanged ===");
    }
}