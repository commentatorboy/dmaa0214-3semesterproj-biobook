﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Resever.aspx.cs" Inherits="ClientWebApp.Resever" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

   
     <div class="container">
         <div class="col-md-12">
                <div class="thumbnail">
             <asp:Literal ID="litMovieInfo" runat="server"></asp:Literal>

                    </div>
         </div>
   
        <div class="col-md-4 col-sm-6">
            <div class="thumbnail">

                <span class="glyphicon glyphicon-film"></span>
                <div class="title">
                    VÆLG <b>BILLETTER</b>
                </div>

            </div>
        </div>
        <div class="col-md-4 col-sm-6">
            <div class="thumbnail">
                <span class="glyphicon glyphicon-th"></span>
                  <div class="title">
                     VÆLG <b>PLACERING</b>   
            </div>
            </div>

        </div>
 <%--       <div class="col-md-4 col-sm-6">
             <div class="thumbnail">
                <span class="glyphicon glyphicon-credit-card"></span>
                  <div class="title">
                     VÆLG <b>BETALING/KVITTERING</b>   
            </div>
            </div>

        </div>--%>
    </div>


</asp:Content>