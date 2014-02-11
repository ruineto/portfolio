<%@ Page Title="Register" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="FinalProject.Account.Register" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <hgroup class="title">
        <h1><%: Title %>.</h1>
        <h2>Criar uma conta nova.</h2>
    </hgroup>

    <asp:CreateUserWizard runat="server" ID="RegisterUser" ViewStateMode="Disabled" OnCreatedUser="RegisterUser_CreatedUser">
        <LayoutTemplate>
            <asp:PlaceHolder runat="server" ID="wizardStepPlaceholder" />
            <asp:PlaceHolder runat="server" ID="navigationPlaceholder" />
        </LayoutTemplate>
        <WizardSteps>
            <asp:CreateUserWizardStep runat="server" ID="RegisterUserWizardStep">
                <ContentTemplate>
                    <p class="message-info">
                        Passwords são obrigatórias com um minimo de <%: Membership.MinRequiredPasswordLength %> caracteres.
                    </p>

                    <p class="validation-summary-errors">
                        <asp:Literal runat="server" ID="ErrorMessage" />
                    </p>

                    <fieldset>
                        <legend>Registo</legend>
                        <ol>
                            <li>
                                <asp:Label runat="server" AssociatedControlID="UserName">Username</asp:Label>
                                <p>
                                    <asp:TextBox runat="server" ID="UserName" />@viki.com
                                </p>
                                <asp:RequiredFieldValidator runat="server" ControlToValidate="UserName"
                                    CssClass="field-validation-error" ErrorMessage="Campo obrigatório." />
                            </li>
                            <li>
                                <asp:Label ID="Label12" runat="server" AssociatedControlID="Email">Email address</asp:Label>
                                <asp:TextBox runat="server" ID="Email" TextMode="Email" />
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server" ControlToValidate="Email"
                                    CssClass="field-validation-error" ErrorMessage="The email address field is required." />
                            </li>
                            <li>
                                <asp:Label runat="server" AssociatedControlID="Password">Password</asp:Label>
                                <asp:TextBox runat="server" ID="Password" TextMode="Password" />
                                <asp:RequiredFieldValidator runat="server" ControlToValidate="Password"
                                    CssClass="field-validation-error" ErrorMessage="Campo obrigatório." />
                            </li>
                            <li>
                                <asp:Label runat="server" AssociatedControlID="ConfirmPassword">Confirm password</asp:Label>
                                <asp:TextBox runat="server" ID="ConfirmPassword" TextMode="Password" />
                                <asp:RequiredFieldValidator runat="server" ControlToValidate="ConfirmPassword"
                                    CssClass="field-validation-error" Display="Dynamic" ErrorMessage="Campo obrigatório." />
                                <asp:CompareValidator runat="server" ControlToCompare="Password" ControlToValidate="ConfirmPassword"
                                    CssClass="field-validation-error" Display="Dynamic" ErrorMessage="As passwords não coincidem." />
                            </li>
                            <li class="email">
                                <asp:Label ID="Label1" runat="server" AssociatedControlID="userName">User name</asp:Label>
                                <asp:TextBox runat="server" ID="TextBox1" />
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="userName"
                                    Display="Dynamic" ErrorMessage="User name is required" ValidationGroup="NewUser" />

                                <asp:ModelErrorMessage ID="ModelErrorMessage1" runat="server" ModelStateKey="UserName" CssClass="field-validation-error" />

                            </li>
                        </ol>

                        <asp:Button runat="server" CommandName="MoveNext" Text="Register" />
                    </fieldset>
                </ContentTemplate>
                <CustomNavigationTemplate />
            </asp:CreateUserWizardStep>
        </WizardSteps>
    </asp:CreateUserWizard>
</asp:Content>
