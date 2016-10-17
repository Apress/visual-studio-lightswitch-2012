<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="IssuesByEngineer.aspx.cs" Inherits="HelpDeskPortalCS.Reports.IssuesByEngineer" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
    <%--
You can use and redistribute the code from this book (and sample application) for non-commercial and 
most commercial purposes as long as you acknowledge the source and authorship. 
You should note the source of the code in any documentation as well as in the program code itself (as a comment). 
The acknowledgment should include author, title, publisher, and ISBN. 
An example of such an acknowledgment would be "Derived from Listing 2-10, LightSwitch 2012 by Tim Leung, published by Apress, ISBN 9781430250715".--%>


<head id="Head1" runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:HelpDeskCSConnectionString %>"
                SelectCommand="SELECT iss.CreateDateTime, iss.Subject, iss.TargetEndDateTime, iss.ClosedDateTime FROM Issues AS iss INNER JOIN Engineers AS eng ON iss.Engineer_Issue = eng.Id WHERE (eng.Id = @EngineerID)">
                <SelectParameters>
                    <asp:QueryStringParameter DefaultValue="1" Name="EngineerID" QueryStringField="EngineerId" />
                </SelectParameters>
            </asp:SqlDataSource>

            <input type="button" value="Print"
                onclick="javascript: window.print()" />

            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:BoundField DataField="CreateDateTime" HeaderText="CreateDateTime" SortExpression="CreateDateTime" />
                    <asp:BoundField DataField="Subject" HeaderText="Subject" SortExpression="Subject" />
                    <asp:BoundField DataField="TargetEndDateTime" HeaderText="TargetEndDateTime" SortExpression="TargetEndDateTime" />
                    <asp:BoundField DataField="ClosedDateTime" HeaderText="ClosedDateTime" SortExpression="ClosedDateTime" />
                </Columns>
                <EditRowStyle BackColor="#2461BF" />
                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#EFF3FB" />
                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#F5F7FB" />
                <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                <SortedDescendingCellStyle BackColor="#E9EBEF" />
                <SortedDescendingHeaderStyle BackColor="#4870BE" />
            </asp:GridView>

        </div>
    </form>
</body>
</html>
