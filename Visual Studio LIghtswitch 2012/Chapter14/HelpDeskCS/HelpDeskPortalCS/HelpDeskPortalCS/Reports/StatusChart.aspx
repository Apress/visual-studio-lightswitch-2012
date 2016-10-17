<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StatusChart.aspx.cs" Inherits="HelpDeskPortalCS.Reports.StatusChart" %>
<%@ Register Assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>
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
            <%--Listing 14-1. Counting Issues Created Within the Last Seven Days, Grouped by Status--%>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:HelpDeskCSConnectionString %>" 
                SelectCommand="SELECT iss.StatusDescription, COUNT(i.Id) AS IssueCount FROM Issues AS i INNER JOIN IssueStatusSet AS iss ON i.Issue_IssueStatus = iss.Id WHERE (i.CreateDateTime &gt;= DATEADD(DAY, DATEDIFF(DAY, 0, GETDATE()) - 200, 0)) GROUP BY iss.StatusDescription"></asp:SqlDataSource>

            <asp:Chart ID="Chart1" runat="server" DataSourceID="SqlDataSource1">
                <Series>
                    <asp:Series ChartType="Pie" Name="Series1" XValueMember="StatusDescription" YValueMembers="IssueCount">
                    </asp:Series>
                </Series>
                <ChartAreas>
                    <asp:ChartArea Name="ChartArea1">
                    </asp:ChartArea>
                </ChartAreas>
            </asp:Chart>

        </div>
    </form>
</body>
</html>
