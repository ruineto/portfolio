<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="FinalProject.Contact" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <hgroup class="title">
        <h1><%: Title %>.</h1>
        <h2>Contactos.</h2>
    </hgroup>

    <section class="contact">
        <header>
            <h3>Telefone:</h3>
        </header>
        <p>
            24/7<span class="label">:</span>
            239 123 321
        </p>
        <p>
            Fax<span class="label">:</span>
            239 123 321</p>
    </section>

    <section class="contact">
        <header>
            <h3>Email:</h3>
        </header>
        <p>
            <span class="label">Suporte:</span>
            suporte<span><a href="mailto:Support@example.com">@viki.com</a></span>
        </p>
        <p>
            <span class="label">Marketing:</span>
            marketing<span><a href="mailto:Marketing@example.com">@viki.com</a></span>
        </p>
        <p>
            <span class="label">Geral:</span>
            gera<span>l<a href="mailto:General@example.com">@viki.com</a></span>
        </p>
    </section>

    <section class="contact">
        <header>
            <h3>Morada:</h3>
        </header>
        <p>
            <span style="color: rgb(68, 68, 68); font-family: Tahoma, Helvetica, Helv, sans-serif; font-size: 12px; font-style: normal; font-variant: normal; font-weight: normal; letter-spacing: normal; line-height: normal; orphans: auto; text-align: left; text-indent: 0px; text-transform: none; white-space: normal; widows: auto; word-spacing: 0px; -webkit-text-stroke-width: 0px; display: inline !important; float: none;">Incubadora de Empresas da Universidade de Aveiro</span><br style="color: rgb(68, 68, 68); font-size: 12px; font-style: normal; font-variant: normal; font-weight: normal; letter-spacing: normal; line-height: normal; orphans: auto; text-align: left; text-indent: 0px; text-transform: none; white-space: normal; widows: auto; word-spacing: 0px; -webkit-text-stroke-width: 0px; font-family: tahoma, sans-serif;" />
            <span style="color: rgb(68, 68, 68); font-family: Tahoma, Helvetica, Helv, sans-serif; font-size: 12px; font-style: normal; font-variant: normal; font-weight: normal; letter-spacing: normal; line-height: normal; orphans: auto; text-align: left; text-indent: 0px; text-transform: none; white-space: normal; widows: auto; word-spacing: 0px; -webkit-text-stroke-width: 0px; display: inline !important; float: none;">Campus Universitário de Santiago,&nbsp;Edifício 1</span><br style="color: rgb(68, 68, 68); font-size: 12px; font-style: normal; font-variant: normal; font-weight: normal; letter-spacing: normal; line-height: normal; orphans: auto; text-align: left; text-indent: 0px; text-transform: none; white-space: normal; widows: auto; word-spacing: 0px; -webkit-text-stroke-width: 0px; font-family: tahoma, sans-serif;" />
            <span style="color: rgb(68, 68, 68); font-family: Tahoma, Helvetica, Helv, sans-serif; font-size: 12px; font-style: normal; font-variant: normal; font-weight: normal; letter-spacing: normal; line-height: normal; orphans: auto; text-align: left; text-indent: 0px; text-transform: none; white-space: normal; widows: auto; word-spacing: 0px; -webkit-text-stroke-width: 0px; display: inline !important; float: none;">3810-193 Aveiro</span><br style="color: rgb(68, 68, 68); font-size: 12px; font-style: normal; font-variant: normal; font-weight: normal; letter-spacing: normal; line-height: normal; orphans: auto; text-align: left; text-indent: 0px; text-transform: none; white-space: normal; widows: auto; word-spacing: 0px; -webkit-text-stroke-width: 0px; font-family: tahoma, sans-serif;" />
            <span style="color: rgb(68, 68, 68); font-family: Tahoma, Helvetica, Helv, sans-serif; font-size: 12px; font-style: normal; font-variant: normal; font-weight: normal; letter-spacing: normal; line-height: normal; orphans: auto; text-align: left; text-indent: 0px; text-transform: none; white-space: normal; widows: auto; word-spacing: 0px; -webkit-text-stroke-width: 0px; display: inline !important; float: none;">Portugal</span></p>
    </section>
</asp:Content>