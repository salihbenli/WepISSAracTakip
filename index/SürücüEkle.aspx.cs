using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;

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
            lbl1.Text = "Admin Ekle";
        }
    protected void  btnSürücüEkle_Click(object sender, EventArgs e)
    {
     SqlConnection baglanti = system.baglan();
     SqlCommand cmd = new SqlCommand("insert into Surucu_Detay(Arac_plakasi,Kisisel_bilgiler,Kaza_bilgileri,Ceza_puanlari,Ehliyet_bilgileri,Gunluk_sefer_hareketleri,Yakit_tuketim_ortalamasi) values(@Arac_plakasi,@Kisisel_bilgiler,@Kaza_bilgileri,@Ceza_puanlari,@Ehliyet_bilgileri,@Gunluk_sefer_hareketleri,@Yakit_tuketim_ortalamasi)", baglanti);

        cmd.Parameters.Add("Arac_plakasi", txtAracplakasi3.Text);
        cmd.Parameters.Add("Kisisel_bilgiler", txtKisisel.Text);
        cmd.Parameters.Add("Kaza_bilgileri", txtKaza.Text);
        cmd.Parameters.Add("Ceza_puanlari", txtCeza.Text);
        cmd.Parameters.Add("Ehliyet_bilgileri", txtEhliyet.Text);
        cmd.Parameters.Add("Gunluk_sefer_hareketleri", txtGünlük.Text);
        cmd.Parameters.Add("Yakit_tuketim_ortalamasi", txtYakit.Text);
        cmd.ExecuteNonQuery();
        Response.Redirect("SürücüDetay.aspx");
    }
}
