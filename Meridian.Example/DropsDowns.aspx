<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="DropsDowns.aspx.vb" Inherits="Meridian.Example.DropsDowns" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Meridian - Example</title>
    <link href="bernie.css" rel="stylesheet" type="text/css"/>
</head>
<body>
    <div class="centre">
        <form id="form1" runat="server">
            <div>
                <div class="site">
                    <asp:Label runat="server">Sites</asp:Label>
                    <asp:DropDownList ID="SiteDropDown" runat="server"></asp:DropDownList>
                    <asp:Button ID="EditSiteButton" runat="server" Text="Edit" />
                </div>
                <div class="doctype">
                    <asp:Label runat="server">Document Types</asp:Label>
                    <asp:DropDownList ID="DocumentTypeDropDown" runat="server"></asp:DropDownList>
                    <asp:Button ID="EditDocTypeButton" runat="server" Text="Edit" />
                </div>
            </div>
        </form>
    </div>
</body>
</html>
