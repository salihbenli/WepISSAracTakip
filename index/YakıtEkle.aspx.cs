using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Web;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class index_Default3 : System.Web.UI.Page
{
    Fonksiyon system = new Fonksiyon();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["AdminId"] == null)
        {
            Response.Redirect("Login.aspx");
        }
        Label lbl1 = (Label)Master.FindControl("lblSayfaBaslik");
        lbl1.Text = "Admin Ekle";
    }
    protected void btnYakitEkle_Click(object sender, EventArgs e)
    {
        SqlConnection baglanti = system.baglan();
        SqlCommand cmd = new SqlCommand("insert into Yakit_Takip (Arac_Plakasi,Yakit_Türü,Yakit_Alim_Tarihi,Alisin_KMsi,Alinan_Miktar,Toplam_Tutar) values(@Arac_Plakasi,@Yakit_Türü,@Yakit_Alim_Tarihi,@Alisin_KMsi,@Alinan_Miktar,@Toplam_Tutar)", baglanti);
        cmd.Parameters.Add("Arac_Plakasi", txtAracplakasi4.Text);
        cmd.Parameters.Add("Yakit_Türü", txtYakit.Text);
        cmd.Parameters.Add("Yakit_Alim_Tarihi", txtYakıtalım.Text);
        cmd.Parameters.Add("Alisin_KMsi", txtKM.Text);
        cmd.Parameters.Add("Alinan_Miktar", txtMiktar.Text);
        cmd.Parameters.Add("Toplam_Tutar", txtToplam.Text);
        cmd.ExecuteNonQuery();
        Response.Redirect("YakıtTakip.aspx");
    }
}