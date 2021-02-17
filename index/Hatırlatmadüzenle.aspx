<%@ Page Title="" Language="C#" MasterPageFile="~/index/Site.master" AutoEventWireup="true" CodeFile="Hatırlatmadüzenle.aspx.cs" Inherits="index_Default2" %>


<asp:Content ID="Content12" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        <table class="style1">
        <tr>
            <td class="style2">
                Araç Plakası</td>
            <td>
                <asp:TextBox ID="txtAracplakasi2" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style2">
                Garanti Durumu</td>
            <td>
                <asp:TextBox ID="txtGaranti" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style2">
                Sigorta</td>
            <td>
                <asp:TextBox ID="txtSigorta" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style2">
               Vize </td>
            <td>
                <asp:TextBox ID="txtVize" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style2">
               Mail </td>
            <td>
                <asp:TextBox ID="txtMail" runat="server"></asp:TextBox>
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
                <asp:Button ID="btnHatırDuzenle" runat="server" onclick="btnHatırDuzenle_Click" 
                    Text="Düzenle" />
            </td>
        </tr>
    </table></p>
</asp:Content>

