using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
 using System.Data.SqlClient;
using System.Data;
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
    protected void btnBakımEkle_Click(object sender, EventArgs e)
    {
        SqlConnection baglanti = system.baglan();
        SqlCommand cmd = new SqlCommand("insert into Bakim_Onarim(Arac_Plakasi,Bakim_Tarihi,Bakim_KMsi,Tutar,Firma_servis,Aciklamalar)values(@Arac_Plakasi,@Bakim_Tarihi,@Bakim_KMsi,@Tutar,@Firma_servis,@Aciklamalar)", baglanti);

        cmd.Parameters.Add("Arac_Plakasi", txtAracplakasi.Text);
        cmd.Parameters.Add("Bakim_Tarihi", txtBakımtarihi.Text);
        cmd.Parameters.Add("Bakim_KMsi", txtKMsi.Text);
        cmd.Parameters.Add("Tutar", txtTutar.Text);
        cmd.Parameters.Add("Firma_servis", txtFirma.Text);
        cmd.Parameters.Add("Aciklamalar", txtAcıklamalar.Text);
        cmd.ExecuteNonQuery();
        Response.Redirect("BakımveOnarım.aspx");
    }
}