using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class index_Default3 : System.Web.UI.Page
{
    Fonksiyon system = new Fonksiyon();
    string Yakit = "";
    string islem = "";

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["AdminId"] == null)
        {
            Response.Redirect("Login.aspx");
        }
        Yakit= Request.QueryString["Yakit_Id"];
        islem = Request.QueryString["islem"];
        if (islem == "Sil")
        {
            system.cmd("delete from Yakit_Takip where Yakit_Id=" + Yakit);
            Response.Redirect("YakıtTakip.aspx");
        }
        Label lbl1 = (Label)Master.FindControl("lblSayfaBaslik");
        lbl1.Text = "Yakıt Takip";
        AdminCek();
    }
    void AdminCek()
    {
        DataTable dtYakıt = system.GetDataTable("select * from Yakit_Takip");
        dlYakıt.DataSource = dtYakıt;
        dlYakıt.DataBind();
    }
}