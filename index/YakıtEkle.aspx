<%@ Page Title="" Language="C#" MasterPageFile="~/index/Site.master" AutoEventWireup="true" CodeFile="YakıtEkle.aspx.cs" Inherits="index_Default3" %>


<asp:Content ID="Content12" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
          <table class="style1">
        <tr>
            <td class="style2">
                Araç Plakası</td>
            <td>
                <asp:TextBox ID="txtAracplakasi4" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style2">
                Yakıt Türü</td>
            <td>
                <asp:TextBox ID="txtYakit" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style2">
                Yakıt Alım</td>
            <td>
                <asp:TextBox ID="txtYakıtalım" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style2">
             Alışın KMsi</td>
            <td>
                <asp:TextBox ID="txtKM" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style2">
                Alınan Miktar</td>
            <td>
                <asp:TextBox ID="txtMiktar" runat="server"></asp:TextBox>
            </td>
        </tr><tr>
            <td class="style2">
                Toplam Tutar</td>
            <td>
                <asp:TextBox ID="txtToplam" runat="server"></asp:TextBox>
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
                <asp:Button ID="btnYakitEkle" runat="server" onclick="btnYakitEkle_Click" 
                    Text="Ekle" />
            </td>
        </tr>
    </table></p>
</asp:Content>

