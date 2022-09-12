<%@ Page Title="" Language="C#" MasterPageFile="~/adminHome.master" AutoEventWireup="true" CodeFile="AddStudent.aspx.cs" Inherits="AddStudent" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <center>
        <div class="container">
            <div class="card col-sm-8">
                <div class="card-header bg-info">
                    <h2 class="">Add Student Data</h2>
                </div>
                <div class="card-body">
                    <div class="row m-2" >
                        <asp:Label ID="lblmsg" runat="server"></asp:Label>
                    </div>
                    <div class="row m-2" style="text-align:left">
                        <div class="col-sm-4" style="text-align:left">
                            <asp:Label ID="lblRno" runat="server" Text="Enter Roll No"></asp:Label>
                        </div>
                        <div class="col-sm-6">
                            <asp:TextBox ID="txtRno" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="col-sm-2">
                            <asp:RequiredFieldValidator ID="rfvRno" runat="server" ErrorMessage="Please Enter Roll No." Text="*" ForeColor="Red" ControlToValidate="txtRno"></asp:RequiredFieldValidator>
                        </div>
                    </div>
                    <div class="row m-2" style="text-align:left">
                        <div class="col-sm-4">
                            <asp:Label ID="Label1" runat="server" Text="Enter Name"></asp:Label>
                        </div>
                        <div class="col-sm-6" >
                            <asp:TextBox ID="txtName" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="col-sm-2">
                            <asp:RequiredFieldValidator ID="rfvName" runat="server" ErrorMessage="Name Can't be blank" ControlToValidate="txtName" Text="*" ForeColor="Red"></asp:RequiredFieldValidator>
                        </div>
                    </div>

                    <div class="row m-2" style="text-align:left">
                        <div class="col-sm-4">
                            <asp:Label ID="Label2" runat="server" Text="Select Course "></asp:Label>
                        </div>
                        <div class="col-sm-6">
                            <asp:DropDownList ID="ddlCourse" runat="server" AutoPostBack="true" CssClass="form-select" OnSelectedIndexChanged="ddlCourse_SelectedIndexChanged">
                             
                            </asp:DropDownList>
                        </div>
                        <div class="col-sm-2">
                            <asp:RequiredFieldValidator ID="rfvCourse" runat="server" ErrorMessage="Please Select Course" ControlToValidate="ddlCourse" Text="*" ForeColor="Red"></asp:RequiredFieldValidator>
                        </div>
                    </div>
                    <div class="row m-2" style="text-align:left">
                        <div class="col-sm-4">
                            <asp:Label ID="Label5" runat="server" Text="Select Course "></asp:Label>
                        </div>
                        <div class="col-sm-6">
                            <asp:DropDownList ID="ddlClass" runat="server" CssClass="form-select">
                            </asp:DropDownList>
                        </div>
                        <div class="col-sm-2">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Please Select Course" ControlToValidate="ddlCourse" Text="*" ForeColor="Red"></asp:RequiredFieldValidator>
                        </div>
                    </div>
                    <div class="row m-2" style="text-align:left">
                        <div class="col-sm-4">
                            <asp:Label ID="Label3" runat="server" Text="Enter Mobile No."></asp:Label>
                        </div>
                        <div class="col-sm-6">
                            <asp:TextBox ID="txtMono" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="col-sm-2">
                            <asp:RequiredFieldValidator ID="rfvMono" runat="server" ErrorMessage="Mobile No. Can't be blank" ControlToValidate="txtMono" Text="*" ForeColor="Red"></asp:RequiredFieldValidator>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Please Enter Correct Mobile Number" ControlToValidate="txtMono" Enabled="False" ValidateRequestMode="Inherit" ValidationExpression="\d{9,10}" Text="#"></asp:RegularExpressionValidator>
                        </div>
                    </div>

                    <div class="row m-2" style="text-align:left">
                        <div class="col-sm-4">
                            <asp:Label ID="Label4" runat="server" Text="Enter Email Id"></asp:Label>
                        </div>
                        <div class="col-sm-6">
                            <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="col-sm-2">
                            <asp:RequiredFieldValidator ID="rfvEmail" runat="server" ErrorMessage="Email Id Can't be Blank" ControlToValidate="txtEmail" Text="*" ForeColor="Red"></asp:RequiredFieldValidator>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="Please Enter Valid Email ID" ValidationExpression="^\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}$" ControlToValidate="txtEmail" Text="@"></asp:RegularExpressionValidator>
                        </div>
                    </div>
                    <div class="row m-2" style="text-align:left">
                        <div class="col-sm-4">
                            <asp:Label runat="server" Text="Birth Date"></asp:Label>
                        </div>
                        <div class="col-sm-6">
                            <asp:TextBox runat="server" TextMode="Date" ID="txtDOB" CssClass="form-control"></asp:TextBox>
                        </div>
                    </div>
                    <div class="row m-1">
                        <div class="col-sm-4">
                            <asp:Button ID="btnSave" runat="server" Text="Add" CssClass="btn btn-outline-success btn-block" OnClick="btnSave_Click"/>
                        </div>
                    </div>
                </div>
                

                <asp:ValidationSummary ID="ValidationSummary1" runat="server" CssClass="alert-danger" />
            </div>
        </div>
        <div class="col-sm-12 m-3 ms-5">
            
        </div>  
            </center>
</asp:Content>

