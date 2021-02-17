<%@ Page Title="" Language="C#" MasterPageFile="~/index/Site.master" AutoEventWireup="true" CodeFile="Hatırlatmaİslemleri.aspx.cs" Inherits="index_Default2" %>

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
                    NavigateUrl="Hatırlatmaekle.aspx">Hatırlatma Ekle</asp:HyperLink></td>
        </tr>
    <table class="normal" width="100%">  
         <tr>
             <td width="15%">Araç Plakası</td>
             <td width="15%">Garanti Durumu </td>
             <td width="17%">Sigorta</td>
             <td width="18%"> Vize</td>
             <td width="20%"> Mail</td>
          </tr>
      </table> 
        <tr>
            <td>
                <asp:DataList ID="dlHatır" runat="server" CellPadding="4" ForeColor="#333333" 
                   Width="100%">
                    <AlternatingItemStyle BackColor="White" />
                    <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                    <ItemStyle BackColor="#E3EAEB" />
                    <ItemTemplate>
                         <table class="normal" width="100%">

                <tr>
                    <td width="18%"><%#Eval("Arac_Plakasi") %></td>
                    <td width="18%"><%#Eval("Garanti_Durumu") %></td>
                    <td width="20%"><%#Eval("Sigorta") %></td>
                    <td width="18%"><%#Eval("Vize") %></td>
                    <td width="20%"><%#Eval("Mail") %></td>
                    <td width="20%" align="right"  >
                    <a href="Hatırlatmadüzenle.aspx?Hatirlatma_Id=<%#Eval("Hatirlatma_Id") %>"><img border="0" src="Images/edit.png" / ></a>
                     <a href="Hatırlatmaİslemleri.aspx?Hatirlatma_Id=<%#Eval("Hatirlatma_Id") %>&islem=Sil"><img src="Images/stopicon.jpg" /></a>
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

