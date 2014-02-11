<%@ Page Title="VIKI - Principal" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="FinalProject._Default" %>


<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <aside><img src="/Images/digitalhouse2.jpg" style="width: 100%; align-self:center;" /></aside>
    <article>
        <h3>VIKI</h3>
        <aside>
            <div>
                <label style="margin-bottom:10px"><asp:Label ID="weatherDescription" runat="server"></asp:Label></label>
                <asp:Image ID="weatherIcon" runat="server"/>
                <div><label>Temperatura:</label><label><asp:Label ID="weatherTemperature" runat="server"></asp:Label></label></div>
            </div>
        </aside>
        <ol class="round">
            <li class="one">
                <h5>Entretenimento</h5>
                O acesso imediato a conteúdos multimédia e de entretenimento são actualmente indicadores de qualidade de vida.
            </li>
            <li class="two">
                <h5>Comunicação</h5>
                A tecnologia quebrou barreiras e leva-nos para junto de quem mais gostamos, em qualquer momento e de diversas formas.
            </li>
            <li class="three">
                <h5>Segurança</h5>
                Indispensáveis nos dias de hoje, as tecnologias de segurança funcionam como método anti-intrusão e como prevenção de acidentes domésticos.
            </li>
            <li class="four">
                <h5>Conforto</h5>
                Já imaginou a sua casa ajustada às suas exigências de conforto?
                Na Casa Digital pode programar a abertura e fecho de estores, a temperatura e a iluminação permitindo poupança de energia e o seu bem-estar.
            </li>
        </ol>
    </article>
</asp:Content>
