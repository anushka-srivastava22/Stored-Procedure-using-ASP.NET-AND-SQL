<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="details.aspx.cs" Inherits="emp_details.details" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" OnRowDataBound ="OnRowDataBound">
            <Columns>
                <asp:BoundField DataField="Item" HeaderText="Item" ItemStyle-Width="100" />
                <asp:BoundField DataField="Quantity" HeaderText="Quantity" ItemStyle-Width="100" />
            </Columns>
        </asp:GridView>
    </div>
    </form>
</body>
</html>
