<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="deleteEmp.aspx.cs" Inherits="deleteEmp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentBody" Runat="Server">


     <div style="margin: 1rem;padding: 2rem 2rem;text-align: center;">
        <div style="display: inline-block;padding: 1rem 1rem;vertical-align: middle;">
            <table style="width: 111%; height: 75px;">

        <tr>
            <td>Delete Employee  Age Grater Than 58 </td>
            <td class="auto-style1">
                <asp:Button ID="btn_delete" runat="server" Text="delete" Width="81px" OnClick="btn_delete_Click"  />
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
        </div>

        <div style="display: inline-block;padding: 1rem 1rem;vertical-align: middle;">
            <asp:GridView ID="GridView1" runat="server"></asp:GridView>
        </div>

    </div>
</asp:Content>



