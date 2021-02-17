<%@ Page Title="" Language="C#" MasterPageFile="~/index/Site.master" AutoEventWireup="true" CodeFile="AdminDüzenle.aspx.cs" Inherits="index_Default2" %>

<asp:Content ID="Content12" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        <table class="style1">
        <tr>
            <td class="style2">
                Adı Soyadı:</td>
            <td>
                <asp:TextBox ID="txtAdiSoyadi" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style2">
                Görevi</td>
            <td>
                <asp:TextBox ID="txtGorevi" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style2">
                Kullanıcı Adı</td>
            <td>
                <asp:TextBox ID="txtKullaniciAdi" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style2">
                Şifre</td>
            <td>
                <asp:TextBox ID="txtSifre" runat="server"></asp:TextBox>
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
                <asp:Button ID="btnDuzenle" runat="server" onclick="btnDuzenle_Click" 
                    Text="Düzenle" />
            </td>
        </tr>
    </table></p>
</asp:Content>

