<%@ Page Title="" Language="C#" MasterPageFile="~/index/Site.master" AutoEventWireup="true" CodeFile="AracTanimlama.aspx.cs" Inherits="index_Default2" %>

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
                    NavigateUrl="AractanımlamaEkle.aspx">Arac Ekle</asp:HyperLink></td>
        </tr>
        <table class="normal" width="100%">  
         <tr>
             <td width="16%">Araç Plakası</td>
             <td width="21%">Firma Araç No</td>
             <td width="19%">Araç Markası</td>
             <td width="21%">Araç Modeli</td>
              <td width="22%">Model Yılı</td>
             
          </tr>
      </table> 
        <tr>
            <td>
                <asp:DataList ID="dlArac" runat="server" CellPadding="4" 
        ForeColor="#333333" Width="100%">
                    <AlternatingItemStyle BackColor="White" />
                    <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                    <ItemStyle BackColor="#E3EAEB" />
                    <ItemTemplate>
                        <table class="style1" width="100%">
                             <tr>
                    <td width="20%"><%#Eval("Arac_Plakasi") %></td>
                    <td width="18%"><%#Eval("Firma_arac_no") %></td>
                    <td width="20%"><%#Eval("Arac_markasi") %></td>
                    <td width="20%"><%#Eval("Arac_modeli") %></td>
                      <td width="15%"><%#Eval("Model_yili") %></td>
                    <td width="20%" align="right"  >
                    <a href="Aractanımlamadüzenle.aspx?AracId=<%#Eval("AracId") %>"><img border="0" src="Images/edit.png" / ></a>
                     <a href="AracTanimlama.aspx?AracId=<%#Eval("AracId") %>&islem=Sil"><img src="Images/stopicon.jpg" /></a>
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

