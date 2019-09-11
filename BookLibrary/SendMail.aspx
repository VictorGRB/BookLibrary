<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SendMail.aspx.cs" Inherits="BookLibrary.SendMail" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="gvBookLibrary" runat="server" AutoGenerateColumns="false">
                <Columns>
                    <asp:Boundfield DataField="Name" HeaderText="Full Name" />
                    <asp:Boundfield DataField="EmailAddress" HeaderText="Email" />
                    <asp:Boundfield DataField="Address" HeaderText="Address" />
                    <asp:Boundfield DataField="PhoneNumber" HeaderText="Phone Number" />
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:LinkButton ID="lnkSelect" Text="Send as Email" runat="server"></asp:LinkButton>
                        </ItemTemplate>

                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
