<%@ Page Title="" Language="C#" MasterPageFile="~/index/Site.master" AutoEventWireup="true" CodeFile="YakıtTakip.aspx.cs" Inherits="index_Default3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
    </style>
</asp:Content>

<asp:Content ID="Content8" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="style1">
        <tr>
            <td>
                <img alt="" class="style2" src="Images/ekle.gif" />
                <asp:HyperLink ID="HyperLink2" runat="server" CssClass="ekle" 
                    NavigateUrl="YakıtEkle.aspx">Yakıt Ekle</asp:HyperLink></td>
        </tr>
        <table class="normal" width="100%">  
         <tr>
             <td width="15%">Araç Plakası</td>
             <td width="12%">Yakıt Türü</td>
             <td width="17%">Yakıt Alım Tarihi</td>
             <td width="18%">Alışın KM'si</td>
             <td width="16%">Alınan Miktar</td>
             <td width="22%">Toplam Tutar</td>
            
          </tr>
      </table> 
        <tr>
            <td>
                <asp:DataList ID="dlYakıt" runat="server" CellPadding="4" ForeColor="#333333" Width="100%">
                    <AlternatingItemStyle BackColor="White" />
                    <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                    <ItemStyle BackColor="#E3EAEB" />
                    <ItemTemplate>
                       <table class="normal" width="100%">

                <tr>
                    <td width="16%"><%#Eval("Arac_Plakasi") %></td>
                    <td width="13%"><%#Eval("Yakit_Türü") %></td>
                    <td width="18%"><%#Eval("Yakit_Alim_Tarihi") %></td>
                    <td width="18%"><%#Eval("Alisin_KMsi") %></td>
                    <td width="15%"><%#Eval("Alinan_Miktar") %></td>
                    <td width="15%"><%#Eval("Toplam_Tutar") %></td>
                    <td width="20%" align="right"  >
                    <a href="YakıtDüzenle.aspx?Yakit_Id=<%#Eval("Yakit_Id") %>"><img border="0" src="Images/edit.png" / ></a>
                     <a href="YakıtTakip.aspx?Yakit_Id=<%#Eval("Yakit_Id") %>&islem=Sil"><img src="Images/stopicon.jpg" /></a>
                    </td>
                </tr>
            </table>
                    </ItemTemplate>
                    <SelectedItemStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                </asp:DataList>
            </td>
        </tr>
    </table>
</asp:Content>

