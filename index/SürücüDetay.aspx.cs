using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class index_Default2 : System.Web.UI.Page
{
    Fonksiyon system = new Fonksiyon();
    string SurucuId = "";
    string islem = "";

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["AdminId"] == null)
        {
            Response.Redirect("Login.aspx");
        }
        SurucuId = Request.QueryString["SurucuId"];
        islem = Request.QueryString["islem"];
        if (islem == "Sil")
        {
            system.cmd("delete from Surucu_Detay where SurucuId=" + SurucuId);
            Response.Redirect("SürücüDetay.aspx");
        }
        Label lbl1 = (Label)Master.FindControl("lblSayfaBaslik");
        lbl1.Text = "Sürücü Detay";
        AdminCek();
    }
    void AdminCek()
    {
        DataTable dtSürücü = system.GetDataTable("select * from Surucu_Detay");
        dlSürücü.DataSource = dtSürücü;
        dlSürücü.DataBind();
    }
}