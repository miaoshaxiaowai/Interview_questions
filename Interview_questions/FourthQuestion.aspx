<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FourthQuestion.aspx.cs" Inherits="Interview_questions.FourthQuestion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <h1><center>第四题：除第一条和最后一条的所有Orders数据</center></h1>
         <h2><a href="/">返回第三步</a>
   
        <a href="fifthQuestion.aspx">前往第五步</a></h2>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="White" BorderStyle="Ridge" BorderWidth="2px" CellPadding="3" CellSpacing="1" GridLines="None">
                <Columns>
                    <asp:BoundField DataField="OrderID" HeaderText="OrderID" />
                    <asp:BoundField DataField="OrderNum" HeaderText="OrderNum" />
                    <asp:BoundField DataField="Hospital" HeaderText="Hospital" />
                    <asp:BoundField DataField="Doctor" HeaderText="Doctor" />
                    <asp:BoundField DataField="Patient" HeaderText="Patient" />
                    <asp:BoundField DataField="OrderKind" HeaderText="OrderKind" />
                    <asp:BoundField DataField="SaveTime" HeaderText="SaveTime" />
                    <asp:BoundField DataField="AcceptDate" HeaderText="AcceptDate" />
                    <asp:BoundField DataField="PlanDate" HeaderText="PlanDate" />
                    <asp:BoundField DataField="FinishDate" HeaderText="FinishDate" />
                    <asp:BoundField DataField="Products" HeaderText="Products" />
                </Columns>
                <FooterStyle BackColor="#C6C3C6" ForeColor="Black" />
                <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#E7E7FF" />
                <PagerStyle BackColor="#C6C3C6" ForeColor="Black" HorizontalAlign="Right" />
                <RowStyle BackColor="#DEDFDE" ForeColor="Black" />
                <SelectedRowStyle BackColor="#9471DE" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#594B9C" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#33276A" />
            </asp:GridView>
        </div>
    </form>
</body>
</html>
