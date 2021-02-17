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
    string HatırlatmaId = "";
    string islem = "";

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["AdminId"] == null)
        {
            Response.Redirect("Login.aspx");
        }
        HatırlatmaId = Request.QueryString["Hatirlatma_Id"];
        islem = Request.QueryString["islem"];
        if (islem == "Sil")
        {
            system.cmd("delete from Hatirlatma_İslemleri where Hatirlatma_Id=" + HatırlatmaId);
            Response.Redirect("Hatırlatmaİslemleri.aspx");
        }
        Label lbl1 = (Label)Master.FindControl("lblSayfaBaslik");
        lbl1.Text = "Admin Yönetimi";
        AdminCek();
    }
    void AdminCek()
    {
        DataTable dtHatırlatma = system.GetDataTable("select * from Hatirlatma_İslemleri");
        dlHatır.DataSource = dtHatırlatma;
        dlHatır.DataBind();
    }
}