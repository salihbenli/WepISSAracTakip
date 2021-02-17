using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Web.UI;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

public partial class index_Default2 : System.Web.UI.Page
{
    string Bakim_Id = "";
    Fonksiyon system = new Fonksiyon();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["AdminId"] == null)
        {
            Response.Redirect("Login.aspx");
        }

        Bakim_Id = Request.QueryString["Bakim_Id"];

        DataRow drBakim = system.GetDataRow("select * from Bakim_Onarim where Bakim_Id=" + Bakim_Id);
        if (drBakim != null)
        {
            if (Page.IsPostBack == false)
            {
                txtAracplakasi.Text = drBakim["Arac_Plakasi"].ToString();
                txtBakımtarihi.Text = drBakim["Bakim_Tarihi"].ToString();
                txtKMsi.Text = drBakim["Bakim_KMsi"].ToString();
                txtTutar.Text = drBakim["Tutar"].ToString();
                txtFirma.Text = drBakim["Firma_servis"].ToString();
                txtAcıklamalar.Text = drBakim["Aciklamalar"].ToString();
            }
        }
    }
    protected void btnBakımDuzenle_Click(object sender, EventArgs e)
    {

        SqlConnection baglanti = system.baglan();
        SqlCommand cmd = new SqlCommand("update Bakim_Onarim set Arac_Plakasi=@Arac_Plakasi,Bakim_Tarihi=@Bakim_Tarihi,Bakim_KMsi=@Bakim_KMsi,Tutar=@Tutar,Firma_servis=@Firma_servis,Aciklamalar=@Aciklamalar where Bakim_Id="+Bakim_Id, baglanti);

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