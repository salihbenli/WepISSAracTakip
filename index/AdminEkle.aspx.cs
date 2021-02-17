using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class index_Default2 : System.Web.UI.Page
{  Fonksiyon system = new Fonksiyon();
       
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["AdminId"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            Label lbl1 = (Label)Master.FindControl("lblSayfaBaslik");
            lbl1.Text = "Admin Ekle";
        }

        protected void btnEkle_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = system.baglan();
            SqlCommand cmd = new SqlCommand("insert into Adminler(AdiSoyadi,Gorevi,KullaniciAdi,Sifre) values(@AdiSoyadi,@Gorevi,@KullaniciAdi,@Sifre)", baglanti);
            cmd.Parameters.Add("AdiSoyadi",txtAdiSoyadi.Text);
            cmd.Parameters.Add("Gorevi", txtGorevi.Text);
            cmd.Parameters.Add("KullaniciAdi", txtKullaniciAdi.Text);
            cmd.Parameters.Add("Sifre", txtSifre.Text);
            cmd.ExecuteNonQuery();
            Response.Redirect("Adminler.aspx");
        }
    }
 