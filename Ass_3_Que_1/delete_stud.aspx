<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="delete_stud.aspx.cs" Inherits="delete_stud" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="content" runat="server">
    <form id="form1" runat="server">
        <div>

            <table class="auto-style1" style="margin-top: 30px;">
                <tr>
                    <td class="auto-style1">Delete By Course: </td>
                    <td class="auto-style2">
                        <asp:TextBox ID="TextBox1" runat="server" Height="40px" Width="280px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">Delete By Roll No:</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="TextBox2" runat="server" Height="40px" Width="280px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style2">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5"></td>
                    <td class="auto-style2">
                        <asp:Button ID="BtnDelete" runat="server" Font-Bold="True" Font-Size="15pt" Text="Delete Record" Style="padding: 10px;" Width="200px" OnClick="Button1_Click" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style7">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4" colspan="2">
                        <asp:GridView ID="GridView1" align="center" runat="server" Width="647px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged1">
                            <Columns>
                                <asp:ButtonField ButtonType="Button" CommandName="Select" HeaderText="Action" ShowHeader="True" Text="Select" />
                            </Columns>
                        </asp:GridView>
                    </td>
                </tr>
            </table>

        </div>
    </form>
</asp:Content>


