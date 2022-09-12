<%@ Page Title="" Language="C#" MasterPageFile="~/adminHome.master" AutoEventWireup="true" CodeFile="AddClass.aspx.cs" Inherits="AddClass" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <center>
        <asp:Table runat="server"  CellPadding="10" CellSpacing="5">
            <asp:TableRow CssClass="alert-success text-center" BorderColor="Tomato" BorderStyle="Double">
                <asp:TableCell Font-Size="XX-Large" Font-Bold="true" ForeColor="#3333ff" ColumnSpan="3">Add Class</asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell><asp:Label ID="lblmsg" runat="server"></asp:Label></asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell Font-Size="Large">Name : </asp:TableCell>
                <asp:TableCell><asp:TextBox runat="server" ID="txtClass" BorderColor="#ccffcc" Font-Size="Large"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="RequiredFieldValidator" CssClass="text-danger" ToolTip="Name is Required.." ControlToValidate="txtClass" Text="*"></asp:RequiredFieldValidator></asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>Course :</asp:TableCell>
                <asp:TableCell><asp:DropDownList ID="ddlCourse" runat="server" CssClass="form-select"></asp:DropDownList></asp:TableCell>
                <asp:TableCell></asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell ColumnSpan="3" HorizontalAlign="Center" ><asp:Button CssClass="btn btn-outline-info" runat="server" ID="btnAdd" Text="Add" Font-Size="Larger" OnClick="btnAdd_Click" /></asp:TableCell>
            </asp:TableRow>
        </asp:Table>
    </center>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
</asp:GridView>
    </asp:Content>

