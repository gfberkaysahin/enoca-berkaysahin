<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="FilmEkle.aspx.cs" Inherits="enoca.FilmEkle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form id="Form1" runat="server">
        <div class="container">
            <div class="row">
                <div class="col-lg-6 col-md-6 col-sm-12" style="float: none; margin: 10% auto;">
                    <div class="form-group">
                        <div>
                            <strong>
                                <asp:Label for="TxtName" runat="server" Text="Film Adı: "></asp:Label>
                            </strong>
                            <asp:TextBox ID="TxtName" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                        <br />
                        <div>
                            <strong>
                                <asp:Label for="TxtGenre" runat="server" Text="Film Türü: "></asp:Label>
                            </strong>
                            <asp:TextBox ID="TxtGenre" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                        <br />
                        <div>
                            <strong>
                                <asp:Label for="TxtDirector" runat="server" Text="Film Yönetmeni: "></asp:Label>
                            </strong>
                            <asp:TextBox ID="TxtDirector" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                        <br />
                        <div>
                            <strong>
                                <asp:Label for="TxtYear" runat="server" Text="Film Yılı: "></asp:Label>
                            </strong>
                            <asp:TextBox ID="TxtYear" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                        <br />
                        <div>
                            <strong>
                                <asp:Label for="TxtCinema" runat="server" Text="Salon No: "></asp:Label>
                            </strong>
                            <asp:TextBox ID="TxtCinema" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                    </div>
                    <asp:Button ID="Button1" runat="server" Text="Ekle" CssClass="btn btn-info" OnClick="Button1_Click" />
                </div>
            </div>
        </div>
    </form>
</asp:Content>
