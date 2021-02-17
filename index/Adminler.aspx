<%@ Page Title="" Language="C#" MasterPageFile="~/index/Site.master" AutoEventWireup="true" CodeFile="Adminler.aspx.cs" Inherits="index_Default2" %>

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
                    NavigateUrl="AdminEkle.aspx">Admin Ekle</asp:HyperLink></td>
        </tr>
         <table class="normal" width="100%">  
         <tr>
             <td width="20%">Adı Soyadı</td>
             <td width="19%">Görevi </td>
             <td width="20%">Kullanıcı Adı</td>
             <td width="21%"> Şifre</td>
              <td width="18%"> </td>
             
          </tr>
      </table> 
        <tr>
            <td>
    <asp:DataList ID="dlAdminler" runat="server" CellPadding="4" ForeColor="#333333" 
        onselectedindexchanged="DataList1_SelectedIndexChanged" Width="100%">
        <AlternatingItemStyle BackColor="White" />
        <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <ItemStyle BackColor="#E3EAEB" />
        <ItemTemplate>
      
             <table class="normal" width="100%">

                <tr>
                    <td width="20%"><%#Eval("AdiSoyadi") %></td>
                    <td width="20%"><%#Eval("Gorevi") %></td>
                    <td width="20%"><%#Eval("KullaniciAdi") %></td>
                    <td width="22%"><%#Eval("Sifre") %></td>
                    <td width="20%" align="right"  >
                    <a href="AdminDüzenle.aspx?AdminId=<%#Eval("AdminId") %>"><img border="0" src="Images/edit.png" / ></a>
                     <a href="Adminler.aspx?AdminId=<%#Eval("AdminId") %>&islem=Sil"><img src="Images/stopicon.jpg" /></a>
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

