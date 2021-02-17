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

    string SürücüId = "";
    Fonksiyon system = new Fonksiyon();

    protected void Page_Load(object sender, EventArgs e)
    {

        SürücüId = Request.QueryString["SurucuId"];

        DataRow drSurucu = system.GetDataRow("select * from Surucu_Detay where SurucuId=" + SürücüId);
        if (drSurucu != null)
        {
            if (Page.IsPostBack == false)
            {
                txtAracplakasi3.Text = drSurucu["Arac_plakasi"].ToString();
                txtKisisel.Text = drSurucu["Kisisel_bilgiler"].ToString();
                txtKaza.Text = drSurucu["Kaza_bilgileri"].ToString();
                txtCeza.Text = drSurucu["Ceza_puanlari"].ToString();
                txtEhliyet.Text = drSurucu["Ehliyet_bilgileri"].ToString();
                txtGünlük.Text = drSurucu["Gunluk_sefer_hareketleri"].ToString();
                txtYakit.Text = drSurucu["Yakit_tuketim_ortalamasi"].ToString();
            }
        }
    }
    protected void btnSürücüDuzenle_Click(object sender, EventArgs e)
    {
        SqlConnection baglanti = system.baglan();
        SqlCommand cmd = new SqlCommand("update Surucu_Detay set Arac_plakasi=@Arac_plakasi,Kisisel_bilgiler=@Kisisel_bilgiler,Kaza_bilgileri=@Kaza_bilgileri,Ceza_puanlari=@Ceza_puanlari,Ehliyet_bilgileri=@Ehliyet_bilgileri,Gunluk_sefer_hareketleri=@Gunluk_sefer_hareketleri,Yakit_tuketim_ortalamasi=@Yakit_tuketim_ortalamasi where SurucuId=" + SürücüId, baglanti);

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