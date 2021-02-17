<%@ Page Title="" Language="C#" MasterPageFile="~/index/Site.master" AutoEventWireup="true" CodeFile="AracİslemleriEkle.aspx.cs" Inherits="index_Default2" %>


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
                Vergi İşlemleri</td>
            <td>
                <asp:TextBox ID="txtVergiislemleri" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style2">
                Sigorta İşlemleri</td>
            <td>
                <asp:TextBox ID="txtSigortaislemleri" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style2">
                Ceza İşlemleri</td>
            <td>
                <asp:TextBox ID="txtCezaislemleri" runat="server"></asp:TextBox>
            </td>
        </tr>
         <tr>
            <td class="style2">
                Kaza İşlemleri</td>
            <td>
                <asp:TextBox ID="txtKazaislemleri" runat="server"></asp:TextBox>
            </td>
        </tr>
         <tr>
            <td class="style2">
                Araç Muayeneleri</td>
            <td>
                <asp:TextBox ID="txtAracmuayene" runat="server"></asp:TextBox>
            </td>
        </tr>
         <tr>
            <td class="style2">
                OGS-KGS&nbsp; Ödemeleri</td>
            <td>
                <asp:TextBox ID="txtOGS" runat="server"></asp:TextBox>
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
                <asp:Button ID="btnAracEkle" runat="server" onclick="btnEkle_Click" 
                    Text="Ekle" />
            </td>
        </tr></p>
</asp:Content>

