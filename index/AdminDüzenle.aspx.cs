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
  
        
        string AdminId = "";
        Fonksiyon system = new Fonksiyon();
       
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["AdminId"] == null)
            {
                Response.Redirect("Login.aspx");
            }

            AdminId = Request.QueryString["AdminId"];

            DataRow drAdmin = system.GetDataRow("select * from Adminler where AdminId="+AdminId);
            if (drAdmin != null)
            {
                if (Page.IsPostBack == false)
                {
                    txtAdiSoyadi.Text = drAdmin["AdiSoyadi"].ToString();
                    txtGorevi.Text = drAdmin["Gorevi"].ToString();
                    txtKullaniciAdi.Text = drAdmin["KullaniciAdi"].ToString();
                    txtSifre.Text = drAdmin["Sifre"].ToString();
                }
            }
        }

        protected void btnDuzenle_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = system.baglan();
 SqlCommand cmd = new SqlCommand("update Adminler set AdiSoyadi=@AdiSoyadi,Gorevi=@Gorevi,KullaniciAdi=@KullaniciAdi,Sifre=@Sifre where AdminId="+AdminId,baglanti);
               
            cmd.Parameters.Add("AdiSoyadi", txtAdiSoyadi.Text);
            cmd.Parameters.Add("Gorevi", txtGorevi.Text);
            cmd.Parameters.Add("KullaniciAdi", txtKullaniciAdi.Text);
            cmd.Parameters.Add("Sifre", txtSifre.Text);
            cmd.ExecuteNonQuery();
            Response.Redirect("Adminler.aspx");
        }
    }
    
