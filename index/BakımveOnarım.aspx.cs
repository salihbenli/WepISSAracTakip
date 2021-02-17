using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Web.UI;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

public partial class index_Default4 : System.Web.UI.Page
{
    Fonksiyon system = new Fonksiyon();
    string BakimId = "";
    string islem = "";

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["AdminId"] == null)
        {
            Response.Redirect("Login.aspx");
        }
        BakimId = Request.QueryString["Bakim_Id"];
        islem = Request.QueryString["islem"];
        if (islem == "Sil")
        {
            system.cmd("delete from Bakim_Onarim where Bakim_Id=" + BakimId);
            Response.Redirect("BakımveOnarım.aspx");
        }
        Label lbl1 = (Label)Master.FindControl("lblSayfaBaslik");
        lbl1.Text = "Bakım Onarım";
        AdminCek();
    }
    void AdminCek()
    {
        DataTable dtBakım = system.GetDataTable("select * from Bakim_Onarim");
        dlBakım.DataSource = dtBakım;
        dlBakım.DataBind();
    }
}