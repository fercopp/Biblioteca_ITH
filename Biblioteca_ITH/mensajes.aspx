<%@ Page Title="" Language="C#" MasterPageFile="~/Back.Master" AutoEventWireup="true" CodeBehind="mensajes.aspx.cs" Inherits="Biblioteca_ITH.mensajes" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="content mt-3">
        <div class="animated fadeIn">
            <div class="row">
                <div class="col-md-12">
                    <div class="card">
                        <div class="card-header">
                            <strong class="card-title">Mensajes</strong>
                        </div>
                        <div class="card-body">
                            <table id="bootstrap-data-table-export" class="table table-striped table-bordered">
                                <thead>
                                    <tr>
                                        <th>Nombre Completo</th>
                                        <th>Email</th>
                                        <th>Sugerencia o Mensaje</th>
                                    </tr>
                                </thead>
                                <tbody>
                                        
                                    <asp:ListView ID="lstContactos" runat="server">
                                        <ItemTemplate>
                                            <tr>
                                                <td><asp:Literal ID="litNombre" Text='<%#Eval("nombre")+" "+Eval("primer_apellido") + " "+ Eval("segundo_apellido")%>' runat="server"></asp:Literal></td>
                                                <td><asp:Literal ID="litEmail" Text='<%#Eval("email") %>' runat="server"></asp:Literal></td>

                                                <td><asp:Literal ID="litTipo" Text='<%#Eval("sugerencia") %>' runat="server"></asp:Literal></td>
                                            </tr>
                                        </ItemTemplate>
                                    </asp:ListView>
                                </tbody>
                            </table>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

