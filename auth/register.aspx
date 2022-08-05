<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Blank.Master" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="RealProjectB1.auth.regirter" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .input-group-text,
        .form-control,
        .btn{
            border-radius:0px !important;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid bg-gradient-success">
        <div class="container">
            <div class="row justify-content-center">
                <div class="col-md-10">
                    <div class="site_logo  mt-5 text-center">
                        <img class="img-fluid w-25" src="../assets/img/logo.png" alt="Alternate Text" />
                    </div>
                    <div id="divMsg" runat="server" class="alert alert-danger">
                        <asp:Label ID="lblMsg" runat="server" Text=""></asp:Label>
                    </div>
                    <div class="card mb-5">
                        <div class="card-header bg-gradient-primary text-light">
                            Personal Details
                        </div>
                        <div class="card-body">
                            <div class="row">
                                <div class="col-md-3">
                                    <label class="form-label">First Name</label>
                                    <asp:TextBox ID="txtFirstName" runat="server" CssClass="form-control"></asp:TextBox>
                                </div>
                                <div class="col-md-3">
                                    <label class="form-label">Middle Name</label>
                                    <asp:TextBox ID="txtMiddleName" runat="server" CssClass="form-control"></asp:TextBox>
                                </div>
                                <div class="col-md-3">
                                    <label class="form-label">Last Name</label>
                                    <asp:TextBox ID="txtLastName" runat="server" CssClass="form-control"></asp:TextBox>
                                </div>
                                <div class="col-md-3">
                                    <label class="form-label">User Name</label>
                                    <asp:TextBox ID="txtUserName" runat="server" CssClass="form-control"></asp:TextBox>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-md-6">
                                    <label class="form-label">Date Of Birth</label>
                                    <asp:TextBox ID="txtDateOfBirth" runat="server" CssClass="form-control datepicker" TextMode="Date"></asp:TextBox>

                                    <%--                   <div class="col-md-6">
                                        <input type="text" class="form-control datepicker" placeholder="Select Date" />
                                    </div>--%>
                                </div>
                                <div class="col-md-6">
                                    <label class="form-label">Gender</label>
                                    <asp:DropDownList ID="ddlGender" runat="server" CssClass="form-control">
                                        <asp:ListItem Value="0">Select ---</asp:ListItem>
                                        <asp:ListItem Value="1">Male</asp:ListItem>
                                        <asp:ListItem Value="2">Female</asp:ListItem>
                                        <asp:ListItem Value="3">Others</asp:ListItem>
                                    </asp:DropDownList>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-md-4">
                                    <label class="form-label">Contact Number</label>
                                    <asp:TextBox ID="txtContactNumber" runat="server" CssClass="form-control"></asp:TextBox>
                                </div>
                                <div class="col-md-4">
                                    <label class="form-label">Email</label>
                                    <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control "></asp:TextBox>
                                </div>
                                <div class="col-md-4">
                                    <label class="form-label">Religion</label>
                                    <asp:DropDownList ID="ddlReligion" runat="server" CssClass="form-control" >
                                        
                                        <asp:ListItem Value="0">Select ---</asp:ListItem>
                                        <asp:ListItem Value="1">Islam</asp:ListItem>
                                        <asp:ListItem Value="2">Hindu</asp:ListItem>
                                        <asp:ListItem Value="3">Others</asp:ListItem>
                                    </asp:DropDownList>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-md-12">
                                    <label class="form-label">Address</label>
                                    <asp:TextBox ID="txtAddress" runat="server" CssClass="form-control" TextMode="MultiLine"></asp:TextBox>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-md-12">
                                    <label class="form-label">User Image</label>
                                    <asp:FileUpload ID="fuUserImage" runat="server" CssClass="form-control" />
                                </div>
                            </div>
                            <div class="row mt-4">
                                <div class="col-md-12">
                                    <asp:Button ID="btnRegister" runat="server" Text="Save" CssClass="btn btn-primary" OnClick="btnRegister_Click" />
                                </div>
                            </div>

                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
