<%@ Page Title="" Language="C#" MasterPageFile="~/adminHome.master" AutoEventWireup="true" CodeFile="updateStud.aspx.cs" Inherits="updateStud" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="container">
       <div class="row h3  text-capitalize text-center bg-secondary text-white shadow p-2 mb-4">
            <h3>Update emai id, mobile no and dob.</h3>
       </div>
       <div class="row m-2" style="text-align:left">
            <div class="col-sm-3">
                <asp:Label ID="Label3" runat="server" Text="Enter Mobile No."></asp:Label>
            </div>
            <div class="col-sm-4">
                <asp:TextBox ID="txtMono" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="col-sm-2">
                <asp:RequiredFieldValidator ID="rfvMono" runat="server" ErrorMessage="Mobile No. Can't be blank" ControlToValidate="txtMono" Text="*" ForeColor="Red"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Please Enter Correct Mobile Number" ControlToValidate="txtMono" Enabled="False" ValidateRequestMode="Inherit" ValidationExpression="\d{9,10}" Text="#"></asp:RegularExpressionValidator>
            </div>
        </div>
        <div class="row m-2" style="text-align:left">
            <div class="col-sm-3">
                <asp:Label ID="Label4" runat="server" Text="Enter Email Id"></asp:Label>
            </div>
            <div class="col-sm-4">
                <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="col-sm-2">
                <asp:RequiredFieldValidator ID="rfvEmail" runat="server" ErrorMessage="Email Id Can't be Blank" ControlToValidate="txtEmail" Text="*" ForeColor="Red"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="Please Enter Valid Email ID" ValidationExpression="^\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}$" ControlToValidate="txtEmail" Text="@"></asp:RegularExpressionValidator>
            </div>
        </div>
        <asp:HiddenField runat="server" ID="hdnErnollno" />
        <div class="row m-2" style="text-align:left">
            <div class="col-sm-3">
                <asp:Label runat="server" Text="Birth Date"></asp:Label>
            </div>
            <div class="col-sm-4">
                <asp:TextBox runat="server" TextMode="Date" ID="txtDOB" CssClass="form-control"></asp:TextBox>
            </div>
        </div>
       <div class="row m-2">
           <asp:Button Text="Update" CssClass="btn btn-outline-warning col-2" runat="server"  ID="btnUpdate" OnClick="btnUpdate_Click" />
       </div>
   </div>
</asp:Content>

