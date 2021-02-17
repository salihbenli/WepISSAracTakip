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
    string AdminId = "";
    string islem = "";

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["AdminId"] == null)
        {
            Response.Redirect("Login.aspx");
        }
        AdminId = Request.QueryString["AdminId"];
        islem = Request.QueryString["islem"];
        if (islem == "Sil")
        {
            system.cmd("delete from Adminler where AdminId=" + AdminId);
            Response.Redirect("Adminler.aspx");
        }
   Label lbl1 = (Label)Master.FindControl("lblSayfaBaslik");
            lbl1.Text = "Admin Yönetimi";
            AdminCek();
        }
        void AdminCek()
        {
            DataTable dtAdminler = system.GetDataTable("select * from Adminler");
            dlAdminler.DataSource = dtAdminler;
            dlAdminler.DataBind();
        }
    
    protected void DataList1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}