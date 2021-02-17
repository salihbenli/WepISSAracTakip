using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

using System.Data.SqlClient;

public partial class index_Default2 : System.Web.UI.Page
{
    Fonksiyon system = new Fonksiyon();
    string Arac_isId = "";
    string islem = "";

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["AdminId"] == null)
        {
            Response.Redirect("Login.aspx");
        }
        Arac_isId = Request.QueryString["Arac_isId"];
        islem = Request.QueryString["islem"];
        if (islem == "Sil")
        {
            system.cmd("delete from Arac_İslemleri where Arac_isId=" + Arac_isId);
            Response.Redirect("Aracİslemleri.aspx");
        }
        Label lbl1 = (Label)Master.FindControl("lblSayfaBaslik");
        lbl1.Text = "Araç İşlemleri";
        AdminCek();
    }
    void AdminCek()
    {
        DataTable dtAdminler = system.GetDataTable("select * from Arac_İslemleri");
        dlAracİs.DataSource = dtAdminler;
        dlAracİs.DataBind();
    }
}