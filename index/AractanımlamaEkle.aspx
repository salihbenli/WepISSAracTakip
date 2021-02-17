<%@ Page Title="" Language="C#" MasterPageFile="~/index/Site.master" AutoEventWireup="true" CodeFile="AractanımlamaEkle.aspx.cs" Inherits="index_Default3" %>


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
                Firma Araç No</td>
            <td>
                <asp:TextBox ID="txtFirmaaracno" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style2">
                Araç Markası</td>
            <td>
                <asp:TextBox ID="txtAracmarkasi" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style2">
                 Araç Modeli</td>
            <td>
                <asp:TextBox ID="txtAracmodeli" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style2">
                 Model Yılı</td>
            <td>
                <asp:TextBox ID="txtModelyili" runat="server"></asp:TextBox>
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
                <asp:Button ID="btnAracEkle2" runat="server" onclick="btnAracEkle2_Click" 
                    Text="Ekle" />
            </td>
        </tr>
    </table></p>
</asp:Content>

