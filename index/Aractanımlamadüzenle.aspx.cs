using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class index_Default2 : System.Web.UI.Page
{
    
string AracId = "";
        Fonksiyon system = new Fonksiyon();
       
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["AdminId"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            AracId = Request.QueryString["AracId"];

            DataRow drArac = system.GetDataRow("select * from Arac_Tanimlama where AracId="+AracId);
            if (drArac != null)
            {
                if (Page.IsPostBack == false)
                {
                    txtAracplakasi.Text = drArac["Arac_Plakasi"].ToString();
                    txtFirmaaracno.Text = drArac["Firma_arac_no"].ToString();
                    txtAracmarkasi.Text = drArac["Arac_markasi"].ToString();
                    txtAracmodeli.Text = drArac["Arac_modeli"].ToString();
                    txtModelyili.Text = drArac["Model_yili"].ToString();
                }
            }
        }

  
        protected void btnAracDuzenle2_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = system.baglan();
            SqlCommand cmd = new SqlCommand("update Arac_Tanimlama set Arac_Plakasi=@Arac_Plakasi,Firma_arac_no=@Firma_arac_no,Arac_markasi=@Arac_markasi,Arac_modeli=@Arac_modeli,Model_yili=@Model_yili where AracId=" + AracId, baglanti);

            cmd.Parameters.Add("Arac_Plakasi", txtAracplakasi.Text);
            cmd.Parameters.Add("Firma_arac_no", txtFirmaaracno.Text);
            cmd.Parameters.Add("Arac_markasi", txtAracmarkasi.Text);
            cmd.Parameters.Add("Arac_modeli", txtAracmodeli.Text);
            cmd.Parameters.Add("Model_yili", txtModelyili.Text);
            cmd.ExecuteNonQuery();
            Response.Redirect("AracTanimlama.aspx");
        }
}