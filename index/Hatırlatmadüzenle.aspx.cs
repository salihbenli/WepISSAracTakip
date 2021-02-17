using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data.SqlClient;
using System.Data;
using System.Web.UI.WebControls;

public partial class index_Default2 : System.Web.UI.Page
{
    string HatırId = "";
    Fonksiyon system = new Fonksiyon();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["AdminId"] == null)
        {
            Response.Redirect("Login.aspx");
        }
        HatırId = Request.QueryString["Hatirlatma_Id"];

        DataRow drHatır = system.GetDataRow("select * from Hatirlatma_İslemleri where Hatirlatma_Id=" + HatırId);
        if (drHatır != null)
        {
            if (Page.IsPostBack == false)
            {
                txtAracplakasi2.Text = drHatır["Arac_Plakasi"].ToString();
                txtGaranti.Text = drHatır["Garanti_Durumu"].ToString();
                txtSigorta.Text = drHatır["Sigorta"].ToString();
                txtVize.Text = drHatır["Vize"].ToString();
                txtMail.Text = drHatır["Mail"].ToString();
            }
        }
    }
    protected void btnHatırDuzenle_Click(object sender, EventArgs e)
    {
        SqlConnection baglanti = system.baglan();
        SqlCommand cmd = new SqlCommand("update Hatirlatma_İslemleri set Arac_Plakasi=@Arac_Plakasi,Garanti_Durumu=@Garanti_Durumu,Sigorta=@Sigorta,Vize=@Vize,Mail=@Mail where Hatirlatma_Id=" + HatırId, baglanti);

        cmd.Parameters.Add("Arac_Plakasi", txtAracplakasi2.Text);
        cmd.Parameters.Add("Garanti_Durumu", txtGaranti.Text);
        cmd.Parameters.Add("Sigorta", txtSigorta.Text);
        cmd.Parameters.Add("Vize", txtVize.Text);
        cmd.Parameters.Add("Mail", txtMail.Text);
        cmd.ExecuteNonQuery();
        Response.Redirect("Hatırlatmaİslemleri.aspx");
    }
}