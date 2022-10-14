<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="FilmListesi.aspx.cs" Inherits="enoca.FilmListesi2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <html lang="en">
    <head>
        <title>Enoca Berkay Şahin</title>
        <meta charset="utf-8">
        <meta name="viewport" content="width=device-width, initial-scale=1">
        <%--<link href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.1/dist/css/bootstrap.min.css" rel="stylesheet">
  <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.2.1/dist/js/bootstrap.bundle.min.js"></script>--%>
        <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">
        <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
        <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
        <script src="./filter.js"></script>
    </head>
    <body>
        <div class="container">
            <div class="row">
                <div class="col-lg-12 col-md-6 col-sm-12" style="float: none; margin: 10% auto;">
                    <div class="outer-wrapper">
                        <div class="table-wrapper">
                            <table id="emp-table" class="table table-bordered table-hover">
                                <thead>
                                    <th>ID</th>
                                    <th col-index="2">Film Adı
                    <select class="table-filter" onchange="filter_rows()">
                        <option value="all"></option>
                    </select>
                                    </th>
                                    <th col-index="3">Film Türü
                    <select class="table-filter" onchange="filter_rows()">
                        <option value="all"></option>
                    </select>
                                    </th>
                                    <th col-index="4">Film Yönetmeni
                    <select class="table-filter" onchange="filter_rows()">
                        <option value="all"></option>
                    </select>
                                    </th>
                                    <th col-index="5">Film Yılı
                    <select class="table-filter" onchange="filter_rows()">
                        <option value="all"></option>
                    </select>
                                    </th>
                                    </th>
                                    <th col-index="6">Salon Adı
                    <select class="table-filter" onchange="filter_rows()">
                        <option value="all"></option>
                    </select>
                                    </th>
                                    <th>İşlemler</th>
                                </thead>
                                <tbody>
                                    <asp:Repeater ID="rp1" runat="server">
                                        <ItemTemplate>
                                            <tr>
                                                <td><%#Eval("Id")%></td>
                                                <td><%#Eval("Name")%></td>
                                                <td><%#Eval("Genre")%></td>
                                                <td><%#Eval("Director")%></td>
                                                <td><%#Eval("Year")%></td>
                                                <td><%#Eval("SName")%></td>
                                                <td>
                                                    <asp:HyperLink NavigateUrl='<%# "~/FilmSil.aspx?ID="+Eval("Id") %>' ID="HyperLink1" CssClass="btn btn-danger" runat="server">Sil</asp:HyperLink>
                                                    <asp:HyperLink NavigateUrl='<%# "~/FilmGuncelle.aspx?ID="+Eval("Id") %>' ID="HyperLink2" CssClass="btn btn-success" runat="server">Güncelle</asp:HyperLink>
                                                </td>

                                            </tr>
                                        </ItemTemplate>
                                    </asp:Repeater>
                                </tbody>
                            </table>

                        </div>
                    </div>
                </div>
            </div>
        </div>
    </body>
    <script>
        window.onload = () => {
            console.log(document.querySelector("#emp-table > tbody > tr:nth-child(1) > td:nth-child(2) ").innerHTML);
        };
        getUniqueValuesFromColumn()
    </script>
    </html>
</asp:Content>
