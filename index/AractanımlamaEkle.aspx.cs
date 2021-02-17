using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;using System.Data.SqlClient;using System.Data;
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
        lbl1.Text = "Arac Ekle";
    }
    protected void btnAracEkle2_Click(object sender, EventArgs e)
    {
        SqlConnection baglanti = system.baglan();
        SqlCommand cmd = new SqlCommand("insert into Arac_Tanimlama (arac_plakasi,firma_arac_no,arac_markasi,arac_modeli,model_yili) values(@arac_plakasi,@firma_arac_no,@arac_markasi,@arac_modeli,@model_yili) ", baglanti);

        cmd.Parameters.Add("arac_plakasi", txtAracplakasi.Text);
        cmd.Parameters.Add("firma_arac_no", txtFirmaaracno.Text);
        cmd.Parameters.Add("arac_markasi", txtAracmarkasi.Text);
        cmd.Parameters.Add("arac_modeli", txtAracmodeli.Text);
        cmd.Parameters.Add("model_yili", txtModelyili.Text);
        cmd.ExecuteNonQuery();
        Response.Redirect("AracTanimlama.aspx");
    }
}