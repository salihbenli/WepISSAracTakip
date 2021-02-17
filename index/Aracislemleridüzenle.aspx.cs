using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.SqlClient;


public partial class index_Default2 : System.Web.UI.Page
{
    string Arac_isId = "";
    Fonksiyon system = new Fonksiyon();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["AdminId"] == null)
        {
            Response.Redirect("Login.aspx");
        }
        Arac_isId = Request.QueryString["Arac_isId"];

        DataRow drArac_isId = system.GetDataRow("select * from Arac_İslemleri where Arac_isId=" + Arac_isId);
        if (drArac_isId != null)
        {
            if (Page.IsPostBack == false)
            {
                txtAracplakasi.Text = drArac_isId["Arac_Plakasi"].ToString();
                txtSigortaislemleri.Text = drArac_isId["Sigorta_islemleri"].ToString();
                txtCezaislemleri.Text = drArac_isId["Ceza_islemleri"].ToString();
                txtKazaislemleri.Text = drArac_isId["Kaza_islemleri"].ToString();
                txtAracmuayene.Text = drArac_isId["Arac_muayeneleri"].ToString();
                txtOGS.Text = drArac_isId["OGS_KGS_giderleri"].ToString();
            }
        }
    }

    protected void btnDüzenle_Click(object sender, EventArgs e)
    {
        SqlConnection baglanti = system.baglan();
        SqlCommand cmd = new SqlCommand("update Arac_İslemleri set Arac_Plakasi=@Arac_Plakasi,Sigorta_islemleri=@Sigorta_islemleri,Ceza_islemleri=@Ceza_islemleri,Kaza_islemleri=@Kaza_islemleri,Arac_muayeneleri=@Arac_muayeneleri,OGS_KGS_giderleri=@OGS_KGS_giderleri where Arac_isId=" + Arac_isId, baglanti);

        cmd.Parameters.Add("Arac_Plakasi", txtAracplakasi.Text);
        cmd.Parameters.Add("Sigorta_islemleri", txtSigortaislemleri.Text);
        cmd.Parameters.Add("Ceza_islemleri", txtCezaislemleri.Text);
        cmd.Parameters.Add("Kaza_islemleri", txtKazaislemleri.Text);
        cmd.Parameters.Add("Arac_muayeneleri", txtAracmuayene.Text);
        cmd.Parameters.Add("OGS_KGS_giderleri", txtOGS.Text);


        cmd.ExecuteNonQuery();
        Response.Redirect("Aracİslemleri.aspx");
    }
}