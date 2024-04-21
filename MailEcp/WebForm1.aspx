<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="MailEcp.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table>
            <tr>
                <td>
                    <asp:Label ID="lblFrom" runat="server" Text="From:" />
                </td>
                <td>
                    <asp:TextBox ID="txtFromAddress" runat="server" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblToAddress" runat="server" Text="ToAddress:" />
                </td>
                <td>
                    <asp:TextBox ID="txtToAddress" runat="server" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblSubject" runat="server" Text="Subject:" />
                </td>
                <td>
                    <asp:TextBox ID="txtSubject" runat="server" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblBody" Text="Body" runat="server" />
                </td>
                <td>
                    <asp:TextBox ID="txtBody" runat="server" TextMode="MultiLine" Rows="10" 
                        Columns="7" Width="489px" />
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Button ID="btnSubmit" runat="server" Text="Send" 
                        onclick="btnSubmit_Click" />
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
