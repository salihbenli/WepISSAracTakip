using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

public partial class index_Default2 : System.Web.UI.Page
{
    Fonksiyon system = new Fonksiyon();
    string AracId = "";
    string islem = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["AdminId"] == null)
        {
            Response.Redirect("Login.aspx");
        }
AracId = Request.QueryString["AracId"];
        islem = Request.QueryString["islem"];
        if (islem == "Sil")
        {
            system.cmd("delete from Arac_Tanimlama where AracId=" + AracId);
            Response.Redirect("AracTanimlama.aspx");
        }
   Label lbl1 = (Label)Master.FindControl("lblSayfaBaslik");
            lbl1.Text = "Araç Tanımlama";
            AdminCek();
        }
        void AdminCek()
        {
            DataTable dtArac = system.GetDataTable("select * from Arac_Tanimlama");
            dlArac.DataSource = dtArac;
            dlArac.DataBind();
        }
    }
