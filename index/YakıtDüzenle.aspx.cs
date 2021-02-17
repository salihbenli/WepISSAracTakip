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
    string YakitId = "";
    Fonksiyon system = new Fonksiyon();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["AdminId"] == null)
        {
            Response.Redirect("Login.aspx");
        }

        YakitId = Request.QueryString["Yakit_Id"];

       DataRow drYakit = system.GetDataRow("select * from Yakit_Takip where Yakit_Id=" + YakitId);
       if (drYakit != null)
        {
            if (Page.IsPostBack == false)
            {
                txtAracplakasi4.Text = drYakit["Arac_Plakasi"].ToString();
                txtYakit.Text = drYakit["Yakit_Türü"].ToString();
                txtYakıtalım.Text = drYakit["Yakit_Alim_Tarihi"].ToString();
                txtKM.Text = drYakit["Alisin_KMsi"].ToString();
                txtMiktar.Text = drYakit["Alinan_Miktar"].ToString();
                txtToplam.Text = drYakit["Toplam_Tutar"].ToString();
            }
        }
    }

    protected void btnYakitDuzenle_Click(object sender, EventArgs e)
    {
        SqlConnection baglanti = system.baglan();
        SqlCommand cmd = new SqlCommand("update Yakit_Takip set Arac_Plakasi=@Arac_Plakasi,Yakit_Türü=@Yakit_Türü,Yakit_Alim_Tarihi=@Yakit_Alim_Tarihi,Alisin_KMsi=@Alisin_KMsi,Alinan_Miktar=@Alinan_Miktar,Toplam_Tutar=@Toplam_Tutar where Yakit_Id=" + YakitId, baglanti);

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