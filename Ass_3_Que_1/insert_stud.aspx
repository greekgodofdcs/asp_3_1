<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="insert_stud.aspx.cs" Inherits="insert_stud" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" runat="server">

    <form id="form1" runat="server">
        <table class="auto-style1" style="margin-top: 30px;">
            <tr>
                <td class="auto-style3">Enrollment No:</td>
                <td class="auto-style6">
                    <asp:TextBox ID="TextBox6" runat="server" Height="40px" Width="280px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Roll No:</td>
                <td class="auto-style6">
                    <asp:TextBox ID="TextBox2" runat="server" Height="40px" Width="280px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Student Name :</td>
                <td class="auto-style6">
                    <asp:TextBox ID="TextBox3" runat="server" Height="40px" Width="280px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Course Name: </td>
                <td class="auto-style6">
                    <asp:DropDownList ID="DropDownList1" runat="server" Height="40px" Width="280px">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Class Name:</td>
                <td class="auto-style6">
                    <asp:DropDownList ID="DropDownList2" runat="server" Height="40px" Width="280px">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">E-mail:</td>
                <td class="auto-style5">
                    <asp:TextBox ID="TextBox4" runat="server" Height="40px" Width="280px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">Mobile:</td>
                <td class="auto-style5">
                    <asp:TextBox ID="TextBox5" runat="server" Height="40px" Width="280px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Date Of Birth:</td>
                <td class="auto-style5">
                    <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5"></td>
                <td class="auto-style6">
                    <asp:Button ID="BtnAdd" runat="server" Font-Bold="True" Font-Size="15pt" Text="Add Class" Style="padding: 10px;" Width="200px" OnClick="Button1_Click" />
                </td>
            </tr>
            <tr>
                <td class="auto-style7">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4" colspan="2">
                    <asp:GridView ID="GridView1" align="center" runat="server" Width="647px">
                    </asp:GridView>
                </td>
            </tr>
        </table>
    </form>
</asp:Content>

