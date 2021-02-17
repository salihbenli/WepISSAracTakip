<%@ Page Title="" Language="C#" MasterPageFile="~/index/Site.master" AutoEventWireup="true" CodeFile="SürücüDetay.aspx.cs" Inherits="index_Default2" %>

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
                    NavigateUrl="SürücüEkle.aspx">Sürücü Ekle</asp:HyperLink></td>
        </tr>
        <table class="normal" width="100%">  
         <tr>
             <td width="14%">Araç Plakası</td>
             <td width="15%">Kişisel Bilgiler</td>
             <td width="14%">Kaza Bilgileri</td>
             <td width="13%">Ceza Puanları</td>
             <td width="14%">Ehliyet Bilgileri</td>
             <td width="11%">Günlük Sefer</td>
             <td width="20%">Yakıt Tüketimi</td>
          </tr>
      </table> 
        <tr>
            <td>
                <asp:DataList ID="dlSürücü" runat="server" CellPadding="4" ForeColor="#333333" Width="100%">
                    <AlternatingItemStyle BackColor="White" />
                    <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                    <ItemStyle BackColor="#E3EAEB" />
                    <ItemTemplate>
                         <table class="normal" width="100%">

                <tr>
                    <td width="14%"><%#Eval("Arac_plakasi") %></td>
                    <td width="17%"><%#Eval("Kisisel_bilgiler") %></td>
                    <td width="14%"><%#Eval("Kaza_bilgileri") %></td>
                    <td width="15%"><%#Eval("Ceza_puanlari") %></td>
                    <td width="15%"><%#Eval("Ehliyet_bilgileri") %></td>
                    <td width="10%"><%#Eval("Gunluk_sefer_hareketleri") %></td>
                    <td width="10%"><%#Eval("Yakit_tuketim_ortalamasi") %></td>
                    <td width="15%" align="right"  >
                    <a href="SürücüDüzenle.aspx?SurucuId=<%#Eval("SurucuId") %>"><img border="0" src="Images/edit.png" / ></a>
                     <a href="SürücüDetay.aspx?SurucuId=<%#Eval("SurucuId") %>&islem=Sil"><img src="Images/stopicon.jpg" /></a>
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

