using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data;
using System.Data.SqlClient;
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
            lbl1.Text = "Hatırlatma Ekle";
        }
        protected void btnHatırEkle_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = system.baglan();
            SqlCommand cmd = new SqlCommand("insert into Hatirlatma_İslemleri (Arac_plakasi, Garanti_Durumu, Sigorta, Vize, Mail) values(@Arac_plakasi, @Garanti_Durumu, @Sigorta, @Vize, @Mail)", baglanti);
            cmd.Parameters.Add("Arac_Plakasi", txtAracplakasi2.Text);
            cmd.Parameters.Add("Garanti_Durumu", txtGaranti.Text);
            cmd.Parameters.Add("Sigorta", txtSigorta.Text);
            cmd.Parameters.Add("Vize", txtVize.Text);
            cmd.Parameters.Add("Mail", txtMail.Text);
            cmd.ExecuteNonQuery();
            Response.Redirect("Hatırlatmaİslemleri.aspx");
        }
}
