using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Ayarlar
/// </summary>
public class Ayarlar
{
	public Ayarlar()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public static string Temizle(string Metin)
    {
        string deger = Metin;

        deger = deger.Replace("'", "");
        deger = deger.Replace("<", "");
        deger = deger.Replace(">", "");
        deger = deger.Replace("&", "");
        deger = deger.Replace("[", "");
        deger = deger.Replace("]", "");

        return deger;
    }
    

    

   }