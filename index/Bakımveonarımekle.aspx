<%@ Page Title="" Language="C#" MasterPageFile="~/index/Site.master" AutoEventWireup="true" CodeFile="Bakımveonarımekle.aspx.cs" Inherits="index_Default3" %>


<asp:Content ID="Content12" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        
              <table class="style1">
        <tr>
            <td class="style2">
               Araç Plakası</td>
            <td>
                <asp:TextBox ID="txtAracplakasi" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style2">
                Bakım Tarihi</td>
            <td>
                <asp:TextBox ID="txtBakımtarihi" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style2">
                Bakım KM'si</td>
            <td>
                <asp:TextBox ID="txtKMsi" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style2">
                Tutar</td>
            <td>
                <asp:TextBox ID="txtTutar" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style2">
                Firma Servis</td>
            <td>
                <asp:TextBox ID="txtFirma" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style2">
                Açıklamalar</td>
            <td>
                <asp:TextBox ID="txtAcıklamalar" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style2">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                &nbsp;</td>
            <td>
                <asp:Button ID="btnBakımEkle" runat="server" onclick="btnBakımEkle_Click" 
                    Text="Ekle" />
            </td>
        </tr>
    </table></p>
</asp:Content>

