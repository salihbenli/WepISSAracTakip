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
       
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["AdminId"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            Label lbl1 = (Label)Master.FindControl("lblSayfaBaslik");
            lbl1.Text = "Araç İşlemleri Ekle";
        }

        protected void btnEkle_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = system.baglan();
            SqlCommand cmd = new SqlCommand("insert into Arac_İslemleri(Arac_plakasi, Sigorta_islemleri, Ceza_islemleri, Kaza_islemleri, Arac_muayeneleri, OGS_HGS_giderleri) values(@Arac_plakasi, @Sigorta_islemleri, @Ceza_islemleri, @Kaza_islemleri, @Arac_muayeneleri, @OGS_HGS_giderleri)", baglanti);
            cmd.Parameters.Add("Arac_plakasi", txtAracplakasi.Text);
            cmd.Parameters.Add("Sigorta_islemleri", txtSigortaislemleri.Text);
            cmd.Parameters.Add("Ceza_islemleri", txtCezaislemleri.Text);
            cmd.Parameters.Add("Kaza_islemleri", txtKazaislemleri.Text);
            cmd.Parameters.Add("Arac_muayeneleri", txtAracmuayene.Text);
            cmd.Parameters.Add("OGS_HGS_giderleri", txtOGS.Text);
            cmd.ExecuteNonQuery();
            Response.Redirect("Aracİslemleri.aspx");
    }
}