<%@ Page Title="" Language="C#" MasterPageFile="~/index/Site.master" AutoEventWireup="true" CodeFile="SürücüEkle.aspx.cs" Inherits="index_Default2" %>


<asp:Content ID="Content12" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
          <table class="style1">
        <tr>
            <td class="style2">
                Araç Plakası</td>
            <td>
                <asp:TextBox ID="txtAracplakasi3" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style2">
                Kişisel Bilgiler</td>
            <td>
                <asp:TextBox ID="txtKisisel" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style2">
                Kaza Bilgileri</td>
            <td>
                <asp:TextBox ID="txtKaza" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style2">
                Ceza</td>
            <td>
                <asp:TextBox ID="txtCeza" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style2">
                Ehliyet Bilgileri</td>
            <td>
                <asp:TextBox ID="txtEhliyet" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style2">
                Günlük Sefer Hareketleri</td>
            <td>
                <asp:TextBox ID="txtGünlük" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style2">
               Yakıt Tüketim Ortalaması</td>
            <td>
                <asp:TextBox ID="txtYakit" runat="server"></asp:TextBox>
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
                <asp:Button ID="btnSürücüEkle" runat="server" onclick="btnSürücüEkle_Click" 
                    Text="Ekle" />
            </td>
        </tr>
    </table></p>
</asp:Content>

