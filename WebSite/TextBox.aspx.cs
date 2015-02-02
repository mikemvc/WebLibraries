using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class TextBox : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    // GetValue
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (!String.IsNullOrEmpty(TextBox1.Text))
            Response.Write("您所輸入的文字是: " + TextBox1.Text);
    }
    // SetValue
    protected void Button2_Click(object sender, EventArgs e)
    {
        TextBox1.Text = "TextBox1的文字，重新設定";        
    }
}