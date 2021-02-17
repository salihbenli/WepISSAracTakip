<%@ Page Title="" Language="C#" MasterPageFile="~/index/Site.master" AutoEventWireup="true" CodeFile="Aracİslemleri.aspx.cs" Inherits="index_Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
    </style>
</asp:Content>

<asp:Content ID="Content8" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="style1" width="100%">
        <tr>
            <td>
               <img alt="" class="style2" src="Images/ekle.gif" />
                <asp:HyperLink ID="HyperLink2" runat="server" CssClass="ekle" 
                    NavigateUrl="AracİslemleriEkle.aspx">Araç İşlemleri Ekle</asp:HyperLink></td>
        </tr>
         <table class="normal" width="100%">  
         <tr>
             <td width="12%">Araç Plakası</td>
             <td width="15%">Sigorta İşlemleri</td>
             <td width="20%">Ceza İşlemleri</td>
             <td width="17%">Kaza İşlemleri</td>
             <td width="17%">Araç Muayeneleri</td>
             <td width="22%">OGS KGS Gidereleri</td>
          </tr>
      </table> 
        <tr>
            <td>
                <asp:DataList ID="dlAracİs" runat="server" CellPadding="4" ForeColor="#333333" 
                    Width="100%">
                    <AlternatingItemStyle BackColor="White" />
                    <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                    <ItemStyle BackColor="#E3EAEB" />
                    <ItemTemplate>
                           <table class="normal" width="100%">

                <tr>
                    <td width="12%"><%#Eval("Arac_Plakasi") %></td>
                    <td width="13%"><%#Eval("Sigorta_islemleri") %></td>
                    <td width="25%"><%#Eval("Ceza_islemleri") %></td>
                    <td width="15%"><%#Eval("Kaza_islemleri") %></td>
                     <td width="20%"><%#Eval("Arac_muayeneleri") %></td>
                      <td width="10%"><%#Eval("OGS_HGS_giderleri") %></td>
                    <td width="10%" align="right"  >
                    <a href="Aracislemleridüzenle.aspx?Arac_isId=<%#Eval("Arac_isId") %>"><img border="0" src="Images/edit.png" / ></a>
                     <a href="Aracİslemleri.aspx?Arac_isId=<%#Eval("Arac_isId") %>&islem=Sil"><img src="Images/stopicon.jpg" /></a>
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

