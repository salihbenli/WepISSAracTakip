<%@ Page Title="" Language="C#" MasterPageFile="~/index/Site.master" AutoEventWireup="true" CodeFile="BakımveOnarım.aspx.cs" Inherits="index_Default4" %>

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
                    NavigateUrl="Bakımveonarımekle.aspx">Bakım Ekle</asp:HyperLink></td>
        </tr>
         <table class="normal" width="100%">  
         <tr>
             <td width="12%">Araç Plakası</td>
             <td width="11%">Bakım Tarihi</td>
             <td width="12%">Bakım KM'si</td>
             <td width="9%">Tutar</td>
             <td width="22%">Firma Servis</td>
             <td width="22%">Açıklamalar</td>
            
          </tr>
      </table> 
        <tr>
            <td>
                <asp:DataList ID="dlBakım" runat="server" CellPadding="4" ForeColor="#333333" Width="100%">
                    <AlternatingItemStyle BackColor="White" />
                    <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                    <ItemStyle BackColor="#E3EAEB" />
                    <ItemTemplate>
                         <table class="normal" width="100%">

                <tr>
                    <td width="14%"><%#Eval("Arac_Plakasi") %></td>
                    <td width="13%"><%#Eval("Bakim_Tarihi") %></td>
                    <td width="13%"><%#Eval("Bakim_KMsi") %></td>
                    <td width="10%"><%#Eval("Tutar") %></td>
                    <td width="15%"><%#Eval("Firma_Servis") %></td>
                    <td width="30%"><%#Eval("Aciklamalar") %></td>
                    <td width="20%" align="right"  >
                    <a href="Bakımveonarımdüzenle.aspx?Bakim_Id=<%#Eval("Bakim_Id") %>"><img border="0" src="Images/edit.png" / ></a>
                     <a href="BakımveOnarım.aspx?Bakim_Id=<%#Eval("Bakim_Id") %>&islem=Sil"><img src="Images/stopicon.jpg" /></a>
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

