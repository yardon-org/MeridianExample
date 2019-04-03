<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="DropsDowns.aspx.vb" Inherits="Meridian.Example.DropsDowns" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Meridian - Example</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div>
                <asp:DropDownList ID="SiteDropDown" runat="server"></asp:DropDownList>
                <asp:Button ID="EditSiteButton" runat="server" Text="Edit" />
            </div>
            <div>
                <asp:DropDownList ID="DocumentTypeDropDown" runat="server">
                </asp:DropDownList>
                <asp:Button ID="EditDocTypeButton" runat="server" Text="Edit" />
            </div>
        </div>
    </form>
</body>
</html>
